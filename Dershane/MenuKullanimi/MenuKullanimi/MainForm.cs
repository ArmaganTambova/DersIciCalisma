using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuKullanimi
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void TSMI_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TSMI_OgrenciKaydet_Click(object sender, EventArgs e)
        {
            Form[] openForms = this.MdiChildren;
            bool IsOpen = false;

            foreach (Form item in openForms)
            {
                if (item.GetType() == typeof(OgrenciKayitForm))
                {
                    item.Activate();
                    IsOpen = true;
                }
            }

            if (!IsOpen)
            {
                OgrenciKayitForm ogrenciKayitForm = new OgrenciKayitForm();
                ogrenciKayitForm.MdiParent = this;
                ogrenciKayitForm.WindowState = FormWindowState.Maximized;
                ogrenciKayitForm.Show();
            }
        }
    }
}
