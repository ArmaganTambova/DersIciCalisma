using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sozlu
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            VeriModel model = new VeriModel();

            DGWMain.DataSource = model.KatilimciListele();

            InitializeComponent();
        }
    }
}
