using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormIcerisindenFormAcmakVeMDIIslemleri
{
    public partial class IlkForm : Form
    {
        public IlkForm()
        {
            InitializeComponent();
        }

        private void BTN_FormAc_Click(object sender, EventArgs e)
        {
            BilgiFormu bilgiFormu = new BilgiFormu();
            bilgiFormu.Show();
        }

        private void BTN_DialogPenceresiOlarakAc_Click(object sender, EventArgs e)
        {
            BilgiFormu bilgiFormu = new BilgiFormu();
            bilgiFormu.ShowDialog();
        }

        private void BTN_BirTaneAc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MDI Kullan", "Dikkat!");
        }
    }
}
