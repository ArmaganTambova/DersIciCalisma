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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Button Btn_Tikla = new Button();
            Btn_Tikla.Text = "Tıkla";
            Btn_Tikla.Location = new Point(10, 40);
            // Delegate Oluşturma
            // Delegate Olayın Gerçekleştiği Anda Çalışacak Olan Metodu Adresler
            Btn_Tikla.Click += Btn_Tikla_Click;
            this.Controls.Add(Btn_Tikla);
        }

        private void Btn_Tikla_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }
    }
}
