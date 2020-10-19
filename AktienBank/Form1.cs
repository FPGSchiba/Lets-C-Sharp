using Pferderennen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AktienBank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int oldMax;
        int Mohatu;
        int Uru;
        int Nuka;
        int Chumvi;

        private void timer_Tick(object sender, EventArgs e)
        {
            CreateEntry();
        }

        public void CreateEntry()
        {
            List<int> all = new List<int>();

            Mohatu += round(getRandom(), 10);
            Uru += round(getRandom(), 10);
            Nuka += round(getRandom(), 10);
            Chumvi += round(getRandom(), 10);

            all.Add(Mohatu);
            all.Add(Uru);
            all.Add(Nuka);
            all.Add(Chumvi);

            Mohatu_Int.Text = "Mohatu AG: " + Mohatu;
            Uru_Int.Text = "Uru Consulting: " + Uru;
            Nuka_Int.Text = "Nuka: " + Nuka;
            Chumvi_Int.Text = "Chumvi RGB: " + Chumvi;

            if(oldMax < all.Max())
            {
                oldMax = all.Max();
                chart1.ChartAreas[0].AxisY.Maximum = all.Max() + 10;
            }

            if (Mohatu <= 0)
            {
                Mohatu = 0;
            }
            if (Uru <= 0)
            {
                Uru = 0;
            }
            if (Nuka <= 0)
            {
                Nuka = 0;
            }
            if (Chumvi <= 0)
            {
                Chumvi = 0;
            }

            chart1.Series[0].Points.AddXY(DateTime.Now.ToString("HH:mm:ss"), Mohatu);
            chart1.Series[1].Points.AddXY(DateTime.Now.ToString("HH:mm:ss"), Uru);
            chart1.Series[2].Points.AddXY(DateTime.Now.ToString("HH:mm:ss"), Nuka);
            chart1.Series[3].Points.AddXY(DateTime.Now.ToString("HH:mm:ss"), Chumvi);

            if (chart1.Series[0].Points.Count == 10)
            {
                chart1.Series[0].Points.RemoveAt(0);
                chart1.Series[1].Points.RemoveAt(0);
                chart1.Series[2].Points.RemoveAt(0);
                chart1.Series[3].Points.RemoveAt(0);
            }
        }

        private int getRandom()
        {
            try
            {
                return IntExtension.Between(-Convert.ToInt32(tB_Worth.Text), Convert.ToInt32(tB_Worth.Text));
            }
            catch
            {
                MessageBox.Show("Bitte nur Nummern, als Wert eintragen.");
            }
            return IntExtension.Between(-40, 40);
        }

        private int startProg()
        {
            return IntExtension.Between(10, 200);
        }

        private int getRound()
        {
            return IntExtension.Between(0, 1);
        }

        int round(int n, int m)
        {

            if(getRound() == 0)
            {
                return n >= 0 ? (n / m) * m : ((n - m + 1) / m) * m;
            }
            else
            {
                return n >= 0 ? ((n + m - 1) / m) * m : (n / m) * m;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Mohatu = round(startProg(), 10);
            Uru = round(startProg(), 10);
            Nuka = round(startProg(), 10);
            Chumvi = round(startProg(), 10);

            for(int i = 0; i <= 5; i++)
            {
                CreateEntry();
            }
        }
    }
}
