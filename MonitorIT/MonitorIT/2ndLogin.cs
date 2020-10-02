using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitorIT
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void B_SeleLogin_Click(object sender, EventArgs e)
        {
            MainMenu.password = tB_SelePW.Text;
            MainMenu.username = tB_SeleUser.Text;
            MainMenu.gotLogin = true;
            this.Close();
        }
    }
}
