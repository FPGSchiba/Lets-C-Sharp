using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitorIT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
        private static IPEndPoint remoteEP = new IPEndPoint(ipAddress, 5050);
        private static Socket sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
        private static string VerisonString = "Version: 1.0";

        private static bool verified = false;

        public static void StartClient()
        {
            byte[] bytes = new byte[1024];

            try
            {
                // Connect the socket to the remote endpoint. Catch any errors.    
                try
                {
                    // Connect to Remote EndPoint  
                    sender.Connect(remoteEP);

                    // Receive the response from the remote device.    
                    int bytesRec = sender.Receive(bytes);
                    if (Encoding.ASCII.GetString(bytes, 0, bytesRec) == VerisonString)
                    {
                        //send the VersionString for security
                        byte[] msg = Encoding.ASCII.GetBytes(VerisonString);
                        int bytesSent = sender.Send(msg);
                        verified = true;
                    }
                    else
                    {
                        // Release the socket.    
                        sender.Shutdown(SocketShutdown.Both);
                        sender.Close();

                        MessageBox.Show("A other Version is on the Server, then on the Client. Please contact you Administrator.");
                        Environment.Exit(1);
                    }
                }
                catch (ArgumentNullException ane)
                {
                    MessageBox.Show("ArgumentNullException : " + ane.Message);
                }
                catch (SocketException se)
                {
                    MessageBox.Show("SocketException : " + se.Message);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Unexpected exception : "+ e.Message);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            StartClient();
        }
    }
}
