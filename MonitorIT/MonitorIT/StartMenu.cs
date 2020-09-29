using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MonitorIT
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
        }

        public static string connectedServerConfig = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\MIT\Conn_Server.txt";
        public bool saved_login = false;
        static string ip;
        static string username;
        static string password;

        private void StartMenu_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(Program.AppDataPath))
            {
                Directory.CreateDirectory(Program.AppDataPath);
            }

            listView1.Columns.Insert(0, "IP-Adress");
            listView1.Columns.Insert(1, "Server-Name");

            // Lade die IPs und Server namen und evt saved user + pw in die liste
            if (File.Exists(connectedServerConfig))
            {
                saved_login = true;
                using (var reader = new StreamReader(@"C:\test.csv"))
                {
                    List<string> listIP = new List<string>();
                    List<string> listName = new List<string>();
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        listIP.Add(values[0]);
                        listName.Add(values[1]);
                    }

                    foreach(string i in listIP)
                    {
                        listView1.Columns.Add("IP-Adress", i);
                    }
                    foreach(string i in listName)
                    {
                        listView1.Columns.Add("Server-Name", i);
                    }
                }
            }
        }

        private void B_SeleLogin_Click(object sender, EventArgs e)
        {
            if (saved_login)
            {

            }
            else
            {
                MessageBox.Show("No saved logins please try to use a Diffrent Server");
            }
        }

        private void B_DiffLogin_Click(object sender, EventArgs e)
        {
            ip = tB_ServerIP.Text;
            username = tB_DiffUser.Text;
            password = tB_DiffPW.Text;

            try
            {
                IPAddress.Parse(ip);
                Thread MainMenu = new Thread(startMainMenu);
                MainMenu.Start();
                tB_ServerIP.Text = "";
                tB_DiffUser.Text = "";
                tB_DiffPW.Text = "";
            }
            catch
            {
                MessageBox.Show("IP Adress is not Valid");
            }
        }

        public void startMainMenu()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }

        public static string getIP()
        {
            return ip;
        }

        public static string getUser()
        {
            return username;
        }

        public static string getPW()
        {
            return password;
        }
    }
}