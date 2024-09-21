using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormKontrolleri
{
    public partial class TakvimKontolleri : Form
    {
        public TakvimKontolleri()
        {
            InitializeComponent();
        }

        private void TakvimKontolleri_Load(object sender, EventArgs e)
        {
            DateTime Tarih = DateTime.Now;

            LBL_Tarih.Text = DateTime.Now.ToString();
            LBL_UzunTarih.Text = Tarih.ToLongDateString() + " Saat " + Tarih.ToLongTimeString();
            LBL_KisaTarih.Text = Tarih.ToShortDateString() + " Saat " + Tarih.ToShortTimeString();

            LBL_Yil.Text = Tarih.Year.ToString();
            LBL_Ay.Text = Tarih.Month.ToString();
            LBL_Gun.Text = Tarih.Day.ToString();

            LBL_Saat.Text = Tarih.Hour.ToString();
            LBL_Dakika.Text = Tarih.Minute.ToString();
            LBL_Saniye.Text = Tarih.Second.ToString();
        }

        private void LBL_Tarih_Click(object sender, EventArgs e)
        {
            LBL_Tarih.Text = DateTime.Now.ToString();

            DateTime Tarih = DateTime.Now;

            LBL_Tarih.Text = DateTime.Now.ToString();

            LBL_Yil.Text = Tarih.Year.ToString();
            LBL_Ay.Text = Tarih.Month.ToString();
            LBL_Gun.Text = Tarih.Day.ToString();

            LBL_Saat.Text = Tarih.Hour.ToString();
            LBL_Dakika.Text = Tarih.Minute.ToString();
            LBL_Saniye.Text = Tarih.Second.ToString();
        }
    }
}
