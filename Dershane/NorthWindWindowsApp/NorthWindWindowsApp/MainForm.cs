using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthWindWindowsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void TSMI_KategoriIslemleri_Click(object sender, EventArgs e)
        {
            FormOpen(new CategoriesForm());
        }

        public void FormOpen(Form form)
        {
            Form[] Forms = this.MdiChildren;
            bool IsOpen = false;

            foreach (Form item in Forms)
            {
                if (item.GetType() == form.GetType())
                {
                    IsOpen = true;
                    item.Activate();
                }
            }

            if (!IsOpen)
            {
                form.MdiParent = this;
                form.WindowState = FormWindowState.Maximized;
                form.Show();
            }
        }
    }
}
