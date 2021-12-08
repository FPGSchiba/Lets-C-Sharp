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

        int stock1;
        int stock2;
        int stock3;
        int stock4;
        int stock5;

        int interval = 150;

        string stock1Name = "None";
        string stock2Name = "Rütli Studios";
        string stock3Name = "Habsburger AG";
        string stock4Name = "Tell Cop.";
        string stock5Name = "Gessler Foundation";

        private void timer_Tick(object sender, EventArgs e)
        {
            CreateEntry();
        }

        public void CreateEntry()
        {
            List<int> all = new List<int>();

            stock2 += round(getRandom(), 10);
            stock3 += round(getRandom(), 10);
            stock4 += round(getRandom(), 10);
            stock5 += round(getRandom(), 10);

            all.Add(stock2);
            all.Add(stock3);
            all.Add(stock4);
            all.Add(stock5);

            if(stock1 < all.Max())
            {
                stock1 = all.Max();
                chart1.ChartAreas[0].AxisY.Maximum = all.Max() + 10;
            }

            if (stock2 <= 0)
            {
                stock2 = 0;
            }
            if (stock3 <= 0)
            {
                stock3 = 0;
            }
            if (stock4 <= 0)
            {
                stock4 = 0;
            }
            if (stock5 <= 0)
            {
                stock5 = 0;
            }

            tb_stock2.Text = stock2Name + ": " + stock2;
            tb_stock3.Text = stock3Name + ": " + stock3;
            tb_stock4.Text = stock4Name + ": " + stock4;
            tb_stock5.Text = stock5Name + ": " + stock5;

            chart1.Series[0].Points.AddXY(DateTime.Now.ToString("HH:mm:ss"), stock2);
            chart1.Series[1].Points.AddXY(DateTime.Now.ToString("HH:mm:ss"), stock3);
            chart1.Series[2].Points.AddXY(DateTime.Now.ToString("HH:mm:ss"), stock4);
            chart1.Series[3].Points.AddXY(DateTime.Now.ToString("HH:mm:ss"), stock5);

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
                return IntExtension.Between(-40, 40);
            }
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
            chart1.Series[0].Name = stock2Name;
            chart1.Series[1].Name = stock3Name;
            chart1.Series[2].Name = stock4Name;
            chart1.Series[3].Name = stock5Name;

            //TODO: change names of stocks with Variables
            timer.Interval = interval * 1000;
            stock2 = round(startProg(), 10);
            stock3 = round(startProg(), 10);
            stock4 = round(startProg(), 10);
            stock5 = round(startProg(), 10);

            for(int i = 0; i <= 5; i++)
            {
                CreateEntry();
            }
        }
    }
}
