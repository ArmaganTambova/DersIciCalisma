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

namespace WinFormKontrolleri
{
    public partial class ImageWiever : Form
    {
        string Path = ""; 

        public ImageWiever()
        {
            InitializeComponent();
        }

        private void BTN_FolderOpen_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Path = folderBrowserDialog1.SelectedPath;
                DirectoryInfo Di = new DirectoryInfo(Path);
                FileInfo[] Files = Di.GetFiles();

                foreach (FileInfo item in Files)
                {
                    if (item.Extension == ".png" || item.Extension == ".jpg" || item.Extension == ".jpeg")
                    {
                        PictureBox PB = new PictureBox();
                        PB.SizeMode = PictureBoxSizeMode.Zoom;
                        PB.BorderStyle = BorderStyle.FixedSingle;
                        PB.ImageLocation = item.FullName;
                        PB.Click += PB_Click;
                        flowLayoutPanel1.Controls.Add(PB);
                    }
                }
            }
        }

        private void PB_Click(object sender, EventArgs e)
        {
            PictureBox PB = (PictureBox)sender;
            pictureBox1.Image = PB.Image;
        }
    }
}
