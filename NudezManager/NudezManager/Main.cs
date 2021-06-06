using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NudezManager
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;

            listView1.Columns.Add("Images", 300);
            listView1.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);

            populate();
        }

        private void populate()
        {
            string[] images = Directory.GetFiles(@"C:\Users\Jann\OneDrive - UMB AG\Bilder\Test");

            imageList1.ImageSize = new Size(300, 300);

            foreach (string image in images)
            {
                imageList1.Images.Add(Image.FromFile(image));
            }

            listView1.SmallImageList = imageList1;
            int count = 0;

            foreach (string i in images)
            {
                listView1.Items.Add(i, count);
                count++;
            }
        }
    }
}
