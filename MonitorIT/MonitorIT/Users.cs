using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Web.Helpers;
using Newtonsoft.Json;

namespace MonitorIT
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        public string remoteName;
        public Socket socket;
        public List<User> UserList = new List<User>();
        public int userCount;

        private void Users_Load(object sender, EventArgs e)
        {
            byte[] bytes = new byte[1024];
            remoteName = MainMenu.remoteName;
            this.Text = "Users - " + remoteName;
            socket = MainMenu.socket;

            int bytesRec = socket.Receive(bytes);
            string json = Encoding.UTF8.GetString(bytes, 0, bytesRec);

            dynamic data = Json.Decode(json);
            userCount = data["users"];

            for (int i = 0; i <= userCount - 1; i++)
            {
                var temp = data[i.ToString()];
                MessageBox.Show(JsonConvert.SerializeObject(temp));
                UserList.Add(JsonConvert.DeserializeObject<User>(JsonConvert.SerializeObject(temp)));
            }

            for (int i = 0; i <= userCount - 1; i++)
            {
                lV_Users.Items.Add(UserList[i].username);
            }
        }

        private void B_Create_Click(object sender, EventArgs e)
        {
            B_Save.Visible = true;
        }

        private void B_Delete_Click(object sender, EventArgs e)
        {
            B_Save.Visible = true;
        }

        private void B_Edit_Click(object sender, EventArgs e)
        {
            B_Save.Visible = true;
        }
    }
}
