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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BTN_ChieldFormAc_Click(object sender, EventArgs e)
        {
            Form[] cocuklar = this.MdiChildren;

            bool VarMi = false;

            for (int i = 0; i < cocuklar.Length; i++)
            {
                if (cocuklar[i].GetType() == typeof(BilgiFormu))
                {
                    VarMi = true;
                    cocuklar[i].Activate();
                }
            }

            if (!VarMi)
            {
                BilgiFormu ikinciBilgiFormu = new BilgiFormu();
                ikinciBilgiFormu.MdiParent = this;
                ikinciBilgiFormu.Show();
            }
        }

        private void BTN_ChieldFormAcIki_Click(object sender, EventArgs e)
        {
            Form[] cocuklar = this.MdiChildren;

            bool VarMi = false;

            for (int i = 0; i < cocuklar.Length; i++)
            {
                if (cocuklar[i].GetType() == typeof(IkinciBilgiFormu))
                {
                    VarMi = true;
                    cocuklar[i].Activate();
                }
            }

            if (!VarMi)
            {
                IkinciBilgiFormu ikinciBilgiFormu = new IkinciBilgiFormu();
                ikinciBilgiFormu.MdiParent = this;
                ikinciBilgiFormu.Show();
            }
        }
    }
}
