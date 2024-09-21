using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullaniciGirisi
{
    public partial class Giris : Form
    {
        bool islogin = false;
        public Giris()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TB_KullaniciAdi.Text))
            {

                if (!string.IsNullOrEmpty(TB_Sifre.Text))
                {
                    if (TB_Sifre.Text == "1234" & TB_KullaniciAdi.Text == "Admin")
                    {
                        islogin = true;
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Şifre veya kullanıcı adı hatalı");
                    }
                }
                else
                {
                    MessageBox.Show("Şifre boş bırakılmamalı");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı boş bırakılmamalı");
            }
        }

        private void Giris_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!islogin)
            {
                Application.Exit();
            }
        }

        bool b = false;

        private void Giris_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (!islogin)
            {

                DialogResult msg = MessageBox.Show("Çıkış yapmak istiyormusnuz?", "Uyarı", MessageBoxButtons.OKCancel);
                if (msg != DialogResult.OK)
                {

                    e.Cancel = true;

                }

            }

        }
    }
}
