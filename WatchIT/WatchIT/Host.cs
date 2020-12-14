using RDPCOMAPILib;
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
    public partial class Host : Form
    {
        public RDPSession x;

        public Host()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            x = new RDPSession();
            x.OnAttendeeConnected += Incoming;
            x.Open();

            x.OnAttendeeDisconnected += Disconnect;

            IRDPSRAPIInvitation Invitation = x.Invitations.CreateInvitation("Trial", "FPG Army", " &5CQUe$#GT%9qr4Su6cE$FFA+A!-UD", 10);
            textBox1.Text = Invitation.ConnectionString;
        }

        private void Incoming(object Guest)
        {
            IRDPSRAPIAttendee MyGuest = (IRDPSRAPIAttendee)Guest;
            MyGuest.ControlLevel = CTRL_LEVEL.CTRL_LEVEL_VIEW;
            this.Visible = false;
        }

        private void Disconnect(object Guest)
        {
            this.Visible = true;
        }
    }
}
