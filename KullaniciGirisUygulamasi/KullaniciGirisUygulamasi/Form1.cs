using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullaniciGirisUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BT_Giris_Click(object sender, EventArgs e)
        {
            string Kullanici = TB_KullaniciAdi.Text;
            string Sifre = TB_Sifre.Text;

            if (Kullanici == "admin" && Sifre == "1234")
            {
                MessageBox.Show("Hoşgeldin Admin", "Giriş Başarılı");
            }
            else
            {
                MessageBox.Show("Giriş Bilgilerini Kontrol Ediniz", "Giriş Başarısız");
            }
        }
    }
}
