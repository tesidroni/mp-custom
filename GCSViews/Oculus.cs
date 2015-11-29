using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using ChatNetwork;
using System.Timers;
using MissionPlanner.Controls;
using MissionPlanner.Utilities;
using System.Threading.Tasks;

using OpenCvSharp;
using System.IO;
using System.IO.Ports;
using SharpOVR;

namespace MissionPlanner.GCSViews
{
    public partial class Oculus : MyUserControl, IActivate
    {

        public static string Path { get; set; }
        Video f;
        MotionCamera mc;
        SerialPort serialComPort = new SerialPort();
        public static double Pitch, Yaw, Roll;

        public Oculus()
        {
            InitializeComponent();
            timer1.Enabled = true;
            foreach (string portName in SerialPort.GetPortNames())
            {
                ports.Items.Add(portName);
            }

            if (ports.Items.Count > 0) ports.SelectedIndex = ports.Items.Count - 1;
        }


        public void Activate()
        {
        }

        private void myButton1_Click(object sender, EventArgs e)
        {
            //axWindowsMediaPlayer1.URL = Path;
            //axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void myButton4_Click(object sender, EventArgs e)
        {
            //axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void myButton5_Click(object sender, EventArgs e)
        {
            //axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void myButton2_Click(object sender, EventArgs e)
        {

        }

        public string Path_ret
        {
            get
            {
                return Path;
            }
        }

        private void myButton3_Click(object sender, EventArgs e)
        {
            f.Dispose();
        }

        private void myButton6_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            if (openfile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Path = openfile.FileName;
            }

        }

        private void myButton7_Click(object sender, EventArgs e)
        {
            Screen[] sc = Screen.AllScreens;
            //get all the screen width and heights 
            f = new Video();
            f.FormBorderStyle = FormBorderStyle.None;
            f.Left = sc[1].Bounds.Width;
            f.Top = sc[1].Bounds.Height;
            f.StartPosition = FormStartPosition.Manual;
            f.Location = sc[1].Bounds.Location;
            Point p = new Point(sc[1].Bounds.Location.X, sc[1].Bounds.Location.Y);
            f.Location = p;
            f.WindowState = FormWindowState.Maximized;
            f.Show();

            //axWindowsMediaPlayer1.URL = Path;
            //axWindowsMediaPlayer1.Ctlcontrols.play();

        }

        private void Oculus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27)
            {
                f.Close();
            }
        }

        private void myButton2_Click_1(object sender, EventArgs e)
        {
            Screen[] sc = Screen.AllScreens;
            //get all the screen width and heights 
            mc = new MotionCamera();
            mc.StartPosition = FormStartPosition.Manual;
            mc.Location = sc[0].Bounds.Location;
            Point p = new Point(sc[0].Bounds.Location.X, sc[0].Bounds.Location.Y);
            mc.Location = p;
            mc.Show();
        }

        private void OpenClosePort_Click(object sender, EventArgs e)
        {
            bool portError = false;
            if (serialComPort.IsOpen) 
                serialComPort.Close();
            else
            {
                serialComPort.PortName = ports.Text;
                serialComPort.BaudRate = int.Parse("9600");
            }
            try
            {
                serialComPort.Open();
            }
            catch (IOException)
            {
                portError = true;
            }
            if (portError)
            {
                MessageBox.Show("Could not open port ");
            }
            else
            {
                serialComPort.Write("X" + '\n');
                ports.Enabled = false;
                OpenClosePort.Enabled = false;
                closePort.Enabled = true;
            }
        }

        private void closePort_Click(object sender, EventArgs e)
        {
            if (serialComPort.IsOpen) serialComPort.Close();
            ports.Enabled = true;
            OpenClosePort.Enabled = true;
            closePort.Enabled = false;
        }

        static void Oculus_movement()
        {
            // Initialize OVR Library
            OVR.Initialize();
            // Create our HMD
            HMD hmd;
            hmd = OVR.HmdCreate(0);

            var renderTargetSize = hmd.GetDefaultRenderTargetSize(1.5f);

            TrackingState ts = hmd.GetTrackingState(0.0);

            SharpOVR.PoseF pose = ts.HeadPose.ThePose;

            float yaw; float eyePitch; float eyeRoll;
            pose.Orientation.GetEulerAngles(out yaw, out eyePitch, out eyeRoll);

            //pose.Orientation.GetEulerAngles(yaw, eyePitch, eyeRoll);

            //double a = ts.HeadPose.ThePose.Orientation.X;
            //double b = ts.HeadPose.ThePose.Orientation.Y;
            //double c = ts.HeadPose.ThePose.Orientation.Z;
            //double d = ts.HeadPose.ThePose.Orientation.W;

            //double kat_x = Math.Atan2(2 * (a * b + c * d), 1 - 2 * (b * b + c * c));


            Pitch = (eyePitch * 180) / Math.PI; //----> su giu 90
            //              |
            //              0
            //              |
            //             -90 

            //double kat_y = Math.Asin(2 * (a * c - d * b));
            Yaw = (yaw * 180) / Math.PI; //----> destra sinistra   90<--->0<--->-90

            //double kat_z = Math.Atan2(2 * (a * d + b * c), 1 - 2 * (c * c + d * d));
            Roll = (eyeRoll * 180) / Math.PI;

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            Oculus_movement();

            int a = Convert.ToInt32(-Pitch);
            int b = Convert.ToInt32(Yaw);

            a += 90;
            b += 90;

            serialComPort.WriteLine("P");
            serialComPort.WriteLine(a.ToString());
            serialComPort.WriteLine("Y");
            serialComPort.WriteLine(b.ToString());
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (serialComPort.IsOpen)
            {
                Oculus_movement();

                int a = Convert.ToInt32(-Pitch);
                int b = Convert.ToInt32(Yaw);

                a += 90;
                b += 90;

                serialComPort.WriteLine("P");
                serialComPort.WriteLine(a.ToString());
                serialComPort.WriteLine("Y");
                serialComPort.WriteLine(b.ToString());
            }
        }
    }
}
