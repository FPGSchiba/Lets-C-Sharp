using System;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xabe.FFmpeg;

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
            pB_FileProgress.Visible = true;

            if (savefileName != "" && openfileName != "")
            {
                await Task.Run(() => startConvert());
            }
            else
            {
                MessageBox.Show("Kein Pfad ausgewählt");
            }

            MessageBox.Show("Fertig!");
            pB_FileProgress.Visible = false;
        }

        [Obsolete]
        private async Task startConvert()
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
    }
}