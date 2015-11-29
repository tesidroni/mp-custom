using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenCvSharp;
using System.Threading;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using SlimDX;
using SlimDX.DirectInput;
using AForge.Video.FFMPEG;
using AForge.Video.DirectShow;
using AForge.Video;


namespace MissionPlanner.GCSViews
{
    public partial class Video : Form
    {
        private Thread _thread;
        int counter = 0;
        SlimDX.DirectInput.Joystick[] sticks;
        DirectInput input = new DirectInput();
        SlimDX.DirectInput.Joystick stick = null;
        FilterInfoCollection videoDevices;

        int xVal = 0; int yVal = 0; int zVal = 0;
        int xpos_l = 0; int ypos_l = 0;
        int xpos_r = 0; int ypos_r = 0;

        bool keyPressed = false;

        public static string Path { get; set; }

        public Video()
        {
            InitializeComponent();
            sticks = GetStick(input, stick);
            timer1.Enabled = true;
        }


        private void Video_Load(object sender, EventArgs e)
        {
            Oculus form = new Oculus();
            Path = form.Path_ret;
            Screen[] sc = Screen.AllScreens;
            int w = sc[0].Bounds.Width;
            int h = sc[0].Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
            imgWatermark = new Bitmap(imgWatermark);
            imgWatermark_2 = new Bitmap(imgWatermark_2);

            // get the collection of video input devices
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            videoSource.NewFrame += video_NewFrame;
            videoSource.Start();

        }

        private void Video_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27)
            {
                if (_thread != null && _thread.IsAlive)
                {
                    _thread.Abort();
                    _thread = null;
                }

                this.Close();
            }

