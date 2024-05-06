using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ungabunga
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Zengin Metin Biçimi |*.rtf| Metin Belgesi |*.txt| Tüm Dosyalar |*.*";

            saveFileDialog1.Filter = "Zengin Metin Biçimi |*.rtf| Metin Belgesi |*.txt| Tüm Dosyalar |*.*";
        }

        private void TSMI_Kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TSMI_Ac_Click(object sender, EventArgs e)
        {
            // Dialog Penceresi Yapılan İşlemlerin Sonucunu DialogResult Olarak Döndürür
            DialogResult Sonuc = openFileDialog1.ShowDialog();
            if (Sonuc == DialogResult.OK) // Ok Butonuna Basılmış İse, Yani Dosya Seçilmiş İse
            {
                richTextBox1.LoadFile(openFileDialog1.FileName);
                // Rich Text Box .rtf Dosyalı Dosyaları Açar Ve Kaydeder
            }
        }

        private void TSMI_Kaydet_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
                MessageBox.Show("Dosya Kaydedildi");
            }
        }
    }
}
