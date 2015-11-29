using System;
using System.Collections.Generic;
using System.Collections;
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
using System.Globalization;


namespace MissionPlanner.GCSViews
{
    public partial class UserControl1 :  MyUserControl, IActivate
    {
        private TcpListener tcpServer;
        private TcpClient tcpClient;
        private Thread th;
        private ChatDialog ctd;
        public ArrayList formArray = new ArrayList();
        private ArrayList threadArray = new ArrayList();
        public delegate void ChangedEventHandler(object sender, EventArgs e);
        public event ChangedEventHandler Changed;
        public delegate void SetListBoxItem(String str, String type); 
        ChatDialog[] Client;
        int Num_client=0;
        bool avvia = false;
        int index = 0;
        public delegate void SetTextCallback(List<string> List_data, bool normal_msg);
        string MSG = "";

        public TcpClient connectedClient
        {
            get { return tcpClient; }
            set { tcpClient = value; }

        }

        public void Activate()
        {
        }

        public UserControl1()
        {
            InitializeComponent();
            // Add Event to handle when a client is connected
            Changed += new ChangedEventHandler(ClientAdded);

            // Add node in Tree View
            TreeNode node;
            node = tvClientList.Nodes.Add("Connected Clients");
            ImageList il = new ImageList();
            //   il.Images.Add(new Icon("audio.ico"));
            // il.Images.Add(new Icon("messenger.ico"));
            tvClientList.ImageList = il;
            node.ImageIndex = 1;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Gvspeed_ValueInRangeChanged(object sender, AGaugeApp.AGauge.ValueInRangeChangedEventArgs e)
        {

        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            (formArray[Num_client] as ChatDialog).btnSend(txtMessage.Text);
            rtbChat.SelectionColor = Color.IndianRed;
            rtbChat.SelectedText = "\nMe:     " + txtMessage.Text;
            txtMessage.Text = ""; 
        }

     /*   private void UserControl1_VisibleChanged(object sender, EventArgs e)
        {
            base.OnVisibleChanged(e);

            if (Disposing == false)
            {
                if (Visible == true)
                {
                    IPHostEntry host;
                    string localIP = "";
                    host = Dns.GetHostEntry(Dns.GetHostName());
                    foreach (IPAddress ip in host.AddressList)
                    {
                        if (ip.AddressFamily == AddressFamily.InterNetwork)
                        {
                            localIP = ip.ToString();
                            break;
                        }
                    }
                    textBox3.Text = localIP;
                }
            }
        }*/

        #region Server Start/Stop

        /// <summary>
        /// This function spawns new thread for TCP communication
        /// </summary>
        public void StartServer()
        {
            tbPortNumber.Enabled = false;
            th = new Thread(new ThreadStart(StartListen));
            th.Start();

        }

        /// <summary>
        /// Server listens on the given port and accepts the connection from Client.
        /// As soon as the connection id made a dialog box opens up for Chatting.
        /// </summary>
        public void StartListen()
        {

            IPAddress localAddr = IPAddress.Parse("127.0.0.1");

            tcpServer = new TcpListener(localAddr, Int32.Parse(tbPortNumber.Text));
            tcpServer.Start();

            // Keep on accepting Client Connection
            while (true)
            {

                // New Client connected, call Event to handle it.
                Thread t = new Thread(new ParameterizedThreadStart(NewClient));
                tcpClient = tcpServer.AcceptTcpClient();
                t.Start(tcpClient);

            }

        }

        /// <summary>
        /// Function to stop the TCP communication. It kills the thread and closes client connection
        /// </summary>
        public void StopServer()
        {

            if (tcpServer != null)
            {

                // Close all Socket connection
                foreach (ChatDialog c in formArray)
                {
                    c.connectedClient.Client.Close();
                }

                // Abort All Running Threads
                foreach (Thread t in threadArray)
                {
                    t.Abort();
                }

                // Clear all ArrayList
                threadArray.Clear();
                formArray.Clear();
                tvClientList.Nodes[0].Nodes.Clear();

                // Abort Listening Thread and Stop listening
                th.Abort();
                tcpServer.Stop();
            }
            tbPortNumber.Enabled = true;
        }


        /// <summary>
        /// Fuction checks whether to start or stop the server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ckbServerControl_CheckedChanged(object sender, EventArgs e)
        {


            if (avvia == true)
            {
                // validate the port number
                try
                {
                    int port;
                    port = Int32.Parse(tbPortNumber.Text);

                    StartServer();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please enter the correct port number!!!");
                    avvia = false;
                }
            }

            else
            {
                StopServer();
            }
        }

        #endregion

        #region Add/remove Clients
        /// <summary>
        /// 
        /// </summary>
        public void NewClient(Object obj)
        {
            ClientAdded(this, new MyEventArgs((TcpClient)obj));
        }

        /// <summary>
        /// Event Fired when a Client gets connected. Following actions are performed
        /// 1. Update Tree view
        /// 2. Open a chat box to chat with client.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ClientAdded(object sender, EventArgs e)
        {
            tcpClient = ((MyEventArgs)e).clientSock;
            String remoteIP = ((IPEndPoint)tcpClient.Client.RemoteEndPoint).Address.ToString();
            String remotePort = ((IPEndPoint)tcpClient.Client.RemoteEndPoint).Port.ToString();

            // Call Delegate Function to update Tree View
            UpdateClientList(remoteIP + " : " + remotePort, "Add");

            // Show Dialog Box for Chatting
            ctd = new ChatDialog(tcpClient);
            //ctd.Text = "Connected to " + remoteIP + "on port number " + remotePort;

            // Add Dialog Box Object to Array List
            formArray.Add(ctd);
            mavlinkNumericUpDown1.Maximum = formArray.Count-1;
            Send_Data();
            index++;
            threadArray.Add(Thread.CurrentThread);
        }


        /// <summary>
        /// Delegate Function to update List box.
        /// If type parameter is "Add", then client information is added in Tree View
        /// else the entry is delete from Tree View.
        /// </summary>
        /// <param name="str"></param>
        private void UpdateClientList(string str, string type)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.tvClientList.InvokeRequired)
            {
                SetListBoxItem d = new SetListBoxItem(UpdateClientList);
                this.Invoke(d, new object[] { str, type });
            }
            else
            {
                // If type is Add, the add Client info in Tree View
                if (type.Equals("Add"))
                {
                    this.tvClientList.Nodes[0].Nodes.Add(str);
                }
                // Else delete Client information from Tree View
                else
                {
                    foreach (TreeNode n in this.tvClientList.Nodes[0].Nodes)
                    {
                        if (n.Text.Equals(str))
                            this.tvClientList.Nodes.Remove(n);
                    }
                }

            }
        }

