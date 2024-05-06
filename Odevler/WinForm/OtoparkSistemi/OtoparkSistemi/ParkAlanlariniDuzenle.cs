using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkSistemi
{
    public partial class ParkAlanlariniDuzenle : Form
    {
        public ParkAlanlariniDuzenle()
        {
            InitializeComponent();

            GB_Ekle.Visible = false;
            GB_Silme.Visible = false;
        }

        private void BTN_Ekle_Click(object sender, EventArgs e)
        {
            if (GB_Silme.Visible)
            {
                GB_Silme.Visible = false;
            }

            if (!GB_Ekle.Visible)
            {
                GB_Ekle.Visible = true;
            }
        }

        private void BTN_Sil_Click(object sender, EventArgs e)
        {
            if (GB_Ekle.Visible)
            {
                GB_Ekle.Visible = false;
            }

            if (!GB_Silme.Visible)
            {
                GB_Silme.Visible = true;
            }
        }
    }
}
