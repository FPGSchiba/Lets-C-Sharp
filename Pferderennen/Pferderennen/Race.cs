using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public int plusPerRound = 20;

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

        public int willwinner;

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

                    willwinner = (Application.OpenForms["Form1"] as Form1).winner;

                    timer.Start();

                }));
            }
        }


        #endregion

        public int tickcount = 0;
        public int lastSpeed;
        public Dictionary<int, int> alle = new Dictionary<int, int>();
        public int winner = -1;
        public bool isFinished = false;
        public Stopwatch timer = new Stopwatch();

        private void timer1_Tick(object sender, EventArgs e)
        {
            RuediSpeed = newSpeed(0);
            FrediSpeed = newSpeed(1);
            HansSpeed = newSpeed(2);
            PeterSpeed = newSpeed(3);
            FridolinSpeed = newSpeed(4);
            BerthaSpeed = newSpeed(5);

            try
            {
                pB_Ruedi.Value = pB_Ruedi.Value + RuediSpeed;
            }
            catch
            {
                timer.Stop();
                pB_Ruedi.Value = 10000;
                timer1.Enabled = false;
                winner = 0;
                isFinished = true;
            }

            try
            {
                pB_Fredi.Value = pB_Fredi.Value + FrediSpeed;
            }
            catch
            {
                timer.Stop();
                pB_Fredi.Value = 10000;
                timer1.Enabled = false;
                winner = 1;
                isFinished = true;
            }

            try
            {
                pB_Hans.Value = pB_Hans.Value + HansSpeed;
            }
            catch
            {
                timer.Stop();
                pB_Hans.Value = 10000;
                timer1.Enabled = false;
                winner = 2;
                isFinished = true;
            }

            try
            {
                pB_Peter.Value = pB_Peter.Value + PeterSpeed;
            }
            catch
            {
                timer.Stop();
                pB_Peter.Value = 10000;
                timer1.Enabled = false;
                winner = 3;
                isFinished = true;
            }

            try
            {
                pB_Fridolin.Value = pB_Fridolin.Value + FridolinSpeed;
            }
            catch
            {
                timer.Stop();
                pB_Fridolin.Value = 10000;
                timer1.Enabled = false;
                winner = 4;
                isFinished = true;
            }

            try
            {
                pB_Bertha.Value = pB_Bertha.Value + BerthaSpeed;
            }
            catch
            {
                timer.Stop();
                pB_Bertha.Value = 10000;
                timer1.Enabled = false;
                winner = 4;
                isFinished = true;
            }
            

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

            if (isFinished)
            {
                raceFinished();
            }
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
            
            if(name == willwinner)
            {
                end += plusPerRound;
            }

            return end;
        }

        public void raceFinished()
        {
            string win = "";

            switch (winner)
            {
                case -1:
                    win = "err";
                    Logger.ErrorLog("Index out of Range Race.cs on Line 203");
                    break;
                case 0:
                    win = "Ruedi";
                    break;
                case 1:
                    win = "Fredi";
                    break;
                case 2:
                    win = "Hans";
                    break;
                case 3:
                    win = "Peter";
                    break;
                case 4:
                    win = "Fridolin";
                    break;
                case 5:
                    win = "Bertha";
                    break;
                default:
                    win = "Err";
                    Logger.ErrorLog("Index out of Range Race.cs on Line 224");
                    break;
            }

            Logger.InfoLog("Race has finished with exit code 0");
            Logger.InfoLog(win + " has won in " + Math.Round(timer.Elapsed.TotalSeconds, 2) + "Seconds");

            MessageBox.Show(win + " hat das Rennen nach " + Math.Round(timer.Elapsed.TotalSeconds, 2) + " Sekunden gewonnen");
        }
    }
}
