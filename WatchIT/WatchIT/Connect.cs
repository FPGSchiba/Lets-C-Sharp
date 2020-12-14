using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatchIT
{
    public partial class Connect : Form
    {
        public string Invitation;

        public Connect()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Invitation = textBox1.Text;
            MessageBox.Show(Invitation);
            Thread t = new Thread(openViewer);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void openViewer()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Viewer());
        }
    }
}
