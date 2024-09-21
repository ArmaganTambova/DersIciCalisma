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
    public partial class RadioButton : Form
    {
        public RadioButton()
        {
            InitializeComponent();
        }

        private void BTN_Getir_Click(object sender, EventArgs e)
        {
            string Metin = null;

            if (RB_Erkek.Checked)
            {
                Metin += "Erkek / ";
            }
            else
            {
                Metin += "Kadin  / ";
            }

            if (RB_Bekar.Checked)
            {
                Metin += "Bekar";
            }
            else
            {
                Metin += "Evli";
            }

            LBL_Sonuc.Text = Metin;
        }

        private void BTN_GizleGoster_Click(object sender, EventArgs e)
        {
            if (BTN_GizleGoster.Text == "Gizle")
            {
                GB_MedeniHal.Enabled = false;
                BTN_GizleGoster.Text = "Göster";
            }
            else
            {
                GB_MedeniHal.Enabled = true;
                BTN_GizleGoster.Text = "Gizle";
            }
        }
    }
}
