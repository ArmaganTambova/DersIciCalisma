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
            if (!string.IsNullOrEmpty(TB_Isim.Text) && !string.IsNullOrEmpty(TB_Soyisim.Text) && !string.IsNullOrEmpty(MTB_Telefon.Text) && !string.IsNullOrEmpty(MTB_Iban.Text) && !string.IsNullOrEmpty(TB_Il.Text) && !string.IsNullOrEmpty(TB_Ilce.Text) && !string.IsNullOrEmpty(TB_Adres.Text) && !string.IsNullOrEmpty(TB_Okul.Text) && !string.IsNullOrEmpty(TB_Bolum.Text) && !string.IsNullOrEmpty(CB_Sinif.Text) && !string.IsNullOrEmpty(CB_Sube.Text))
            {
                string Isim = TB_Isim.Text;
                string Soyisim = TB_Soyisim.Text;
                string Telefon = MTB_Telefon.Text;
                string Iban = MTB_Iban.Text;
                string Adres = $"\n{TB_Il.Text}/{TB_Ilce.Text}\n{TB_Adres.Text}\n";
                string Okul = TB_Okul.Text;
                string Bolum = TB_Bolum.Text;
                string Sinif = $"{CB_Sinif.Text} / {CB_Sube.Text}";

                LBL_Bilgi.Text = $"{Isim} {Soyisim}\n{Telefon}\n{Iban}\n{Adres}\n{Okul}\n{Bolum}\n{Sinif}";

                TB_Isim.Text = null;
                TB_Soyisim.Text = null;
                MTB_Telefon.Text = null;
                MTB_Iban.Text = null;
                TB_Il.Text = null;
                TB_Ilce.Text = null;
                TB_Adres.Text = null;
                TB_Okul.Text = null;
                TB_Bolum.Text = null;
                CB_Sinif.Text = null;
                CB_Sube.Text = null;
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayın" , "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
