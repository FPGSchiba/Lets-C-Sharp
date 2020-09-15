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
    public partial class LeaderBoard : Form
    {
        public LeaderBoard()
        {
            InitializeComponent();

            getVar();
        }

        #region Var

        int RuediEinsatz;
        int FrediEinsatz;
        int HansEinsatz;
        int PeterEinsatz;
        int FridolinEinsatz;
        int BerthaEinsatz;

        int RuediProgress;
        int FrediProgress;
        int HansProgress;
        int PeterProgress;
        int FridolinProgress;
        int BerthaProgress;

        int RuediGewinn = 0;
        int FrediGewinn = 0;
        int HansGewinn = 0;
        int PeterGewinn = 0;
        int FridolinGewinn = 0;
        int BerthaGewinn = 0;

        int RuediPlace;
        int FrediPlace;
        int HansPlace;
        int PeterPlace;
        int FridolinPlace;
        int BerthaPlace;

        int winner;

        void getVar()
        {
            if (Application.OpenForms["Race"] != null)
            {
                Application.OpenForms["Race"].Invoke(new Action(() => {

                    RuediEinsatz = (Application.OpenForms["Race"] as Race).RuediEinsatz;
                    FrediEinsatz = (Application.OpenForms["Race"] as Race).FrediEinsatz;
                    HansEinsatz = (Application.OpenForms["Race"] as Race).HansEinsatz;
                    PeterEinsatz = (Application.OpenForms["Race"] as Race).PeterEinsatz;
                    FridolinEinsatz = (Application.OpenForms["Race"] as Race).FridolinEinsatz;
                    BerthaEinsatz = (Application.OpenForms["Race"] as Race).BerthaEinsatz;

                    RuediProgress = (Application.OpenForms["Race"] as Race).pB_Ruedi.Value;
                    FrediProgress = (Application.OpenForms["Race"] as Race).pB_Fredi.Value;
                    HansProgress = (Application.OpenForms["Race"] as Race).pB_Hans.Value;
                    PeterProgress = (Application.OpenForms["Race"] as Race).pB_Peter.Value;
                    FridolinProgress = (Application.OpenForms["Race"] as Race).pB_Fridolin.Value;
                    BerthaProgress = (Application.OpenForms["Race"] as Race).pB_Bertha.Value;

                    winner = (Application.OpenForms["Race"] as Race).winner;
                }));
            }

            outPut();
        }

        #endregion

        private void outPut()
        {
            int completeMoney = BerthaEinsatz + FrediEinsatz + FridolinEinsatz + HansEinsatz + PeterEinsatz + RuediEinsatz;
            int winners = 0;
            int gewinnProPerson = 0;
            var places = new SortedDictionary<int, int>(new ReverseComparer<int>(Comparer<int>.Default));
            int placecounter = 0;

            try
            {
                winners = Convert.ToInt32(tB_Winners.Text);
            }
            catch
            {
                Logger.InfoLog("Keine Zahl im Textfeld für die anz. Gewinner");
            }

            if(winners != 0)
            {
                gewinnProPerson = Convert.ToInt32(completeMoney / winners);
            }

            switch (winner)
            {
                case 0:
                    RuediGewinn = gewinnProPerson;
                    break;
                case 1:
                    FrediGewinn = gewinnProPerson;
                    break;
                case 2:
                    HansGewinn = gewinnProPerson;
                    break;
                case 3:
                    PeterGewinn = gewinnProPerson;
                    break;
                case 4:
                    FridolinGewinn = gewinnProPerson;
                    break;
                case 5:
                    BerthaGewinn = gewinnProPerson;
                    break;
                default:
                    MessageBox.Show("Kein Richtiger gewinner erkannt.");
                    Logger.ErrorLog("No real winner LeaderBoard.cs on Line 111");
                    break;
            }

            places.Add(RuediProgress, 0);
            places.Add(FrediProgress, 1);
            places.Add(HansProgress, 2);
            places.Add(PeterProgress, 3);
            places.Add(FridolinProgress, 4);
            places.Add(BerthaProgress, 5);

            
            foreach(var i in places)
            {
                placecounter++;

                switch (i.Value)
                {
                    case 0:
                        RuediPlace = placecounter;
                        break;
                    case 1:
                        FrediPlace = placecounter;
                        break;
                    case 2:
                        HansPlace = placecounter;
                        break;
                    case 3:
                        PeterPlace = placecounter;
                        break;
                    case 4:
                        FridolinPlace = placecounter;
                        break;
                    case 5:
                        BerthaPlace = placecounter;
                        break;
                    default:
                        Logger.ErrorLog("Dictionary failed at LeaderBoard.cs on Line 160");
                        break;
                }
            }

            writeLabels();
        }

        private void writeLabels()
        {
            PL_Ruedi.Text = RuediPlace.ToString() + ". Platz";
            PL_Fredi.Text = FrediPlace.ToString() + ". Platz";
            PL_Hans.Text = HansPlace.ToString() + ". Platz";
            PL_Peter.Text = PeterPlace.ToString() + ". Platz";
            PL_Fridolin.Text = FridolinPlace.ToString() + ". Platz";
            PL_Bertha.Text = BerthaPlace.ToString() + ". Platz";

            ES_Ruedi.Text = RuediEinsatz.ToString() + " CHF Einsatz";
            ES_Fredi.Text = FrediEinsatz.ToString() + " CHF Einsatz";
            ES_Hans.Text = HansEinsatz.ToString() + " CHF Einsatz";
            ES_Peter.Text = PeterEinsatz.ToString() + " CHF Einsatz";
            ES_Fridolin.Text = FridolinEinsatz.ToString() + " CHF Einsatz";
            ES_Bertha.Text = BerthaEinsatz.ToString() + " CHF Einsatz";

            G_Ruedi.Text = RuediGewinn.ToString() + " CHF Gewinn pro Person";
            G_Fredi.Text = FrediGewinn.ToString() + " CHF Gewinn pro Person";
            G_Hans.Text = HansGewinn.ToString() + " CHF Gewinn pro Person";
            G_Peter.Text = PeterGewinn.ToString() + " CHF Gewinn pro Person";
            G_Fridolin.Text = FridolinGewinn.ToString() + " CHF Gewinn pro Person";
            G_Bertha.Text = BerthaGewinn.ToString() + " CHF Gewinn pro Person";
        }

        private void B_finished_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Form1"] != null)
            {
                Application.OpenForms["Form1"].Invoke(new Action(() => {

                    (Application.OpenForms["Form1"] as Form1).Clear();

                }));
            }

            if (Application.OpenForms["Race"] != null)
            {
                Application.OpenForms["Race"].Invoke(new Action(() => {

                    (Application.OpenForms["Race"] as Race).Close();

                }));
            }

            Application.OpenForms["LeaderBoard"].Close();
        }

        private void tB_Winners_TextChanged(object sender, EventArgs e)
        {
            outPut();
        }
    }
}
