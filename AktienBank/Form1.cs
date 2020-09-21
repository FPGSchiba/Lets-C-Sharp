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

        int Mohatu;
        int Uru;
        int Nuka;
        int Chumvi;

        private void timer_Tick(object sender, EventArgs e)
        {
            Mohatu += getRandom();
            Uru += getRandom();
            Nuka += getRandom();
            Chumvi += getRandom();

            if(Mohatu <= 0)
            {
                Mohatu = 0;
            }
            if(Uru <= 0)
            {
                Uru = 0;
            }
            if(Nuka <= 0)
            {
                Nuka = 0;
            }
            if(Chumvi <= 0)
            {
                Chumvi = 0;
            }

            chart1.Series[0].Points.AddXY(DateTime.Now.ToString("h:mm:ss"), Mohatu);
            chart1.Series[1].Points.AddXY(DateTime.Now.ToString("h:mm:ss"), Uru);
            chart1.Series[2].Points.AddXY(DateTime.Now.ToString("h:mm:ss"), Nuka);
            chart1.Series[3].Points.AddXY(DateTime.Now.ToString("h:mm:ss"), Chumvi);

            if(chart1.Series[0].Points.Count == 10)
            {
                chart1.Series[0].Points.RemoveAt(0);
                chart1.Series[1].Points.RemoveAt(0);
                chart1.Series[2].Points.RemoveAt(0);
                chart1.Series[3].Points.RemoveAt(0);
            }
        }

        private int getRandom()
        {
            return IntExtension.Between(-20, 20);
        }

        private int startProg()
        {
            return IntExtension.Between(10, 90);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Mohatu = startProg();
            Uru = startProg();
            Nuka = startProg();
            Chumvi = startProg();
        }
    }
}
