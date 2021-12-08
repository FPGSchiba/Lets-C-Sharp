using System;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xabe.FFmpeg;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace YT2mp3_mp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string openfileName = "";
        public string savefileNameMP3 = "";
        public string savefileNameMP4 = "";
        public string URL = "";
        public bool urlOK = false;
        public bool isURL = false;
        public bool isMP4;

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            openfileName = openFileDialog.FileName;
            saveFileDialog.ShowDialog();
        }

        private void B_Path_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            savefileNameMP3 = saveFileDialog.FileName;
        }

        [Obsolete]
        private async void B_Convert_Click(object sender, EventArgs e)
        {

            if (savefileNameMP3 != "" && openfileName != "")
            {
                await Task.Run(() => startConvertFile());
                MessageBox.Show("Fertig!");
            }
            else if (isURL)
            {
                await Task.Run(() => startConvertURL());
            }
            else
            {
                MessageBox.Show("Kein Pfad ausgewählt");
            }
        }

        [Obsolete]
        private async Task startConvertFile()
        {
            var mediaInfo = await MediaInfo.Get(openfileName);
            var audioStream = mediaInfo.AudioStreams.First();
            var conversion = Conversion.New()
            .AddStream(audioStream)
            .SetOutput(savefileNameMP3)
            .SetOverwriteOutput(true)
            .UseMultiThread(true)
            .SetPreset(ConversionPreset.UltraFast);
            conversion.OnProgress += async (sender, args) =>
            {
                await Task.Run(() => (Application.OpenForms["Form1"].Invoke(new Action(() => { (Application.OpenForms["Form1"] as Form1).pB_FileProgress.Value = args.Percent; }))));
            };

            await conversion.Start();
        }

        [Obsolete]
        private async void startConvertURL()
        {
            await Task.Run(() => (Application.OpenForms["Form1"].Invoke(new Action(() => {(Application.OpenForms["Form1"] as Form1).L_Vtitel.Visible = true; }))));
            await Task.Run(() => (Application.OpenForms["Form1"].Invoke(new Action(() => {(Application.OpenForms["Form1"] as Form1).L_timeCodeLast.Visible = true; }))));
            await Task.Run(() => (Application.OpenForms["Form1"].Invoke(new Action(() => {(Application.OpenForms["Form1"] as Form1).L_timeCodeCurrent.Visible = true; }))));

            try
            {
                var youtube = new YoutubeClient();

                var video = await youtube.Videos.GetAsync(URL);
                var title = video.Title;

                await Task.Run(() => (Application.OpenForms["Form1"].Invoke(new Action(() => { (Application.OpenForms["Form1"] as Form1).L_Vtitel.Text = title; }))));

                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(URL);
                var progressIndicator = new Progress<double>(ReportProgress);

                if (isMP4)
                {
                    var streamInfo = streamManifest.GetVideoStreams().GetWithHighestVideoQuality();
                    await youtube.Videos.Streams.DownloadAsync(streamInfo, savefileNameMP4, progressIndicator);
                }
                else
                {
                    var streamInfo = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();
                    await youtube.Videos.Streams.DownloadAsync(streamInfo, savefileNameMP3, progressIndicator);
                }

                await Task.Run(() => (Application.OpenForms["Form1"].Invoke(new Action(() => { (Application.OpenForms["Form1"] as Form1).L_Vtitel.Visible = false; }))));
                MessageBox.Show("Fertig!");

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private async void ReportProgress(double value)
        {
            int progress = (int)(value * 1000);
            await Task.Run(() => Application.OpenForms["Form1"].Invoke(new Action(() => { (Application.OpenForms["Form1"] as Form1).pB_FileProgress.Value = progress; })));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pickURL();

            isURL = true;
        }

        private void pickURL()
        {
            URLPicker uRLPicker = new URLPicker();
            uRLPicker.FormClosing += getURL;
            uRLPicker.Show();
        }

        private void getURL(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms["URLPicker"] != null)
            {
                Application.OpenForms["URLPicker"].Invoke(new Action(() => {

                    urlOK = (Application.OpenForms["URLPicker"] as URLPicker).isValid;
                    URL = (Application.OpenForms["URLPicker"] as URLPicker).videoURL;
                    isMP4 = (Application.OpenForms["URLPicker"] as URLPicker).isMP4;

                }));
            }

            if (isMP4)
            {
                saveFileDialogMP4.ShowDialog();
            }
            else
            {
                saveFileDialog.ShowDialog();
            }
        }

        private void saveFileDialogMP4_FileOk(object sender, CancelEventArgs e)
        {
            savefileNameMP4 = saveFileDialogMP4.FileName;
        }
    }
}
