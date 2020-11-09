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
using System.Web.Script.Serialization;
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
        public Settings sett = new Settings();
        public bool changed;

        private void SettingsWindow_Shown(object sender, EventArgs e)
        {
            byte[] bytes = new byte[1024];
            remoteName = MainMenu.remoteName;
            this.Text = "Settings - " + remoteName;
            socket = MainMenu.socket;

            byte[] msg = Encoding.UTF8.GetBytes("send Settings");
            socket.Send(msg);

            int bytesRec = socket.Receive(bytes);
            string json = Encoding.UTF8.GetString(bytes, 0, bytesRec);
            sett = JsonConvert.DeserializeObject<Settings>(json);

            if(sett != null)
            {
                //Overview
                tB_Overview_GMi.Text = sett.Overview.Status.Good.GoodMin.ToString();
                tB_Overview_GMa.Text = sett.Overview.Status.Good.GoodMax.ToString();
                tB_Overview_OMi.Text = sett.Overview.Status.Ok.OkMin.ToString();
                tB_Overview_OMa.Text = sett.Overview.Status.Ok.OkMax.ToString();
                tB_Overview_LMi.Text = sett.Overview.Status.Less.LessMin.ToString();
                tB_Overview_LMa.Text = sett.Overview.Status.Less.LessMax.ToString();
                tB_Overview_BMi.Text = sett.Overview.Status.Bad.BadMin.ToString();
                tB_Overview_BMa.Text = sett.Overview.Status.Bad.BadMax.ToString();

                //Connection
                tB_Connection_Tries.Text = sett.Connection.Tries.ToString();

                //Warning
                tB_Warn_CPU.Text = sett.Warning.CpuMax.ToString();
                tB_Warn_GPU.Text = sett.Warning.GpuMax.ToString();
                tB_Warn_MEM.Text = sett.Warning.MemMax.ToString();
                tB_Warn_DPC.Text = sett.Warning.DpcMax.ToString();
                tB_Warn_DFR.Text = sett.Warning.DfrMax.ToString();

                //Mail

                //Server
                tB_Mail_ServerName.Text = sett.Mail.Sending.Server.Name;
                tB_Mail_ServerPort.Text = sett.Mail.Sending.Server.Port.ToString();

                //Sender
                tB_Mail_SenderMail.Text = sett.Mail.Sending.SenderMail;
                tB_Mail_SenderPassword.Text = sett.Mail.Sending.Password;

                //Info
                tB_Mail_Subject.Text = sett.Mail.Sending.Subject;
                rtB_Mail_AdditionalInfo.Text = sett.Mail.Sending.Additional;

                //Maillist
                foreach (string i in sett.Mail.ToMail)
                {
                    lB_Mail_Mails.Items.Add(i);
                }
            }
            else
            {
                MessageBox.Show(json);
            }

            B_Save.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] bytes = new byte[1024];
            byte[] msg = Encoding.UTF8.GetBytes("set-settings");
            socket.Send(msg);

            int bytesRecs = socket.Receive(bytes);
            if(Encoding.UTF8.GetString(bytes, 0, bytesRecs) == "get Settings" && loadSettings())
            {
                if (sett != null)
                {
                    socket.Send(msg);
                    msg = Encoding.UTF8.GetBytes(new JavaScriptSerializer().Serialize(sett));
                    socket.Send(msg);
                }
                else
                {
                    msg = Encoding.UTF8.GetBytes("abort");
                    socket.Send(msg);
                }
            }
            else if(Encoding.UTF8.GetString(bytes, 0, bytesRecs) == "no Permission")
            {
                MessageBox.Show("Not enough rights to full fill this action.");
            }
            else
            {
                MessageBox.Show("Could not safe Settings");
            }
        }

        private new void TextChanged(object sender, EventArgs e)
        {
            B_Save.Visible = true;
        }

        private bool loadSettings()
        {
            //Overview
            try
            {
                sett.Overview.Status.Good.GoodMin = Convert.ToInt32(tB_Overview_GMi.Text);
                sett.Overview.Status.Good.GoodMax = Convert.ToInt32(tB_Overview_GMa.Text);
                sett.Overview.Status.Ok.OkMin = Convert.ToInt32(tB_Overview_OMi.Text);
                sett.Overview.Status.Ok.OkMax = Convert.ToInt32(tB_Overview_OMa.Text);
                sett.Overview.Status.Less.LessMin = Convert.ToInt32(tB_Overview_LMi.Text);
                sett.Overview.Status.Less.LessMax = Convert.ToInt32(tB_Overview_LMa.Text);
                sett.Overview.Status.Bad.BadMin = Convert.ToInt32(tB_Overview_BMi.Text);
                sett.Overview.Status.Bad.BadMax = Convert.ToInt32(tB_Overview_BMa.Text);
            }
            catch
            {
                MessageBox.Show("Please insert only numbers in all Text Boxes for Overview");
                return false;
            }

            //Connection
            try
            {
                sett.Connection.Tries = Convert.ToInt32(tB_Connection_Tries.Text);
            }
            catch
            {
                MessageBox.Show("Please insert only numbers in all Text Boxes for Connection");
                return false;
            }

            //Warning
            try
            {
                sett.Warning.CpuMax = Convert.ToInt32(tB_Warn_CPU.Text);
                sett.Warning.GpuMax = Convert.ToInt32(tB_Warn_GPU.Text);
                sett.Warning.MemMax = Convert.ToInt32(tB_Warn_MEM.Text);
                sett.Warning.DpcMax = Convert.ToInt32(tB_Warn_DPC.Text);
                sett.Warning.DfrMax = Convert.ToInt32(tB_Warn_DFR.Text);
            }
            catch
            {
                MessageBox.Show("Please insert only numbers in all Text Boxes for Warning");
                return false;
            }

            //Mail
            try
            {
                //Server
                sett.Mail.Sending.Server.Name = tB_Mail_ServerName.Text;
                sett.Mail.Sending.Server.Port = Convert.ToInt32(tB_Mail_ServerPort.Text);

                //Sender
                sett.Mail.Sending.SenderMail = tB_Mail_SenderMail.Text;
                sett.Mail.Sending.Password = tB_Mail_SenderPassword.Text;

                //Info
                sett.Mail.Sending.Subject = tB_Mail_Subject.Text;
                sett.Mail.Sending.Additional = rtB_Mail_AdditionalInfo.Text;
            }
            catch
            {
                MessageBox.Show("Please insert the rigth format into the textboxes");
                return false;
            }

            return true;
        }

        private void AddMail(object sender, EventArgs e)
        {
            lB_Mail_Mails.Items.Add(tB_Mail_AddMail.Text);
            sett.Mail.ToMail.Add(tB_Mail_AddMail.Text);
            tB_Mail_AddMail.Text = "";
            TextChanged(sender, e);
        }
    }
}
