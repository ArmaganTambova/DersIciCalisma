using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KisiselBilgilerLabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Label LBL1 = new Label();
            LBL1.Text = "E-Posta = armagantambova@gmail.com";
            LBL1.Location = new Point(10, 70);
            LBL1.AutoSize = true;
            this.Controls.Add(LBL1);

            Label LBL2 = new Label();
            LBL2.Text = "Telefon: +90 536 401 08 26";
            LBL2.Location = new Point(10, 100);
            LBL2.AutoSize = true;
            this.Controls.Add(LBL2);
        }
    }
}
