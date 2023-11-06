using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdevOrtalamaHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_Ortalama_Click(object sender, EventArgs e)
        {
            string strNot1 = TB_Not1.Text;
            string strNot2 = TB_Not2.Text;

            double Not1, Not2;
            bool GecerliNot1 = double.TryParse(strNot1, out Not1);
            bool GecerliNot2 = double.TryParse(strNot2, out Not2);

            if (GecerliNot1 && GecerliNot2)
            {
                double Ortalama = (Not1 + Not2) / 2;
                TB_Ortalama.Text = Ortalama.ToString();
                if (Ortalama >= 50)
                {
                    MessageBox.Show("Geçtiniz", "Sistem Bildirimi");
                }
                else
                {
                    MessageBox.Show("Kaldınız", "Sistem Bildirimi");
                }
            }
        }
    }
}