        /// <summary>
        /// Event called when Tree View Client list is double clicked. 
        /// When a node is double clicked, corresponding chat Dialog box is made visible.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        public void DisconnectClient(String remoteIP, String remotePort)
        {
            // Delete Client from Tree View
            UpdateClientList(remoteIP + " : " + remotePort, "Delete");

            // Find Client Chat Dialog box corresponding to this Socket
            int counter = 0;
            foreach (ChatDialog c in formArray)
            {
                String remoteIP1 = ((IPEndPoint)c.connectedClient.Client.RemoteEndPoint).Address.ToString();
                String remotePort1 = ((IPEndPoint)c.connectedClient.Client.RemoteEndPoint).Port.ToString();

                if (remoteIP1.Equals(remoteIP) && remotePort1.Equals(remotePort))
                {
                    break;
                }
                counter++;

            }

            // Terminate Chat Dialog Box
            ChatDialog cd = (ChatDialog)formArray[counter];
            formArray.RemoveAt(counter);
            mavlinkNumericUpDown1.Maximum = formArray.Count-1;

            ((Thread)(threadArray[counter])).Abort();
            threadArray.RemoveAt(counter);

        }
        #endregion



        private void myButton1_Click(object sender, EventArgs e)
        {
            StateObject state = new StateObject();

            if (myButton1.Text == "START")
            {
                if (avvia == false) avvia = true;
                else avvia = false;

                if (avvia == true)
                {
                    // validate the port number
                    try
                    {
                        int port;
                        port = Int32.Parse(tbPortNumber.Text);
                        StartServer();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Please enter the correct port number!!!");
                        avvia = false;
                    }

                }

                else
                {
                    StopServer();
                }
            }
            else
            {
                StopServer();
            }

            if (myButton1.Text == "START")
                myButton1.Text = "STOP";
            else
                myButton1.Text = "START";

        }