            //se si preme spazio metto oggetti grafici
            if (e.KeyChar == ' ')
            {
                if (!keyPressed)
                    keyPressed = true;
                else
                    keyPressed = false;
            }


        }

        CvCapture cap;
        private VideoCaptureDevice videoSource = null;
        Bitmap bm;
        Image imgWatermark_2 = Image.FromFile("button mooving.png");
        Image imgWatermark = Image.FromFile("button base.png");
        ////background circle
        float xPosOfWm = 0;
        float yPosOfWm = 0;

        float xPosOfWm_2 = 0;
        float yPosOfWm_2 = 0;
        Image img;
        void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            bm = (Bitmap)eventArgs.Frame.Clone();

            if (keyPressed)
            {
                ////background circle
                xPosOfWm = 300;
                yPosOfWm = bm.Height - 250;

                xPosOfWm_2 = bm.Width - 330;
                yPosOfWm_2 = bm.Height - 250;

                load_image(imgWatermark, bm, xPosOfWm, yPosOfWm);
                load_image(imgWatermark, bm, xPosOfWm_2, yPosOfWm_2);
                xPosOfWm += xpos_l;
                yPosOfWm += ypos_l;
                xPosOfWm_2 += xpos_r;
                yPosOfWm_2 += ypos_r;
                load_image(imgWatermark_2, bm, xPosOfWm, yPosOfWm);
                load_image(imgWatermark_2, bm, xPosOfWm_2, yPosOfWm_2);
            }
            //MotionDetection md = new MotionDetection();
            Bitmap temp = bm;
            //if (KeyPress)
            //    temp = md.ProcessFrame(ref bm);
            //else
            //    temp = bm;

            //Replace the original photgraphs bitmap with the new Bitmap
            pictureBoxOutput.Image = temp;
        }

        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        void load_image(Image imgWatermark, Bitmap bm, float xPosOfWm, float yPosOfWm)
        {
            //Load this Bitmap into a new Graphic Object
            Graphics grWatermark = Graphics.FromImage(bm);

                //To achieve a transulcent watermark we will apply (2) color 
                //manipulations by defineing a ImageAttributes object and 
                //seting (2) of its properties.
                ImageAttributes imageAttributes = new ImageAttributes();

                //The first step in manipulating the watermark image is to replace 
                //the background color with one that is trasparent (Alpha=0, R=0, G=0, B=0)
                //to do this we will use a Colormap and use this to define a RemapTable
                ColorMap colorMap = new ColorMap();

                //My watermark was defined with a background of 100% Green this will
                //be the color we search for and replace with transparency
                colorMap.OldColor = Color.FromArgb(255, 0, 255, 0);
                colorMap.NewColor = Color.FromArgb(0, 0, 0, 0);

                ColorMap[] remapTable = { colorMap };

                imageAttributes.SetRemapTable(remapTable, ColorAdjustType.Bitmap);

                //The second color manipulation is used to change the opacity of the 
                //watermark.  This is done by applying a 5x5 matrix that contains the 
                //coordinates for the RGBA space.  By setting the 3rd row and 3rd column 
                //to 0.3f we achive a level of opacity
                float[][] colorMatrixElements = { 
												new float[] {1.0f,  0.0f,  0.0f,  0.0f, 0.0f},       
												new float[] {0.0f,  1.0f,  0.0f,  0.0f, 0.0f},        
												new float[] {0.0f,  0.0f,  1.0f,  0.0f, 0.0f},        
												new float[] {0.0f,  0.0f,  0.0f,  0.7f, 0.0f},        
												new float[] {0.0f,  0.0f,  0.0f,  0.0f, 1.0f}};
                ColorMatrix wmColorMatrix = new ColorMatrix(colorMatrixElements);

                imageAttributes.SetColorMatrix(wmColorMatrix, ColorMatrixFlag.Default,ColorAdjustType.Bitmap);

                //create a image object containing the watermark
                imgWatermark = resizeImage(imgWatermark, new Size(imgWatermark.Width - 500, imgWatermark.Height - 400));
                int wmWidth = imgWatermark.Width;
                int wmHeight = imgWatermark.Height;

                //For this example we will place the watermark in the upper right
                //hand corner of the photograph. offset down 10 pixels and to the 
                //left 10 pixles

                grWatermark.DrawImage(imgWatermark,
                    new Rectangle((int)xPosOfWm, (int)yPosOfWm, wmWidth, wmHeight),  //Set the detination Position
                    0,                  // x-coordinate of the portion of the source image to draw. 
                    0,                  // y-coordinate of the portion of the source image to draw. 
                    wmWidth,            // Watermark Width
                    wmHeight,		    // Watermark Height
                    GraphicsUnit.Pixel, // Unit of measurment
                    imageAttributes);   //ImageAttributes Object

                grWatermark.Dispose();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        public void StickHandle(SlimDX.DirectInput.Joystick stick, int id)
        {
            JoystickState State = new JoystickState();
            State = stick.GetCurrentState();

            yVal = State.X;
            xVal = State.Y;
            zVal = State.Z;
            int a = State.RotationX;

            ypos_r = -yVal / 2;
            xpos_r = xVal / 2;
            xpos_l = a / 2;
            ypos_l = zVal / 2;
            yVal = State.X;
            xVal = State.Y;
            zVal = State.Z;
            int left_y = State.RotationX;
            ypos_r = -yVal / 2;
            xpos_r = xVal / 2;
            xpos_l = left_y / 2;
            ypos_l = zVal / 2;
            bool[] Buttons = State.GetButtons();

            if (id == 0)
            {
                if (Buttons[2])
                {
                    ypos_r += 1;
                }
                else if (Buttons[1])
                {
                    xpos_r += 1;
                }
                else if (Buttons[0])
                {
                    ypos_r -= 1;
                }
                else if (Buttons[3])
                {
                    xpos_r -= 1;
                }
            }
        }

        public void timer1_Tick(object Sender, EventArgs e)
        {
            for (int i = 0; i < sticks.Length; i++)
            {
                StickHandle(sticks[i], i);
            }
        }

        public SlimDX.DirectInput.Joystick[] GetStick(DirectInput input, SlimDX.DirectInput.Joystick stick)
        {
            List<SlimDX.DirectInput.Joystick> sticks = new List<SlimDX.DirectInput.Joystick>();
            foreach (var device in input.GetDevices(DeviceClass.GameController, DeviceEnumerationFlags.AttachedOnly))
            {
                try
                {
                    stick = new SlimDX.DirectInput.Joystick(input, device.InstanceGuid);
                    stick.Acquire();
                    foreach (var deviceObject in stick.GetObjects())
                    {
                        if ((deviceObject.ObjectType & ObjectDeviceType.Axis) != 0)
                        {
                            stick.GetObjectPropertiesById((int)deviceObject.ObjectType).SetRange(-100, 100);
                        }
                    }
                    sticks.Add(stick);
                }
                catch (Exception)
                {
                    throw;
                }
            }

            return sticks.ToArray();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            for (int i = 0; i < sticks.Length; i++)
            {
                StickHandle(sticks[i], i);
            }
        }

        private void Video_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Video_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource.IsRunning)
            {
                videoSource.Stop();
            }
        }



    }
}
