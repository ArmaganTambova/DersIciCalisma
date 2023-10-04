using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdevMiniHesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void BTN_Toplam_Click(object sender, EventArgs e)
        {
            string strSayi1 = TB_Sayi1.Text;
            string strSayi2 = TB_Sayi2.Text;

            long Sayi1, Sayi2;
            bool GecerliSayi1 = long.TryParse(strSayi1, out Sayi1);
            bool GecerliSayi2 = long.TryParse(strSayi2, out Sayi2);

            if (GecerliSayi1 && GecerliSayi2)
            {
                long Toplam = Sayi1 + Sayi2;
                TB_Sonuc.Clear();
                TB_Sonuc.Text = Toplam.ToString();
            }
            else
            {
                MessageBox.Show("Lütfen Geçerli Bir Değer Giriniz", "Hata");
            }
        }

        private void BTN_Cikarma_Click(object sender, EventArgs e)
        {
            string strSayi1 = TB_Sayi1.Text;
            string strSayi2 = TB_Sayi2.Text;

            long Sayi1, Sayi2;
            bool GecerliSayi1 = long.TryParse(strSayi1, out Sayi1);
            bool GecerliSayi2 = long.TryParse(strSayi2, out Sayi2);

            if (GecerliSayi1 && GecerliSayi2)
            {
                long Cikarma = Sayi1 - Sayi2;
                TB_Sonuc.Clear();
                TB_Sonuc.Text = Cikarma.ToString();
            }
            else
            {
                MessageBox.Show("Lütfen Geçerli Bir Değer Giriniz", "Hata");
            }
        }

        private void BTN_Carpma_Click(object sender, EventArgs e)
        {
            string strSayi1 = TB_Sayi1.Text;
            string strSayi2 = TB_Sayi2.Text;

            long Sayi1, Sayi2;
            bool GecerliSayi1 = long.TryParse(strSayi1, out Sayi1);
            bool GecerliSayi2 = long.TryParse(strSayi2, out Sayi2);

            if (GecerliSayi1 && GecerliSayi2)
            {
                long Carpma = Sayi1 * Sayi2;
                TB_Sonuc.Clear();
                TB_Sonuc.Text = Carpma.ToString();
            }
            else
            {
                MessageBox.Show("Lütfen Geçerli Bir Değer Giriniz", "Hata");
            }
        }

        private void BTN_Bolme_Click(object sender, EventArgs e)
        {
            string strSayi1 = TB_Sayi1.Text;
            string strSayi2 = TB_Sayi2.Text;

            long Sayi1, Sayi2;
            bool GecerliSayi1 = long.TryParse(strSayi1, out Sayi1);
            bool GecerliSayi2 = long.TryParse(strSayi2, out Sayi2);

            if (GecerliSayi1 && GecerliSayi2)
            {
                long Bolme = Sayi1 / Sayi2;
                TB_Sonuc.Clear();
                TB_Sonuc.Text = Bolme.ToString();
            }
            else
            {
                MessageBox.Show("Lütfen Geçerli Bir Değer Giriniz", "Hata");
            }
        }

        private void BTN_ModAlma_Click(object sender, EventArgs e)
        {
            string strSayi1 = TB_Sayi1.Text;
            string strSayi2 = TB_Sayi2.Text;

            long Sayi1, Sayi2;
            bool GecerliSayi1 = long.TryParse(strSayi1, out Sayi1);
            bool GecerliSayi2 = long.TryParse(strSayi2, out Sayi2);

            if (GecerliSayi1 && GecerliSayi2)
            {
                long ModAlma = Sayi1 % Sayi2;
                TB_Sonuc.Clear();
                TB_Sonuc.Text = ModAlma.ToString();
            }
            else
            {
                MessageBox.Show("Lütfen Geçerli Bir Değer Giriniz", "Hata");
            }
        }
    }
}
