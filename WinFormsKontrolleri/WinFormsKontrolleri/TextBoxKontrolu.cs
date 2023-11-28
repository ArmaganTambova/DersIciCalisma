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
    public partial class TextBoxKontrolu : Form
    {
        public TextBoxKontrolu()
        {
            // InitializeComponent();:
            // ToolBox Aracılığıyla Forma Eklenen Tüm Kontrollerin Nesnelerin Oluşup Tanımlandığı Alandır
            InitializeComponent();

            TextBox TB_Murtaza = new TextBox(); // Nesne
            TB_Murtaza.Size = new Size(261, 20);
            TB_Murtaza.Location = new Point(93, 44);
            this.Controls.Add(TB_Murtaza); // Bu Formun, TextBoxKontrolu İsimli Formun Kontrellerine Ekle
        }

        private void BTN_Gonder_Click(object sender, EventArgs e)
        {
            // BTN_Gonder İsimli Butona Tıklanınca Yapılacak İşlemler Burada Yazılır

            string Isim = TB_Isim.Text;
            string Soyisim = TB_Soyisim.Text;
            string Telefom = MTB_Telefon.Text;
            string Iban = MTB_Iban.Text;
            string Adres = TB_Adres.Text;
            string Okul = TB_Okul.Text;

            LBL_Bilgi.Text = $"{Isim} {Soyisim}\n{Telefom}\n{Iban}\n{Adres}\n{Okul}";
        }
    }
}
