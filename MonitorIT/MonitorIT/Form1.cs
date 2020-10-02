using System;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace MonitorIT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int MaxDiskSpace;
        public string remoteName;
        public Socket socket;

        private void Form1_Shown(object sender, EventArgs e)
        {
            remoteName = MainMenu.remoteName;
            this.Text = "Dashboard - " + remoteName;
            socket = MainMenu.socket;
            MaxDiskSpace = getMaxDiskSpace();
            fill_CPU();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            fill_CPU();
        }

        private void fill_CPU()
        {
            if (MainMenu.verified)
            {
                byte[] msg = Encoding.ASCII.GetBytes("GetCPU");
                byte[] rec = new byte[1024];

                socket.Send(msg);
                int byteRec = socket.Receive(rec);

                cr_CPU.Series["CPU Percent"].Points.AddXY(DateTime.Now.ToString("HH:mm:ss"), Encoding.ASCII.GetString(rec, 0, byteRec));
                if (cr_CPU.Series["CPU Percent"].Points.Count() >= 10)
                {
                    cr_CPU.Series["CPU Percent"].Points.RemoveAt(0);
                    cr_CPU.ResetAutoValues();
                }

                msg = Encoding.ASCII.GetBytes("GetGPU");
                socket.Send(msg);
                byteRec = socket.Receive(rec);

                cr_GPU.Series["GPU Percent"].Points.AddXY(DateTime.Now.ToString("HH:mm:ss"), Encoding.ASCII.GetString(rec, 0, byteRec));
                if(cr_GPU.Series["GPU Percent"].Points.Count >= 10)
                {
                    cr_GPU.Series["GPU Percent"].Points.RemoveAt(0);
                    cr_GPU.ResetAutoValues();
                }

                msg = Encoding.ASCII.GetBytes("GetMEM");
                socket.Send(msg);
                byteRec = socket.Receive(rec);

                cr_MEM.Series["Memory Percent"].Points.AddXY(DateTime.Now.ToString("HH:mm:ss"), Encoding.ASCII.GetString(rec, 0, byteRec));
                if(cr_MEM.Series["Memory Percent"].Points.Count >= 10)
                {
                    cr_MEM.Series["Memory Percent"].Points.RemoveAt(0);
                    cr_MEM.ResetAutoValues();
                }

                msg = Encoding.ASCII.GetBytes("GetDPC");
                socket.Send(msg);
                byteRec = socket.Receive(rec);

                cr_DISK_Usage.Series[0].Points.AddXY(DateTime.Now.ToString("HH:mm:ss"), Encoding.ASCII.GetString(rec, 0, byteRec));
                if(cr_DISK_Usage.Series[0].Points.Count >= 10)
                {
                    cr_DISK_Usage.Series[0].Points.RemoveAt(0);
                    cr_DISK_Usage.ResetAutoValues();
                }

                cr_DISK_Free.ChartAreas[0].AxisY.Maximum = MaxDiskSpace;
                msg = Encoding.ASCII.GetBytes("GetDFR");
                socket.Send(msg);
                byteRec = socket.Receive(rec);

                cr_DISK_Free.Series[0].Points.AddXY(DateTime.Now.ToString("HH:mm:ss"), Encoding.ASCII.GetString(rec, 0, byteRec));
                if(cr_DISK_Free.Series[0].Points.Count >= 10)
                {
                    cr_DISK_Free.Series[0].Points.RemoveAt(0);
                    cr_DISK_Free.ResetAutoValues();
                }
            }
        }

        public int getMaxDiskSpace()
        {
            int ret = 0;

            if (MainMenu.verified)
            {

                byte[] msg = Encoding.ASCII.GetBytes("GetDFR");
                byte[] rec = new byte[1024];
                socket.Send(msg);

                int byteRec = socket.Receive(rec);
                ret = Convert.ToInt32(Encoding.ASCII.GetString(rec, 0, byteRec)) + 50;
            }

            return ret;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            byte[] bytes = new byte[1024];

            byte[] msg = Encoding.ASCII.GetBytes("disconnect");
            int bytesSent = socket.Send(msg);
        }
    }
}
