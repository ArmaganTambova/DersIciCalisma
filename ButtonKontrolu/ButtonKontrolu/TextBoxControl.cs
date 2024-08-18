using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonKontrolu
{
    public partial class TextBoxControl : Form
    {
        public TextBoxControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox5.UseSystemPasswordChar)
            {
                textBox5.UseSystemPasswordChar = false;
                Image Img = Image.FromFile("../../Pictures/eye2.png");
                button1.Image = Img;
            }
            else
            {
                textBox5.UseSystemPasswordChar = true;
                Image Img = Image.FromFile("../../Pictures/noteye2.png");
                button1.Image = Img;
            }
        }
    }
}
