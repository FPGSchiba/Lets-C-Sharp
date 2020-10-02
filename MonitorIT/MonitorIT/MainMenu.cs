using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitorIT
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        public static string ip;
        public static string username;
        public static string password;
        public IPEndPoint remoteEP;
        public Socket socket = new Socket(IPAddress.Parse("127.0.0.1").AddressFamily, SocketType.Stream, ProtocolType.Tcp);
        public string VerisonString = "Version: 1.1";
        public static bool verified;
        public static string remoteName;
        public static bool gotLogin;

        [Obsolete]
        private async void MainMenu_Load(object sender, EventArgs e)
        {
            ip = StartMenu.getIP();
            username = StartMenu.getUser();
            password = StartMenu.getPW();
            remoteEP = new IPEndPoint(IPAddress.Parse(ip), 5050);
            gotLogin = true;
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
                        
                        //Get remote Server Name
                        bytesRec = socket.Receive(bytes);
                        remoteName = Encoding.UTF8.GetString(bytes, 0, bytesRec);
                        this.Text = "MainMenu - " + remoteName;

                        while (!verified)
                        {
                            //send Username
                            msg = Encoding.UTF8.GetBytes(username);
                            bytesSent = socket.Send(msg);

                            //send Hashed Password
                            msg = Encoding.UTF8.GetBytes(CreateMD5Hash(password));
                            bytesSent = socket.Send(msg);

                            //Get the reply from  the server
                            bytesRec = socket.Receive(bytes);
                            if (Encoding.UTF8.GetString(bytes, 0, bytesRec) == "connected")
                            {
                                verified = true;
                                getOverview();
                            }
                            else if (Encoding.UTF8.GetString(bytes, 0, bytesRec) == "wrong")
                            {
                                gotLogin = false;
                                MessageBox.Show("Wrong Username or Password");
                                Thread thread = new Thread(StartLogin);
                                thread.Start();
                            }
                            else
                            {
                                MessageBox.Show("Too many wrong logins hanging off connection...");
                                socket.Shutdown(SocketShutdown.Both);
                                socket.Close();
                            }
                            while (!gotLogin)
                            {
                                await Task.Delay(25);
                            }
                        }
                    }
                    else
                    {
                        // Release the socket.    
                        socket.Shutdown(SocketShutdown.Both);
                        socket.Close();

                        MessageBox.Show("A other Version is on the Server, then on the Client. Please contact you Administrator.");
                        ActiveForm.Close();
                    }
                }
                catch (ArgumentNullException ane)
                {
                    MessageBox.Show("ArgumentNullException : " + ane.Message);
                    ActiveForm.Close();
                }
                catch (SocketException se)
                {
                    MessageBox.Show("SocketException : " + se.Message);
                    ActiveForm.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected exception : " + ex.Message);
                    ActiveForm.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (ActiveForm.IsAccessible)
                {
                    ActiveForm.Close();
                }
            }
        }

        public static void StartLogin()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }

        public static string CreateMD5Hash(string input)
        {
            // Step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            // Step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("x2"));
            }
            return sb.ToString();
        }

        public void getOverview()
        {
            OV_CUser.Text = username;

            byte[] bytes = new byte[1024];

            byte[] msg = Encoding.ASCII.GetBytes("get-overview");
            int bytesSent = socket.Send(msg);

            int bytesRec = socket.Receive(bytes);
            string overviewstring = Encoding.UTF8.GetString(bytes, 0, bytesRec);
            string[] overview = overviewstring.Split('|');
            try
            {
                OV_Crit.Text = "Criticals: " + overview[0];
                OV_CUser.Text = "Users: " + overview[1];
                OV_Stat.Text = "Status: " + overview[2];
            }
            catch
            {
                MessageBox.Show("Overview could not load correctly");
            }
        }
    }
}
