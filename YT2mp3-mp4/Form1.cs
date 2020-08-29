using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xabe.FFmpeg;
using VideoLibrary;

namespace YT2mp3_mp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string openfileName = "";
        public string savefileName = "";
        public string URL = "";
        public bool urlOK = false;
        public bool isURL = false;

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
            savefileName = saveFileDialog.FileName;
        }

        [Obsolete]
        private async void B_Convert_Click(object sender, EventArgs e)
        {

            if (savefileName != "" && openfileName != "")
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
            .SetOutput(savefileName)
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

            try
            {
                string fileForDownload = savefileName.Replace("mp3", "mp4");

                var youTube = YouTube.Default;
                var video = youTube.GetVideo(URL);
                await Task.Run(() => (Application.OpenForms["Form1"].Invoke(new Action(() => {(Application.OpenForms["Form1"] as Form1).L_Vtitel.Text = video.Title; }))));
                File.WriteAllBytes(fileForDownload, video.GetBytes());

                var mediaInfo = await MediaInfo.Get(fileForDownload);
                var audioStream = mediaInfo.AudioStreams.First();
                var conversion = Conversion.New()
                .AddStream(audioStream)
                .SetOutput(savefileName)
                .SetOverwriteOutput(true)
                .UseMultiThread(true)
                .SetPreset(ConversionPreset.UltraFast);
                conversion.OnProgress += async (sender, args) =>
                {
                    await Task.Run(() => (Application.OpenForms["Form1"].Invoke(new Action(() => { (Application.OpenForms["Form1"] as Form1).pB_FileProgress.Value = args.Percent; }))));
                };

                await conversion.Start();

                File.Delete(fileForDownload);
                MessageBox.Show("Fertig!");
                await Task.Run(() => (Application.OpenForms["Form1"].Invoke(new Action(() => { (Application.OpenForms["Form1"] as Form1).L_Vtitel.Visible = false; }))));
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
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

                }));
            }

            saveFileDialog.ShowDialog();
        }
    }
}