using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        public int Ruedi;
        public int Fredi;
        public int Hans;
        public int Peter;
        public int Fridolin;
        public int Bertha;

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
                Ruedi = Convert.ToInt32(tB_Ruedi.Text);
                Fredi = Convert.ToInt32(tB_Fredi.Text);
                Hans = Convert.ToInt32(tB_Hans.Text);
                Peter = Convert.ToInt32(tB_Peter.Text);
                Fridolin = Convert.ToInt32(tB_Fridolin.Text);
                Bertha = Convert.ToInt32(tB_Bertha.Text);

                isNumber = true;
            }
            catch
            {
                MessageBox.Show("Bitte nur ganze Zahlen als Einsatz eintragen.");
                Clear();

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
                        RuediSpeed += 100;
                        break;
                    case 1:
                        FrediSpeed += 100;
                        break;
                    case 2:
                        HansSpeed += 100;
                        break;
                    case 3:
                        PeterSpeed += 100;
                        break;
                    case 4:
                        FridolinSpeed += 100;
                        break;
                    case 5:
                        BerthaSpeed += 100;
                        break;
                    default:
                        break;

                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
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
        }

        public void racePrep()
        {
            MessageBox.Show("Gut men young");
        }
    }
}
