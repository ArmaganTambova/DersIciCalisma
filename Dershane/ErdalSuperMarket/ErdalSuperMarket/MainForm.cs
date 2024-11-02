using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErdalSuperMarket
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void TSMI_KategoriIslemleri_Click(object sender, EventArgs e)
        {
            Kategoriler kform = new Kategoriler();
            kform.MdiParent = this;
            kform.Show();
        }

        private void TSMI_TumUrunler_Click(object sender, EventArgs e)
        {
            ProductForm pform = new ProductForm();
            pform.MdiParent = this;
            pform.Show();
        }
    }
}
