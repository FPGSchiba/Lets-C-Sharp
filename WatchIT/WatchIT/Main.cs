using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WatchIT
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connect conn = new Connect();
            conn.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Host host = new Host();
            host.Show();
        }

        private void checkRegistry()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Terminal Server\WinStations");

            if (key != null)
            {
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Terminal Server\WinStations", "DWMFRAMEINTERVAL", 60);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            checkRegistry();
        }
    }
}
