using System;
using System.Windows.Forms;

namespace YT2mp3_mp4
{
    public partial class URLPicker : Form
    {
        public URLPicker()
        {
            InitializeComponent();
        }

        public bool isValid;
        public string videoURL;
        public bool isMP4;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Uri uriResult;
            isValid = Uri.TryCreate(tB_URL.Text, UriKind.Absolute, out uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

            cB_isValid.Checked = isValid;
        }

        private void B_OK_Click(object sender, EventArgs e)
        {
            videoURL = tB_URL.Text;
            isMP4 = cB_isMP4.Checked;

            if (isValid)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Please insert correct URL");
            }
        }
    }
}
