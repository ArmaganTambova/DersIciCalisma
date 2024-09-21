using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        string[] Islemler = { "+", "-", "/", "*", "." };
        double Sonuc = 0;
        double Memory = 0;

        private void TB_Hesap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !Islemler.Contains(e.KeyChar.ToString()) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void BTN_DegerEkle(object sender, EventArgs e)
        {
            Button button = sender as Button;

            string Sayi = button.Text;

            string TBDeger = TB_Hesap.Text;

            if (TBDeger.Length > 0)
            {
                if (Islemler.Contains(TBDeger[TBDeger.Length - 1].ToString()))
                {
                    if (!Islemler.Contains(Sayi))
                    {
                        TB_Hesap.Text += Sayi;
                    }
                }
                else
                {
                    TB_Hesap.Text += Sayi;
                }
            }
            else
            {
                TB_Hesap.Text += Sayi;
            }
        }

        private void BTN_DahaOlmadi(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Özellik Daha Aktif Değil", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BTN_C_Click(object sender, EventArgs e)
        {
            TB_Hesap.Text = string.Empty;
            Memory = 0;
        }

        private void BTN_Backspace_Click(object sender, EventArgs e)
        {
            if (TB_Hesap.Text.Length > 0)
            {
                TB_Hesap.Text = TB_Hesap.Text.Substring(0, TB_Hesap.Text.Length - 1);
            }
        }

        private void BTN_MC_Click(object sender, EventArgs e)
        {
            Memory = 0;
        }

        private void BTN_MR_Click(object sender, EventArgs e)
        {
            if (Memory != 0)
            {
                TB_Hesap.Text = $"{Memory}";
            }
            else
            {
                MessageBox.Show("Hafızadaki Değer 0'dır", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void BTN_MS_Click(object sender, EventArgs e)
        {
            Memory = Sonuc;
        }

        private void BTN_MArti_Click(object sender, EventArgs e)
        {
            Memory += Sonuc;
        }

        private void BTN_Esittir_Click(object sender, EventArgs e)
        {

        }
    }
}
