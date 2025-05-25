using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerhabaAdo.NET_AED_
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Kategori sayısını çekelim 
            //1 Bağlantı 
            //SqlConnection baglanti = new SqlConnection();//connetcion con olarak kısaca isimlendirilir.
            //2 bağlantı yolu (Connection String )
            // baglanti.ConnectionString = "Data Source = .\\SQLEXPRESS ; Initial Catalog=NORTHWND; Integrated Security=True";
            //3Komut
            //SqlCommand komut = new SqlCommand();//Comand kısaca cmd olarak isimlendirilir.
            //komut.Connection = baglanti;
            //4 Komut Metni
            //komut.CommandText = "SELECT COUNT(*) FROM Categories";
            //5 Bağlantıyı aç
            //baglanti.Open();
            //6 Sorgu Çalıştır
            //Sorgudan geriye tek hücre dönecek ise ExecuteScalar
            //int ADET = Convert.ToInt32(komut.ExecuteScalar());
            //7 bağlantıyı kapat
            //baglanti.Close();
            //Console.WriteLine("Kategori Sayısı = " + ADET);
            #endregion

            #region Kategori listesini alalım
           // 1 Bağlantı
            SqlConnection baglanti = new SqlConnection();//connetcion con olarak kısaca isimlendirilir.
            //2 bağlantı yolu (Connection String )
            baglanti.ConnectionString = @"Data Source = .\SQLEXPRESS ; Initial Catalog=NORTHWND; Integrated Security=True";
            //3Komut
            SqlCommand komut = new SqlCommand();//Comand kısaca cmd olarak isimlendirilir.
            komut.Connection = baglanti;
            //4 Komut Metni
            komut.CommandText = "SELECT CategoryID,Description, CategoryName FROM Categories";
            //5 Bağlantıyı aç
            baglanti.Open();
            //6 Sorgu Çalıştır
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string aciklama = reader.GetString(1);
                string isim = reader.GetString(2);
                Console.WriteLine($"{id} - {isim} - {aciklama}.");
            }
            //7 bağlantıyı kapat
            baglanti.Close();

            #endregion

            #region Kategori ekleyelim
            //Console.WriteLine("Lütfen kategori adı giriniz");
            //string isim = Console.ReadLine();
            //Console.WriteLine("Lütfen kategori açıklaması giriniz");
            //string aciklama = Console.ReadLine();
            ////1 Bağlantı
            //SqlConnection baglanti = new SqlConnection();//connetcion con olarak kısaca isimlendirilir.
            // //2 bağlantı yolu(Connection String)
            //baglanti.ConnectionString = "Data Source = .\\SQLEXPRESS ; Initial Catalog=NORTHWND; " +
            //   "Integrated Security=True";
            //// 3Komut
            //SqlCommand komut = new SqlCommand();//Comand kısaca cmd olarak isimlendirilir.
            //komut.Connection = baglanti;
            //// 4 Komut Metni
            //komut.CommandText = $"INSERT INTO Categories(CategoryName,Description)VALUES ('{isim}','{aciklama}')";
            ////5 bağlantıyı aç
            //baglanti.Open();
            ////6 sorgu çalıştır
            //komut.ExecuteNonQuery();
            ////7 bağlantı kapat
            //baglanti.Close();

            #endregion
        }
    }
}
