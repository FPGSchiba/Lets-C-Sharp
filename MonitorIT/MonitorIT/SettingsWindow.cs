using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitorIT
{
    public partial class SettingsWindow : Form
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }

        public string remoteName;
        public Socket socket;
        public Settings sett;

        private void SettingsWindow_Shown(object sender, EventArgs e)
        {
            byte[] bytes = new byte[1024];
            remoteName = MainMenu.remoteName;
            this.Text = "Settings - " + remoteName;
            socket = MainMenu.socket;

            int bytesRec = socket.Receive(bytes);
            sett = JsonConvert.DeserializeObject<Settings>(Encoding.UTF8.GetString(bytes, bytesRec, 0));
            
        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }
    }
}
