using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pferderennen
{
    public partial class Race : Form
    {
        public Race()
        {
            InitializeComponent();

            getVar();
        }

        #region GetForm1Var

        public int plusPerRound = 10;

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

        public void getVar()
        {
            if (Application.OpenForms["Form1"] != null)
            {
                Application.OpenForms["Form1"].Invoke(new Action(() => {

                    RuediEinsatz = (Application.OpenForms["Form1"] as Form1).RuediEinsatz;
                    FrediEinsatz = (Application.OpenForms["Form1"] as Form1).FrediEinsatz;
                    HansEinsatz = (Application.OpenForms["Form1"] as Form1).HansEinsatz;
                    PeterEinsatz = (Application.OpenForms["Form1"] as Form1).PeterEinsatz;
                    FridolinEinsatz = (Application.OpenForms["Form1"] as Form1).FridolinEinsatz;
                    BerthaEinsatz = (Application.OpenForms["Form1"] as Form1).BerthaEinsatz;

                    winner = (Application.OpenForms["Form1"] as Form1).winner;

                }));
            }
        }


        #endregion

        public int tickcount = 0;
        public int lastSpeed;
        public Dictionary<int, int> alle = new Dictionary<int, int>();

        private void timer1_Tick(object sender, EventArgs e)
        {
            RuediSpeed = newSpeed(0);
            FrediSpeed = newSpeed(1);
            HansSpeed = newSpeed(2);
            PeterSpeed = newSpeed(3);
            FridolinSpeed = newSpeed(4);
            BerthaSpeed = newSpeed(5);

            pB_Ruedi.Value = pB_Ruedi.Value + RuediSpeed;
            pB_Fredi.Value = pB_Fredi.Value + FrediSpeed;
            pB_Hans.Value = pB_Hans.Value + HansSpeed;
            pB_Peter.Value = pB_Peter.Value + PeterSpeed;
            pB_Fridolin.Value = pB_Fridolin.Value + FridolinSpeed;
            pB_Bertha.Value = pB_Bertha.Value + BerthaSpeed;



            if (tickcount == 10)
            {
                tickcount = 0;
                Logger.InfoLog("Current Process Ruedi: " + pB_Ruedi.Value);
                Logger.InfoLog("Current Process Fredi: " + pB_Fredi.Value);
                Logger.InfoLog("Current Process Hans: " + pB_Hans.Value);
                Logger.InfoLog("Current Process Peter: " + pB_Peter.Value);
                Logger.InfoLog("Current Process Fridolin: " + pB_Fridolin.Value);
                Logger.InfoLog("Current Process Bertha: " + pB_Bertha.Value);
            }

            tickcount++;
        }

        public int newSpeed(int name)
        {
            int end = 0;
            end = lastSpeed;

            while(end == lastSpeed)
            {
                end = IntExtension.Between(10, 200);
            }

            lastSpeed = end;
            
            if(name == winner)
            {
                end += plusPerRound;
            }

            return end;
        }
    }
}
