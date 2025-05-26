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
    public partial class BilgiFormu : Form
    {
        public BilgiFormu()
        {
            InitializeComponent();
        }

        private void BTN_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
