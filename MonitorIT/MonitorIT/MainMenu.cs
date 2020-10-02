using System;
using System.IO;
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
        public static Socket socket;
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
            socket = new Socket(remoteEP.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            gotLogin = true;
            verified = false;

            if (!Program.sockets.Contains(remoteEP))
            {
                Program.sockets.Add(remoteEP);

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

                            bytesRec = socket.Receive(bytes);

                            if (Encoding.UTF8.GetString(bytes, 0, bytesRec) == "sending Name")
                            {
                                //Get remote Server Name
                                bytesRec = socket.Receive(bytes);
                                remoteName = Encoding.UTF8.GetString(bytes, 0, bytesRec);

                                this.Text = "MainMenu - " + remoteName;

                                while (!verified)
                                {
                                    bytesRec = socket.Receive(bytes);
                                    if (Encoding.UTF8.GetString(bytes, 0, bytesRec) == "need user")
                                    {
                                        //send Username
                                        msg = Encoding.UTF8.GetBytes(username);
                                        bytesSent = socket.Send(msg);

                                        bytesRec = socket.Receive(bytes);
                                        if (Encoding.UTF8.GetString(bytes, 0, bytesRec) == "need pw")
                                        {
                                            //send Hashed Password
                                            msg = Encoding.UTF8.GetBytes(CreateMD5Hash(password));
                                            bytesSent = socket.Send(msg);

                                            //Get the reply from  the server
                                            bytesRec = socket.Receive(bytes);
                                            if (Encoding.UTF8.GetString(bytes, 0, bytesRec) == "connected")
                                            {
                                                //Verified the Login
                                                verified = true;
                                                gotLogin = true;
                                                getOverview();
                                            }
                                            else if (Encoding.UTF8.GetString(bytes, 0, bytesRec) == "wrong")
                                            {
                                                //Login Information wrong
                                                gotLogin = false;
                                                MessageBox.Show("Wrong Username or Password");
                                                Thread thread = new Thread(StartLogin);
                                                thread.Start();
                                            }
                                            else
                                            {
                                                //Somthing unexpected or too many wrong Logins
                                                MessageBox.Show("Too many wrong logins hanging off connection...");
                                                socket.Shutdown(SocketShutdown.Both);
                                                socket.Close();
                                            }
                                            //Wait for other Form to finish
                                            while (!gotLogin)
                                            {
                                                await Task.Delay(25);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            // Release the socket.    
                            socket.Shutdown(SocketShutdown.Both);
                            socket.Close();

                            //Error Message
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
            else
            {
                MessageBox.Show("Es besteht bereits einen Verbindung zu diesem Agent.");
                this.Close();
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
            OV_CUser.Text = "Current User: " + username;

            byte[] bytes = new byte[1024];

            byte[] msg = Encoding.ASCII.GetBytes("get-overview");
            int bytesSent = socket.Send(msg);

            int bytesRec = socket.Receive(bytes);
            string answer = Encoding.UTF8.GetString(bytes, 0, bytesRec);
            if(answer == "sending Overview")
            {
                bytesRec = socket.Receive(bytes);
                string overviewstring = Encoding.UTF8.GetString(bytes, 0, bytesRec);
                string[] overview = overviewstring.Split('|');
                try
                {
                    OV_Crit.Text = "Criticals: " + overview[0];
                    OV_User.Text = "Users: " + overview[1];
                    OV_Stat.Text = "Status: " + overview[2];
                }
                catch
                {
                    MessageBox.Show("Overview could not load correctly");
                }
            }
            else
            {
                MessageBox.Show("No Overview recieved from Server");
            }
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (verified)
            {
                byte[] bytes = new byte[1024];

                byte[] msg = Encoding.ASCII.GetBytes("disconnect");
                int bytesSent = socket.Send(msg);

                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }
        }

        private void open_Dashboard_Click(object sender, EventArgs e)
        {
            byte[] bytes = new byte[1024];
            byte[] msg = Encoding.UTF8.GetBytes("see-dashboard");
            int bytesSent = socket.Send(msg);

            Thread thread = new Thread(startDashboard);

            int bytesRec = socket.Receive(bytes);

            if (Encoding.UTF8.GetString(bytes, 0, bytesRec) == "starting Dashboard")
            {
                thread.Start();
            }
        }

        public void startDashboard()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private void B_Save_Click(object sender, EventArgs e)
        {
            string[] contains = new string[30];

            if (File.Exists(StartMenu.connectedServerConfig))
            {
                contains = File.ReadAllLines(StartMenu.connectedServerConfig);
            }

            using(var writer = File.AppendText(StartMenu.connectedServerConfig))
            {
                if(!contains.Contains(ip + "," + remoteName))
                {
                    writer.WriteLine(ip + "," + remoteName);
                }
                else
                {
                    MessageBox.Show("Connection already saved.");
                }
            }
        }
    }
}
