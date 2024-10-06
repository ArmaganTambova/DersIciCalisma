using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthWindWindowsApp
{
    public partial class CategoriesForm : Form
    {
        public CategoriesForm()
        {
            InitializeComponent();
            //DataGridTemelKonular();
            //DataGridDataBound();
            //DataGridDataTableDataBound();
            //DataGridCollectionToDataTableDataBound();
            UzunYolVeriTabaniBaglama();
        }

        public void DataGridTemelKonular()
        {
            dataGridView1.ColumnCount = 3; // 3 Kolondan Oluşsun
            dataGridView1.Columns[0].Name = "Kolon 1";
            dataGridView1.Columns[1].Name = "Kolon 2";
            dataGridView1.Columns[2].Name = "Kolon 3";

            dataGridView1.Columns[0].Width = 25;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.Rows.Add("1", "Murtaza", "Şuayipoğlu");
        }

        public void DataGridDataBound()
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "İsim";
            dataGridView1.Columns[2].Name = "Açıklama";

            dataGridView1.Columns[0].Width = 25;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            dataGridView1.Rows.Add("1", "Murtaza", "Şuayipoğlu");

            List<Kategori> kategoriler = new List<Kategori>();
            kategoriler.Add(new Kategori() { ID = 1, Isim = "Sebzeler", Aciklama = "Brokoli, Pırasa VB."});
            kategoriler.Add(new Kategori() { ID = 2, Isim = "Şarküteri", Aciklama = "Peynir, Zeytin VB." });
            kategoriler.Add(new Kategori() { ID = 3, Isim = "Giyim", Aciklama = "Ayakkabı, Bere VB." });

            foreach (Kategori item in kategoriler)
            {
                dataGridView1.Rows.Add(item.ID, item.Isim, item.Aciklama);
            }
        }

        public void DataGridDataTableDataBound()
        {
            DataTable DT = new DataTable();

            DT.Columns.Add("ID");
            DT.Columns.Add("İsim");
            DT.Columns.Add("Açıklama");

            DataRow ROW = DT.NewRow();
            ROW["ID"] = "1";
            ROW["İsim"] = "Sebzeler";
            ROW["Açıklama"] = "Açıklama İşte";
            DT.Rows.Add(ROW);

            dataGridView1.DataSource = DT;
        }

        public void DataGridCollectionToDataTableDataBound()
        {
            List<Kategori> kategoriler = new List<Kategori>();
            kategoriler.Add(new Kategori() { ID = 1, Isim = "Sebzeler", Aciklama = "Brokoli, Pırasa VB." });
            kategoriler.Add(new Kategori() { ID = 2, Isim = "Şarküteri", Aciklama = "Peynir, Zeytin VB." });
            kategoriler.Add(new Kategori() { ID = 3, Isim = "Giyim", Aciklama = "Ayakkabı, Bere VB." });

            BindingList<Kategori> Araci = new BindingList<Kategori>(kategoriler);
            dataGridView1.DataSource = new BindingSource(Araci, null);
        }

        public void UzunYolVeriTabaniBaglama()
        {
            SqlConnection Baglanti = new SqlConnection();
            Baglanti.ConnectionString = @"Data Source=DESKTOP-ES2GGHE\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True";
            SqlCommand Komut = new SqlCommand();
            Komut.Connection = Baglanti;
            Komut.CommandText = "SELECT CategoryID, CategoryName, Description FROM Categories";
            Baglanti.Open();

            SqlDataReader reader = Komut.ExecuteReader();
            List<Kategori> kategoriler = new List<Kategori>();
            while (reader.Read())
            {
                Kategori kategori = new Kategori();
                kategori.ID = reader.GetInt32(0);
                kategori.Isim = reader.GetString(1);
                kategori.Aciklama = reader.GetString(2);
                kategoriler.Add(kategori);
            }
            Baglanti.Close();

            BindingList<Kategori> Araci = new BindingList<Kategori>(kategoriler);
            dataGridView1.DataSource = new BindingSource(Araci, null);
        }
    }

    class Kategori
    {
        public int ID { get; set; }
        public string Isim { get; set; }
        public string Aciklama { get; set; }
    }
}
