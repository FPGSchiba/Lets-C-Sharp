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

        public static string ip = "127.0.0.1";
        public IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse(ip), 5050);
        public Socket socket = new Socket(IPAddress.Parse("127.0.0.1").AddressFamily, SocketType.Stream, ProtocolType.Tcp);
        public string VerisonString = "Version: 1.0";

        private static bool verified = false;

        public void StartClient()
        {
            byte[] bytes = new byte[1024];

            try
            {
                // Connect the socket to the remote endpoint. Catch any errors.    
                try
                {
                    // Connect to Remote EndPoint  
                    socket.Connect(remoteEP);

                    // Receive the response from the remote device.    
                    int bytesRec = socket.Receive(bytes);
                    if (Encoding.ASCII.GetString(bytes, 0, bytesRec) == VerisonString)
                    {
                        //send the VersionString for security
                        byte[] msg = Encoding.ASCII.GetBytes(VerisonString);
                        int bytesSent = socket.Send(msg);
                        verified = true;
                    }
                    else
                    {
                        // Release the socket.    
                        socket.Shutdown(SocketShutdown.Both);
                        socket.Close();

                        MessageBox.Show("A other Version is on the Server, then on the Client. Please contact you Administrator.");
                        Environment.Exit(1);
                    }
                }
                catch (ArgumentNullException ane)
                {
                    MessageBox.Show("ArgumentNullException : " + ane.Message);
                    Environment.Exit(1);
                }
                catch (SocketException se)
                {
                    MessageBox.Show("SocketException : " + se.Message);
                    Environment.Exit(1);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Unexpected exception : "+ e.Message);
                    Environment.Exit(1);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Environment.Exit(1);
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            StartClient();
            fill_CPU();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            fill_CPU();
        }

        private void fill_CPU()
        {
            if (verified)
            {
                byte[] msg = Encoding.ASCII.GetBytes("GetCPU");
                byte[] rec = new byte[1024];

                int byteSent = socket.Send(msg);
                int byteRec = socket.Receive(rec);

                cr_CPU.Series["CPU Percent"].Points.AddXY(DateTime.Now.ToString("h:mm:ss"), Encoding.ASCII.GetString(rec, 0, byteRec));
                if (cr_CPU.Series["CPU Percent"].Points.Count() >= 10)
                {
                    cr_CPU.Series["CPU Percent"].Points.RemoveAt(0);
                    cr_CPU.ResetAutoValues();
                }
            }
        }
    }
}
