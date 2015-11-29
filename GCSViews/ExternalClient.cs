using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace MissionPlanner.GCSViews
{
    public partial class ExternalClient : Form
    {

        string IP_Address;
        int Port;
        string Message;
        TcpClient tcpclnt;
        private static System.Timers.Timer clock;

        public ExternalClient()
        {
            InitializeComponent();
        }

        private void ExternalClient_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            IP_Address = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string prov = textBox4.Text;
            Port = Convert.ToInt32(prov);
        }

        private void myButton1_Click(object sender, EventArgs e)
        {
            Client_funz();
            Send_Data();
        }

        public void Send_Data()
        {
            clock = new System.Timers.Timer();
            clock.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            // Set the Interval to 5 seconds.
            clock.Interval = 5000;
            clock.Enabled = true;
        }

        public void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            Message = "Data";

            string a, b, c, d;
            a = MainV2.comPort.MAV.cs.wind_vel.ToString();
            b = MainV2.comPort.MAV.cs.yaw.ToString();
            c = MainV2.comPort.MAV.cs.battery_voltage.ToString();
            d = MainV2.comPort.MAV.cs.alt.ToString();

            Message = Message + ";" + a + ";" + b + ";" + c + ";" + d;

            String str = Message;
            Stream stm = tcpclnt.GetStream();

            ASCIIEncoding asen = new ASCIIEncoding();
            byte[] ba = asen.GetBytes(str);

            stm.Write(ba, 0, ba.Length);

            Byte[] bb = new byte[100];
            stm.Read(bb, 0, bb.Length);
        }



        private void Disconnect_Click(object sender, EventArgs e)
        {
            tcpclnt.Close();
        }

        private void myButton2_Click(object sender, EventArgs e)
        {
            Message = textBox2.Text;
            String str = Message;
            Stream stm = tcpclnt.GetStream();

            ASCIIEncoding asen = new ASCIIEncoding();
            byte[] ba = asen.GetBytes(str);
            textBox1.Text = "Transmitting.....";

            stm.Write(ba, 0, ba.Length);

            Byte[] bb = new byte[100];
            stm.Read(bb, 0, bb.Length);

            textBox1.Text = System.Text.Encoding.ASCII.GetString(bb, 0, bb.Length);
        }

        public void Client_funz()
        {

            try
            {
                tcpclnt = new TcpClient();
                textBox1.Text = "Connecting...";

                tcpclnt.Connect(IP_Address, Port);
                // use the ipaddress as in the server program

                textBox1.Text = "Connected";
                textBox1.Text = "Enter the string to be transmitted ";

            }

            catch (Exception e)
            {
                textBox1.Text = "Error..... " + e.StackTrace;
            }
        }

    }
}
