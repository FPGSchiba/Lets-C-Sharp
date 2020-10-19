using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pferderennen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool isNumber;

        public int RuediEinsatz;
        public int FrediEinsatz;
        public int HansEinsatz;
        public int PeterEinsatz;
        public int FridolinEinsatz;
        public int BerthaEinsatz;

        public int RuediSpeed;
        public int FrediSpeed;
        public int HansSpeed;
        public int PeterSpeed;
        public int FridolinSpeed;
        public int BerthaSpeed;

        public int winner;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                RuediEinsatz = Convert.ToInt32(tB_Ruedi.Text);
                FrediEinsatz = Convert.ToInt32(tB_Fredi.Text);
                HansEinsatz = Convert.ToInt32(tB_Hans.Text);
                PeterEinsatz = Convert.ToInt32(tB_Peter.Text);
                FridolinEinsatz = Convert.ToInt32(tB_Fridolin.Text);
                BerthaEinsatz = Convert.ToInt32(tB_Bertha.Text);

                isNumber = true;
            }
            catch(Exception er)
            {
                MessageBox.Show("Bitte nur ganze Zahlen als Einsatz eintragen.");
                Clear();

                Logger.ErrorLog(er.Message);

                isNumber = false;
            }

            try
            {
                winner = Win_Select.Items.IndexOf(Win_Select.SelectedItem);
                switch (winner)
                {
                    case -1:
                        break;
                    case 0:
                        break;
                    case 1:
                        RuediSpeed += 50;
                        break;
                    case 2:
                        FrediSpeed += 50;
                        break;
                    case 3:
                        HansSpeed += 50;
                        break;
                    case 4:
                        PeterSpeed += 50;
                        break;
                    case 5:
                        FridolinSpeed += 50;
                        break;
                    case 6:
                        BerthaSpeed += 50;
                        break;
                    default:
                        break;

                }
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message);
                Logger.ErrorLog(er.Message);
            }

            if (isNumber)
            {
                racePrep();
            }
        }

        public void Clear()
        {
            tB_Ruedi.Text = "";
            tB_Fredi.Text = "";
            tB_Hans.Text = "";
            tB_Peter.Text = "";
            tB_Fridolin.Text = "";
            tB_Bertha.Text = "";

            Win_Select.SelectedItem = "Spezial";
        }

        public void racePrep()
        {
            //Start next Form with the Params needed
            Thread thread = new Thread(startRace);
            thread.Start();

        }

        public void startRace()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Race());
        }
    }
}
