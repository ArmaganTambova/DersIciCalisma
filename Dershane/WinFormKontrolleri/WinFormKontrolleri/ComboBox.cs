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
    public partial class ComboBox : Form
    {
        public ComboBox()
        {
            InitializeComponent();
        }

        private void BTN_Getir_Click(object sender, EventArgs e)
        {
            LBL_Sonuc.Text = CB_Sehir.SelectedItem.ToString();
        }
    }
}
