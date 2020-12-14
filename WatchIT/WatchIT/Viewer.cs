using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatchIT
{
    public partial class Viewer : Form
    {
        public Viewer()
        {
            InitializeComponent();
        }

        private void Viewer_Load(object sender, EventArgs e)
        {
            string Invitation = "";
            Application.OpenForms["Connect"].Invoke(new Action(() => { Invitation = (Application.OpenForms["Connect"] as Connect).Invitation; }));
            axRDPViewer1.Connect(Invitation, "User-" + Environment.MachineName.ToString(), " &5CQUe$#GT%9qr4Su6cE$FFA+A!-UD");
            axRDPViewer1.SmartSizing = true;
            axRDPViewer1.ShowPropertyPages();
        }

        private void axRDPViewer1_OnAttendeeDisconnected(object sender, AxRDPCOMAPILib._IRDPSessionEvents_OnAttendeeDisconnectedEvent e)
        {
            this.Close();
        }

        private void Viewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            axRDPViewer1.Disconnect();
        }

        private void axRDPViewer1_ClientSizeChanged(object sender, EventArgs e)
        {
            this.Size = axRDPViewer1.ClientSize;
        }
    }
}
