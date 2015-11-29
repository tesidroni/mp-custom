using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading; 

namespace MissionPlanner
{
    class ChatDialog
    {
        
        private TcpClient client;
        private NetworkStream clientStream;
        public delegate void SetTextCallback(string s);
        public string Message = "";
        public List<string> Telemetry_Data = new List<string>();
        public Boolean Normal_message = false, read=false;
        public int num_data = 0;

        public TcpClient connectedClient {
            get { return client; }
            set { client = value; }

        }

        #region Constructors

        /// <summary>
        /// Constructor which accepts Client TCP object
        /// </summary>
        /// <param name="tcpClient"></param>
        /// 
        public ChatDialog(TcpClient tcpClient)
        {
            // Get Stream Object
            connectedClient = tcpClient;
            clientStream = tcpClient.GetStream();

            // Create the state object.
            StateObject state = new StateObject();
            state.workSocket = connectedClient.Client;

            //Call Asynchronous Receive Function
            connectedClient.Client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                    new AsyncCallback(OnReceive), state);
        }

        #endregion
        

        /// <summary>
        /// This function is used to display data in Rich Text Box
        /// </summary>
        /// <param name="text"></param>
        public void SetText(string text)
        {
            Message = text;
            char[] delimiterChars = { ';' };

            string[] words = text.Split(delimiterChars);
            System.Console.WriteLine("{0} words in text:", words.Length);
            int counter = 0;

            Telemetry_Data.Clear();

            foreach (string s in words)
            {
                if (s != "Data" && counter == 0) 
                {
                    Normal_message = true;
                    read = false;
                    Telemetry_Data.Add(Message);
                    break;
                }
                else
                    Normal_message = false;

                counter++;
                if (counter == 2) Telemetry_Data.Add(s);
                else if (counter == 3) Telemetry_Data.Add(s);
                else if (counter == 4) Telemetry_Data.Add(s);
                else if (counter == 5) Telemetry_Data.Add(s);

            }
        }

        #region Send/Receive Data From Scokets

        /// <summary>
        /// Asynchronous Callback function which receives data from Server
        /// </summary>
        /// <param name="ar"></param>
        public void OnReceive(IAsyncResult ar)
        {
            String content = String.Empty;

            // Retrieve the state object and the handler socket
            // from the asynchronous state object.
            StateObject state = (StateObject)ar.AsyncState;
            Socket handler = state.workSocket;
            int bytesRead;

            if (handler.Connected)
            {

                // Read data from the client socket. 
                try
                {
                    bytesRead = handler.EndReceive(ar);
                    if (bytesRead > 0)
                    {
                        // There  might be more data, so store the data received so far.
                        state.sb.Remove(0, state.sb.Length);
                        state.sb.Append(Encoding.ASCII.GetString(
                                         state.buffer, 0, bytesRead));

                        // Display Text in Rich Text Box
                        content = state.sb.ToString();

                        SetText(content);                      

                        handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                            new AsyncCallback(OnReceive), state);

                    }
                }

                catch (SocketException socketException)
                {
                    //WSAECONNRESET, the other side closed impolitely
                    if (socketException.ErrorCode == 10054 || ((socketException.ErrorCode != 10004) && (socketException.ErrorCode != 10053)))
                    {
                        // Complete the disconnect request.
                        String remoteIP = ((IPEndPoint)handler.RemoteEndPoint).Address.ToString();
                        String remotePort = ((IPEndPoint)handler.RemoteEndPoint).Port.ToString();
                       // this.owner.DisconnectClient(remoteIP, remotePort);

                        handler.Close();
                        handler = null;

                    }
                }

                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message + "\n" + exception.StackTrace);
                    
                }
            }
        }

        #endregion

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rtbChat_TextChanged(object sender, EventArgs e)
        {

        }

        public void btnSend(String message)
        {
            byte[] bt;
            bt = Encoding.ASCII.GetBytes(message);
            connectedClient.Client.Send(bt);
        }
    }


    #region StateObject Class Definition
    /// <summary>
    /// StateObject Class to read data from Client
    /// </summary>
    public class StateObject
    {
        // Client  socket.
        public Socket workSocket = null;
        // Size of receive buffer.
        public const int BufferSize = 1024;
        // Receive buffer.
        public byte[] buffer = new byte[BufferSize];
        // Received data string.
        public StringBuilder sb = new StringBuilder();
    }
    #endregion

    
}
