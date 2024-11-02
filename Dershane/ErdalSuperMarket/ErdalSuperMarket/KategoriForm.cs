using ErdalSuperMarket.Model;
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
    public partial class Kategoriler : Form
    {
        EHupifeyStoreDBEntities DB =  new EHupifeyStoreDBEntities();
        int ID;

        public Kategoriler()
        {
            InitializeComponent();
        }

        private void Kategoriler_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Doldur();
        }

        private void BTN_KategoriEkle_Click(object sender, EventArgs e)
        {
            Categories c = new Categories();
            c.Name = TB_Isim.Text;
            c.IsDeleted = false;

            try
            {
                DB.Categories.Add(c);
                DB.SaveChanges();
                Doldur();
                MessageBox.Show($"Kategori {c.ID}. Sıra İle Başarıyla EKlenmiştir");
                TB_Isim.Text = "";
            }
            catch
            {
                MessageBox.Show("Bir Şeyler Ters Gitti");
            }
        }

        private void Doldur()
        {
            List<Categories> categories = DB.Categories.ToList();
            dataGridView1.DataSource = categories;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[0].Width = 50;
            for (int i = 1; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(dataGridView1, e.Location);

                int Index = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                ID = Convert.ToInt32(dataGridView1.Rows[Index].Cells["ID"].Value);
            }
        }

        private void TSMI_Duzenle_Click(object sender, EventArgs e)
        {
            Categories c = DB.Categories.Find(ID);
            TB_ID.Text = ID.ToString();
            TB_Isim.Text = c.Name;
            BTN_Edit.Visible = true;
        }

        private void BTN_Edit_Click(object sender, EventArgs e)
        {
            Categories c = DB.Categories.Find(ID);
            c.Name = TB_Isim.Text;
            DB.SaveChanges();
            TB_ID.Text = null;
            TB_Isim.Text = null;
            Doldur();
            BTN_Edit.Visible = false;
        }
    }
}
