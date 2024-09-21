using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RichTextBoxKontrolu
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Zengin Metin Biçimi|*rtf";
        }

        private void BTN_Ac_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName);
            }
        }

        private void BTN_Kaydet_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
            }
        }
    }
}
