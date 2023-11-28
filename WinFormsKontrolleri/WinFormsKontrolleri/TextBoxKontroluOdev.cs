using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsKontrolleri
{
    public partial class TextBoxKontroluOdev : Form
    {
        public TextBoxKontroluOdev()
        {
            InitializeComponent();
        }

        private void BTN_Gonder_Click(object sender, EventArgs e)
        {
            string Isim = TB_Isim.Text;
            string Soyisim = TB_Soyisim.Text;
            string Telefon = MTB_Telefon.Text;
            string Iban = MTB_Iban.Text;
            string Adres = TB_Adres.Text;
            string Okul = TB_Okul.Text;
            string Bolum = TB_Bolum.Text;

            string Sinif = CB_Sinif.Text;
            string Sube = CB_Sube.Text;

            if (Sinif != null &&  Sube != null)
            {
                string GSinif = $"{CB_Sinif.Text} / {CB_Sube.Text}";

                if (Isim != null && Soyisim != null && Telefon != null && Iban != null && Adres != null && Okul != null && Bolum != null)
                {
                    LBL_Bilgi.Text = $"{Isim} {Soyisim}\n{Telefon}\n{Iban}\n{Adres}\n{Okul}\n{Bolum}\n{GSinif}";
                }
                else
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurduğunuzdan Emin Olunuz", "Hata");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurduğunuzdan Emin Olunuz", "Hata");
            }
        }
    }
}
