using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Runtime.InteropServices;

namespace MissionPlanner.GCSViews
{
    public partial class MotionCamera : Form
    {
        public MotionCamera()
        {
            InitializeComponent();
            foreach (string portName in SerialPort.GetPortNames())
            {
                ports.Items.Add(portName);
                enableDisableControlButtons(0);
            }

            if (ports.Items.Count > 0) ports.SelectedIndex = ports.Items.Count - 1;
            serialComPort.DataReceived += new SerialDataReceivedEventHandler(serialComPort_DataReceived);
        }

        SerialPort serialComPort = new SerialPort();

        void serialComPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string dataReceived = serialComPort.ReadExisting();
            string[] words = dataReceived.Split('\n');
            LogData(words);

        }
        private void LogData(string[] msgReceived)
        {
            richTextBox1.Invoke(new EventHandler(delegate
            {
                for (int i = 0; i < msgReceived.Length; ++i)
                {
                    
                    double Num;
                    bool isNum = double.TryParse(msgReceived[i], out Num);
                    if (isNum)
                    {
                        position.Text = msgReceived[i].ToString();
                        richTextBox1.AppendText("Position: "+msgReceived[i]);
                    }
                    else 
                    {
                        richTextBox1.AppendText(msgReceived[i]);
                    }
                }

            }));

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OpenClosePort_Click(object sender, EventArgs e)
        {

        }

        private void closePort_Click(object sender, EventArgs e)
        {
        }

        private void clear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void left_Click(object sender, EventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {
             if (serialComPort.IsOpen)
                 serialComPort.Write("X" + '\n');
        }

        private void right_Click(object sender, EventArgs e)
        {
             if (serialComPort.IsOpen)
                 serialComPort.Write("R" + '\n');
        }

        private void enableDisableControlButtons(int status = 1)
        {
            if (status == 1)
            {
                left.Enabled = true;
                right.Enabled = true;
                reset.Enabled = true;
            }
            else 
            {
                left.Enabled = false;
                right.Enabled = false;
                reset.Enabled = false;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //position.Text = trackBar1.Value.ToString();
            if (trackBar1.Value < 45)
            {
                if (serialComPort.IsOpen)
                    serialComPort.Write("L" + '\n');
            }
            else 
            {
                if (serialComPort.IsOpen)
                    serialComPort.Write("R" + '\n');
            }
        }

        private void OpenClosePort_Click_1(object sender, EventArgs e)
        {
            bool portError = false;
            if (serialComPort.IsOpen) serialComPort.Close();
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
                enableDisableControlButtons(0);
            }
            else
            {
                richTextBox1.AppendText("Serial port opened successfully" + '\n');
                serialComPort.Write("X" + '\n');
                ports.Enabled = false;
                OpenClosePort.Enabled = false;
                closePort.Enabled = true;
                enableDisableControlButtons(1);

            }
        }

        private void ports_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void closePort_Click_1(object sender, EventArgs e)
        {
            if (serialComPort.IsOpen) serialComPort.Close();
            richTextBox1.AppendText("Serial port closed successfully" + '\n');
            ports.Enabled = true;
            OpenClosePort.Enabled = true;
            closePort.Enabled = false;
            enableDisableControlButtons(0);
        }

        private void left_Click_1(object sender, EventArgs e)
        {
            if (serialComPort.IsOpen)
                serialComPort.Write("L" + '\n');
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}