        private void mavlinkNumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Num_client = Convert.ToInt32(mavlinkNumericUpDown1.Value);
        }

        public void Send_Data()
        {
            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            // Set the Interval to 1 seconds.
            aTimer.Interval = 3000;
            aTimer.Enabled = true;
        }


        public void OnTimedEvent(object source, ElapsedEventArgs e)
        {            
            List<string> Data_telem = new List<string>();
            if (!(formArray[Num_client] as ChatDialog).Normal_message)
            {
                if (this.richTextBox1.InvokeRequired)
                {
                    SetTextCallback d = new SetTextCallback(ChangeTextbox);
                    this.Invoke(d, new object[] { 
                        (formArray[Num_client] as ChatDialog).Telemetry_Data,
                        false
                });
                }
                else
                {
                    this.richTextBox1.SelectionColor = Color.Blue;
                    this.richTextBox1.SelectedText = "\nFriend: " + "error";
                }
            }
            else
            {
                if (this.richTextBox1.InvokeRequired)
                {
                    SetTextCallback d = new SetTextCallback(ChangeTextbox);
                    this.Invoke(d, new object[] { 
                        (formArray[Num_client] as ChatDialog).Telemetry_Data,
                        true
                });
                }
                else
                {
                    this.rtbChat.SelectionColor = Color.Blue;
                    this.rtbChat.SelectedText = "\nFriend: " + "error";
                }
            }

        }

        public void ChangeTextbox(List<string> ctd_test, bool normal_msg)
        {
            if (ctd_test.Count == 0)
                return;

            if (!normal_msg)
            {
                    richTextBox1.Clear();
                    richTextBox1.Text = ctd_test[0];
                    quickView1.number = Convert.ToDouble(ctd_test[0]);
                    aGauge2.Value0 = float.Parse(ctd_test[0], CultureInfo.InvariantCulture.NumberFormat);
                    
                    richTextBox2.Clear();
                    richTextBox2.Text = ctd_test[1];
                    quickView2.number = Convert.ToDouble(ctd_test[1]);
                    Gspeed.Value0 = (float)Convert.ToDouble(ctd_test[1]);
                    Gspeed.Value1 = (float)Convert.ToDouble(ctd_test[1]);
                                                
                    richTextBox3.Clear();       
                    richTextBox3.Text = ctd_test[2];
                    quickView3.number = (float)Convert.ToDouble(ctd_test[2]);
                    aGauge2.Value0 = (float)Convert.ToDouble(ctd_test[2]);
                                                
                    richTextBox4.Clear();       
                    richTextBox4.Text = ctd_test[3];
                    quickView4.number = (float)Convert.ToDouble(ctd_test[3]);
                    Galt.Value0 = (float)Convert.ToDouble(ctd_test[3]);
                    
            }
            else
            {
                if (!(formArray[Num_client] as ChatDialog).read)
                {
                    (formArray[Num_client] as ChatDialog).read = true;
                    rtbChat.SelectionColor = Color.AliceBlue;
                    rtbChat.SelectedText = "\nPilot " + mavlinkNumericUpDown1.Value.ToString() + ":     " + ctd_test[0];
                }
            }
        }                               


        private void mavlinkNumericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {

            Num_client = Convert.ToInt32(mavlinkNumericUpDown1.Value);
            rtbChat.Clear();
            Send_Data();
        }

        private void tvClientList_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void mavlinkNumericUpDown1_Click(object sender, EventArgs e)
        {
        }

        private void quickView1_Load(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void myButton2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
