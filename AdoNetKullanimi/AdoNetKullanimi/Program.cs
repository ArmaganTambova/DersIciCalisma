using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Veritabanı Bağlantı Ve Komut Nesnelerini Oluşturmak İçin "using System.Data.SqlClient" namespace'i Eklenmelidir

            // NorthWind Veritabanından

            #region Kategori Sayısını Alalım
            //// 1) Bağlantı
            //SqlConnection baglanti = new SqlConnection();

            //// 2) Bağlantı Yolu
            ///*
            // Bağlantı İçin;
            // Hangi Server,
            // Hangi Server İçindeki Hangi Veritabanına,
            // Nasıl Bağlanıyorum
            //*/
            //// \'ın Özel Karakter Olma Durumunu String'in Başına @ Koyarak Ortadan Kaldırabiliriz
            //baglanti.ConnectionString = @"Data Source=DESKTOP-ES2GGHE\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True";

            //// 3) Komut
            //SqlCommand komut = new SqlCommand();
            //komut.Connection = baglanti; // Komut Yukarıda Oluşturulan Bağlantı Nesnesi İçerisinde Tanımlanan Bağlantı Yoluna Gönderilecek

            //// 4) Komut Metni
            //komut.CommandText = "SELECT COUNT(*) FROM Categories";

            //// 5) Bağlantı Aç
            //baglanti.Open();

            //// 6) Sorgu Çalıştır
            //int sayi = Convert.ToInt32(komut.ExecuteScalar());
            //// Eğer Sorgudan Geriye Tek Hücre Dönecek İse ExecuteScalar() Kullanılır

            //Console.WriteLine($"Kategori Sayısı = {sayi}");

            //// 7) Bağlantı Kapat
            //baglanti.Close();
            #endregion

            #region Ürün Sayısını Çekelim
            //SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-ES2GGHE\SQLEXPRESS; Initial Catalog=NORTHWND; Initial Catalog=NORTHWND; Integrated Security=True");

            //SqlCommand komut = baglanti.CreateCommand();

            //komut.CommandText = "SELECT COUNT(*) FROM Products";

            //baglanti.Open();

            //int sayi = Convert.ToInt32(komut.ExecuteScalar());

            //baglanti.Close();

            //Console.WriteLine($"Ürün Sayıları = {sayi}");
            #endregion

            #region Kayıtlı Kategorileri Listeleyelim
            //SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-ES2GGHE\SQLEXPRESS; Initial Catalog=NORTHWND; Initial Catalog=NORTHWND; Integrated Security=True");

            //SqlCommand komut = baglanti.CreateCommand();

            //komut.CommandText = "SELECT CategoryID, CategoryName, Description FROM Categories";

            //baglanti.Open();

            //// Yukarıdaki Sorguda Tablo Gelmesi Beklenir. Tablolu Veriler SqlDataReader İle Karşılanabilir

            //SqlDataReader okuyucu = komut.ExecuteReader();

            //// Eğer Sorgu Tablo Getirecekse, Sorguyu ExecuteReader() İle Çalıştırılır

            //// okuyucu.Read() = Okunmamış Satır Var İse True Döndür
            //while (okuyucu.Read())
            //{
            //    // Okuma İşlemi Satır Satır Gerçekleşecek
            //    // Her Satırı Kolon Index Numaralarına Göre Okuyoruz Ve SQL'deki Kolonun Türüne Uygun C# Türüne Döndürüyoruz
            //    // KOLON SIRALAMASI VERİTABANINDAKİNE GÖRE DEĞİL, SORGUDAKİ SIRAYA GÖRE ALINIR
            //    int ID = okuyucu.GetInt32(0); // Veritabanında CategoryID'nün Türü int, O Yüzden Burada Veriyi int'e Dönüştürüp Alıyoruz

            //    string Name = okuyucu.GetString(1);

            //    string Description = okuyucu.GetString(2);

            //    Console.WriteLine($"{ID} - {Name} - {Description}");
            //}

            //baglanti.Close();
            #endregion

            #region Kategori Ekleyelim
            //Console.WriteLine("Kategori Adı Giriniz");
            //string KategoriName = Console.ReadLine();

            //Console.WriteLine("Kategori Açıklaması Giriniz");
            //string KategoriDes = Console.ReadLine();

            //SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-ES2GGHE\SQLEXPRESS; Initial Catalog=NORTHWND; Initial Catalog=NORTHWND; Integrated Security=True");

            //SqlCommand komut = baglanti.CreateCommand();

            //komut.CommandText = "INSERT INTO Categories(CategoryName, Description) VALUES('" + KategoriName + "', '" + KategoriDes + "')";

            //baglanti.Open();

            //komut.ExecuteNonQuery();
            //// Eğer Sorgudan Geriye Veri Dönmeyecekse ExecuteNonQuery() Kullanılmalıdır

            //baglanti.Close();
            #endregion

            #region Deniz Ürünleri Kategorisindeki Ürünleri Listeliyelim
            //SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-ES2GGHE\SQLEXPRESS; Initial Catalog=NORTHWND; Initial Catalog=NORTHWND; Integrated Security=True");

            //SqlCommand komut = baglanti.CreateCommand();

            //Console.WriteLine("Ürünleri Listelenecek Kategori ID Giriniz");
            //string ID = Console.ReadLine();

            //komut.CommandText = "SELECT ProductID, ProductName, CategoryID, UnitPrice FROM Products WHERE CategoryID =" + ID;
            // Eğer Yukarıdaki Sorguya " ' ' OR 1=1 -- " Yazılırsa SQL Injection Gerçekleşmiş Olur

            //baglanti.Open();

            //SqlDataReader okuyucu = komut.ExecuteReader();

            //while (okuyucu.Read())
            //{
            //    int urunID = okuyucu.GetInt32(0);
            //    string urunName = okuyucu.GetString(1);
            //    int kategoriID = okuyucu.GetInt32(2);
            //    decimal Fiyat = okuyucu.GetDecimal(3);
            //    Console.WriteLine($"{urunID} - {urunName} - {kategoriID} - {Fiyat}");
            //}

            //baglanti.Close();

            // ' ' OR 1 = 1 / SQL INJECTION
            #endregion

            // SQL Injection'dan Korunmak İçin;
            // MUTLAKA Parametreli Sorgu Kullanılmalıdır

            #region Parametreli Sorgular
            //Console.WriteLine("Ürünleri Listelenecek Kategori ID Giriniz");
            //int ID = Convert.ToInt32(Console.ReadLine());

            //SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");

            //SqlCommand komut = baglanti.CreateCommand();

            //komut.CommandText = "SELECT ProductID, ProductName, CategoryID, UnitPrice FROM Products WHERE CategoryID=@murtaza";
            //komut.Parameters.AddWithValue("@murtaza", ID);
            //// Parametre Eklemenin Amacı SQL Injection'a Karşı Korunmaktır

            //baglanti.Open();

            //SqlDataReader okuyucu = komut.ExecuteReader();

            //while (okuyucu.Read())
            //{
            //    int ProID = okuyucu.GetInt32(0);
            //    string ProName = okuyucu.GetString(1);
            //    int CatID = okuyucu.GetInt32(2);
            //    decimal Price = okuyucu.GetDecimal(3);

            //    Console.WriteLine($"{ProID} - {ProName} - {CatID} - {Price} TL");
            //}

            //baglanti.Close();
            #endregion

            #region Kategori Güncelleyelim
            //// Öncelikle Kategorileri Listeleyelim Ki Kullanıcı Güncellemek İstediği Kategoriyi Seçebilsin

            //SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");

            //SqlCommand komut = baglanti.CreateCommand();

            //komut.CommandText = "SELECT CategoryID, CategoryName, Description FROM Categories";

            //baglanti.Open();

            //SqlDataReader okuyucu = komut.ExecuteReader();

            //while (okuyucu.Read())
            //{
            //    int CatID = okuyucu.GetInt32(0);
            //    string CatName = okuyucu.GetString(1);
            //    string Description = okuyucu.GetString(2);

            //    Console.WriteLine($"{CatID} - {CatName} - {Description}");
            //}

            //okuyucu.Close();

            //Console.WriteLine("Bilgilerini Güncellemek İstediğiniz Kategorinin Numarasını Giriniz");
            //int CatNo = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Kategori Adı Giriniz");
            //string CatNewName = Console.ReadLine();

            //Console.WriteLine("Açıklama Giriniz");
            //string NewDescription = Console.ReadLine();

            //komut.CommandText = "UPDATE Categories SET CategoryName = @C, Description = @D WHERE CategoryID = @ID";
            //komut.Parameters.AddWithValue("@ID", CatNo);
            //komut.Parameters.AddWithValue("@C", CatNewName);
            //komut.Parameters.AddWithValue("@D", NewDescription);
            //// Açık Olan Bağlantıyı Tekrardan Açmıyoruz

            //komut.ExecuteNonQuery();

            //Console.WriteLine("Kategori Başarıyla Güncellendi");

            //baglanti.Close();
            #endregion
        }
    }
}
