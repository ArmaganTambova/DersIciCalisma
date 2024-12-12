using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriErisimKatmani
{
    public class VeriIslem
    {
        #region Tanımlama
        // Tüm Veritabanı CRUD İşlemleri Bu Sınıf Tarafından Gerçekleştirilecek
        // Bu Sınıf Bağlantı Nesnesi, Komut Nesnesi Ve Bağlantı Yolunun Tekrar Tekrar Yazılmasına Engel Olacak
        // Bu İşleme Yapıcı Metotlar (Constructor) İle Gerçekleştireceğiz
        #endregion

        SqlConnection baglanti;
        SqlCommand komut;

        public VeriIslem()
        {
            // Constructor = Sınıfın Nesnesi Oluştuğunda Otomatik Olarak Çalışan Metot

            baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=KoMat_Kutuphane; Integrated Security=True");
            komut = baglanti.CreateCommand();
        }

        #region Tür Metotları

        // Türler Eklemek
        public bool TurEkle(string TurIsim)
        {
            // Metoduma Parametre Olarak Veritabanındaki Türler Tablosunun İsim Kolonuna Eklemek İçin Kullanacağım Veri Olan TurIsim'i Tanımladım
            // Metot Gelen Veriyi Veritabanına Ekleyecek
            // Veri Eklenirken Hata Yakalama Yapısını Kullanacağız

            try
            {
                // Bu Yaşam Alanı İçerisindeki Kodları Çalıştırmayı Dene
                // Eğer Hata Oluşursa Hata Verme catch Kısmından Devam Et
                komut.CommandText = "INSERT INTO Turler(Isim) VALUES(@Isim)";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@Isim", TurIsim);

                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();

                return true; // Eğer Kodlar Buraya Kadar Çalışırsa, Hata Vermez İse Veri Eklenmiş Demektir. Bu Sebeple TurEkle Metodum Geriye true Döndürsün
            }
            catch
            {
                // try Kısmında Hata Oluşursa Bu Yaşam Alanından Devam Et
                return false;
                // Eğer catch Çalışırsa Ekleme İşlemi Başarısızdır. Dolayısıyla TurEkle Metodumuz Geriye fasle Verisini Döndürecek
            }
        }

        public bool TurEkleEntity(Tur t)
        {
            try
            {
                komut.CommandText = "INSERT INTO Turler(Isim) VALUES(@I)";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@I", t.Isim);
                baglanti.Open();
                komut.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                baglanti.Close();
                // Hata Olsada Olmasada Her Durumda Çalışır
            }
        }

        public List<Tur> TurListele()
        {
            List<Tur> turListesi = new List<Tur>(); // Boş Generic Collections Tanımladık

            try
            {
                komut.CommandText = "SELECT ID, Isim FROM Turler";
                komut.Parameters.Clear();
                baglanti.Open();
                
                SqlDataReader okuyucu = komut.ExecuteReader();

                while (okuyucu.Read())
                {
                    // Döngü Her Dönüşünde Yeni Bir Satırı Okuyoruz
                    // Bu Yüzden Her Satır Veriyi Bir Tur Nesnesi Olarak Oluşturacağız

                    Tur t = new Tur();

                    t.ID = okuyucu.GetInt32(0);
                    t.Isim = okuyucu.GetString(1);

                    turListesi.Add(t);

                    // Oluşan Her Nesneyi turListesi İsimli Generic Collentions'a Ekliyorum
                }

                return turListesi; // Bütün Listeyi Metodun Çağırdığı Noktaya Gönderdik
            }
            catch
            {
                return null; // Hata Oluşursa null Veri Döndürür
            }
            finally
            {
                baglanti.Close() ;
            }
        }
        #endregion

        public bool DilEkle(Dil d)
        {
            try
            {
                komut.CommandText = "INSERT INTO Diller(Dil) VALUES(@Isim)";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@Isim", d.Isim);
                baglanti.Open();
                komut.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                baglanti.Close() ;
            }
        }

        public List<Dil> DilListele()
        {
            List<Dil> turListesi = new List<Dil>();

            try
            {
                komut.CommandText = "SELECT ID, Dil FROM Diller";
                komut.Parameters.Clear();
                baglanti.Open();

                SqlDataReader okuyucu = komut.ExecuteReader();

                while (okuyucu.Read())
                {
                    Dil d = new Dil();

                    d.ID = okuyucu.GetInt32(0);
                    d.Isim = okuyucu.GetString(1);

                    turListesi.Add(d);
                }

                return turListesi;
            }
            catch
            {
                return null;
            }
            finally
            {
                baglanti.Close();
            }
        }

        public bool KitapEkle(Kitaplar k)
        {
            try
            {
                komut.CommandText = "INSERT INTO Kitaplar(SiraNo, TurID, YayinEviID, DilID, Isim, Barkod) VALUES(@SiraNo, @TurID, @YayinEviID, @DilID, @Isim, @Barkod)";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@SiraNo", k.SiraNo);
                komut.Parameters.AddWithValue("@TurID", k.TurID);
                komut.Parameters.AddWithValue("@YayinEviID", k.YayinEviID);
                komut.Parameters.AddWithValue("@DilID", k.DilID);
                komut.Parameters.AddWithValue("@Isim", k.Isim);
                komut.Parameters.AddWithValue("@Barkod", k.Barkod);
                baglanti.Open();
                komut.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                baglanti.Close();
            }
        }

        public List<Kitaplar> KitapListele()
        {
            List<Kitaplar> turListesi = new List<Kitaplar>();

            try
            {
                komut.CommandText = "SELECT ID, SiraNo, TurID, YayinEviID, DilID, Isim, Barkod FROM Kitaplar";
                komut.Parameters.Clear();
                baglanti.Open();

                SqlDataReader okuyucu = komut.ExecuteReader();

                while (okuyucu.Read())
                {
                    Kitaplar k = new Kitaplar();

                    k.ID = okuyucu.GetInt32(0);
                    k.SiraNo = okuyucu.GetInt16(1);
                    k.TurID = okuyucu.GetInt32(2);
                    k.YayinEviID = okuyucu.GetInt32(3);
                    k.DilID = okuyucu.GetInt32(4);
                    k.Isim = okuyucu.GetString(5);
                    k.Barkod = okuyucu.GetString(6);

                    turListesi.Add(k);
                }

                return turListesi;
            }
            catch
            {
                return null;
            }
            finally
            {
                baglanti.Close();
            }
        }

        public bool YayinEviEkle(YayinEvi y)
        {
            try
            {
                komut.CommandText = "INSERT INTO YayinEvleri(Isim) VALUES(@Isim)";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@Isim", y.Isim);
                baglanti.Open();
                komut.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                baglanti.Close();
            }
        }

        public List<YayinEvi> YayinEviListele()
        {
            List<YayinEvi> turListesi = new List<YayinEvi>();

            try
            {
                komut.CommandText = "SELECT ID, Isim FROM YayinEvleri";
                komut.Parameters.Clear();
                baglanti.Open();

                SqlDataReader okuyucu = komut.ExecuteReader();

                while (okuyucu.Read())
                {
                    YayinEvi y = new YayinEvi();

                    y.ID = okuyucu.GetInt32(0);
                    y.Isim = okuyucu.GetString(1);

                    turListesi.Add(y);
                }

                return turListesi;
            }
            catch
            {
                return null;
            }
            finally
            {
                baglanti.Close();
            }
        }

        public bool YazarEkle(Yazar y)
        {
            try
            {
                komut.CommandText = "INSERT INTO Yazarlar(Isim, SoyIsim) VALUES(@Isim, @SoyIsim)";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@Isim", y.Isim);
                komut.Parameters.AddWithValue("@SoyIsim", y.SoyIsim);
                baglanti.Open();
                komut.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                baglanti.Close();
            }
        }

        public List<Yazar> YazarListele()
        {
            List<Yazar> turListesi = new List<Yazar>();

            try
            {
                komut.CommandText = "SELECT ID, Isim, SoyIsim FROM Yazarlar";
                komut.Parameters.Clear();
                baglanti.Open();

                SqlDataReader okuyucu = komut.ExecuteReader();

                while (okuyucu.Read())
                {
                    Yazar y = new Yazar();

                    y.ID = okuyucu.GetInt32(0);
                    y.Isim = okuyucu.GetString(1);
                    y.SoyIsim = okuyucu.GetString(2);

                    turListesi.Add(y);
                }

                return turListesi;
            }
            catch
            {
                return null;
            }
            finally
            {
                baglanti.Close();
            }
        }

        public bool KitapYazarlarEkle(KitapYazarlar ky)
        {
            try
            {
                komut.CommandText = "INSERT INTO KitapYazarlar(KitapID, YazarID) VALUES(@KitapID, @YazarID)";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@KitapID", ky.KitapID);
                komut.Parameters.AddWithValue("@YazarID", ky.YazarID);
                baglanti.Open();
                komut.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                baglanti.Close();
            }
        }

        public List<KitapYazarlar> KitapYazarlarListele()
        {
            List<KitapYazarlar> turListesi = new List<KitapYazarlar>();

            try
            {
                komut.CommandText = "SELECT KitapID, YazarID FROM KitapYazarlar";
                komut.Parameters.Clear();
                baglanti.Open();

                SqlDataReader okuyucu = komut.ExecuteReader();

                while (okuyucu.Read())
                {
                    KitapYazarlar ky = new KitapYazarlar();

                    ky.KitapID = okuyucu.GetInt32(0);
                    ky.YazarID = okuyucu.GetInt32(1);

                    turListesi.Add(ky);
                }

                return turListesi;
            }
            catch
            {
                return null;
            }
            finally
            {
                baglanti.Close();
            }
        }

        public bool KiralamaEkle(Kiralamalar k)
        {
            try
            {
                komut.CommandText = "INSERT INTO Kiralamalar(KitapID, KiralamaTarihi, TeslimTarihi, Aciklamalar) VALUES(@KitapID, @KiralamaTarihi, @TeslimTarihi, @Aciklamalar)";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@KitapID", k.KitapID);
                komut.Parameters.AddWithValue("@KiralamaTarihi", k.KiralamaTarihi);
                komut.Parameters.AddWithValue("@TeslimTarihi", k.TeslimTarihi);
                komut.Parameters.AddWithValue("@Aciklamalar", k.Aciklamalar);
                baglanti.Open();
                komut.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                baglanti.Close();
            }
        }

        public List<Kiralamalar> KiralamaListele()
        {
            List<Kiralamalar> turListesi = new List<Kiralamalar>();

            try
            {
                komut.CommandText = "SELECT ID, KitapID, KiralamaTarihi, TeslimTarihi, Aciklamalar FROM Kiralamalar";
                komut.Parameters.Clear();
                baglanti.Open();

                SqlDataReader okuyucu = komut.ExecuteReader();

                while (okuyucu.Read())
                {
                    Kiralamalar k = new Kiralamalar();

                    k.ID = okuyucu.GetInt32(0);
                    k.KitapID = okuyucu.GetInt32(1);
                    k.KiralamaTarihi = okuyucu.GetDateTime(2);
                    k.TeslimTarihi = okuyucu.GetDateTime(3);
                    k.Aciklamalar = okuyucu.GetString(4);
                    k.KiralamaTarihi = Convert.ToDateTime(k.KiralamaTarihi.ToString("yyyy-MM-dd HH:mm:ss"));
                    k.TeslimTarihi = Convert.ToDateTime(k.TeslimTarihi.ToString("yyyy-MM-dd HH:mm:ss"));

                    turListesi.Add(k);
                }

                return turListesi;
            }
            catch
            {
                return null;
            }
            finally
            {
                baglanti.Close();
            }
        }

        public bool TurGuncelle(Tur t)
        {
            try
            {
                komut.CommandText = "UPDATE Diller SET Isim = @Isim WHERE ID = @ID";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@Isim", t.Isim);
                komut.Parameters.AddWithValue("@ID", t.ID);
                baglanti.Open();
                komut.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                baglanti.Close();
            }
        }

        public bool DilGuncelle(Dil d)
        {
            try
            {
                komut.CommandText = "UPDATE Diller SET Dil = @Dil WHERE ID = @ID";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@Dil", d.Isim);
                komut.Parameters.AddWithValue("@ID", d.ID);
                baglanti.Open();
                komut.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                baglanti.Close();
            }
        }

        public bool YazarGuncelle(Yazar y)
        {
            try
            {
                komut.CommandText = "UPDATE Yazarlar SET Isim = @Isim, SoyIsim = @SoyIsim WHERE ID = @ID";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@Isim", y.Isim);
                komut.Parameters.AddWithValue("@SoyIsim", y.SoyIsim);
                komut.Parameters.AddWithValue("@ID", y.ID);
                baglanti.Open();
                komut.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                baglanti.Close();
            }
        }

        public bool YayinEviGuncelle(YayinEvi y)
        {
            try
            {
                komut.CommandText = "UPDATE YayinEvleri SET Isim = @Isim WHERE ID = @ID";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@Isim", y.Isim);
                komut.Parameters.AddWithValue("@ID", y.ID);
                baglanti.Open();
                komut.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                baglanti.Close();
            }
        }

        public bool KitaplarGuncelle(Kitaplar k)
        {
            try
            {
                komut.CommandText = "UPDATE Kitaplar SET SiraNo = @SiraNo, TurID = @TurID, YayinEviID = @YayinEviID, DilID = @DilID, Isim = @Isim, Barkod = @Barkod WHERE ID = @ID";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@SiraNo", k.SiraNo);
                komut.Parameters.AddWithValue("@TurID", k.TurID);
                komut.Parameters.AddWithValue("@YayinEviID", k.YayinEviID);
                komut.Parameters.AddWithValue("@DilID", k.DilID);
                komut.Parameters.AddWithValue("@Isim", k.Isim);
                komut.Parameters.AddWithValue("@Barkod", k.Barkod);
                komut.Parameters.AddWithValue("@ID", k.ID);
                baglanti.Open();
                komut.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                baglanti.Close();
            }
        }

        public bool TurlerSil(int ID)
        {
            try
            {
                komut.CommandText = "DELETE FROM Turler WHERE ID = @ID";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@ID", ID);
                baglanti.Open();
                komut.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                baglanti.Close();
            }
        }

        public bool DilSil(int ID)
        {
            try
            {
                komut.CommandText = "DELETE FROM Diller WHERE ID = @ID";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@ID", ID);
                baglanti.Open();
                komut.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                baglanti.Close();
            }
        }

        public bool YazarSil(int ID)
        {
            try
            {
                komut.CommandText = "DELETE FROM Yazarlar WHERE ID = @ID";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@ID", ID);
                baglanti.Open();
                komut.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                baglanti.Close();
            }
        }

        public bool YayinEviSil(int ID)
        {
            try
            {
                komut.CommandText = "DELETE FROM YayinEvleri WHERE ID = @ID";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@ID", ID);
                baglanti.Open();
                komut.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                baglanti.Close();
            }
        }

        public bool KitaplarSil(int ID)
        {
            try
            {
                komut.CommandText = "DELETE FROM Kitaplar WHERE ID = @ID";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@ID", ID);
                baglanti.Open();
                komut.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                baglanti.Close();
            }
        }

        public bool KiralamaSil(int ID)
        {
            try
            {
                komut.CommandText = "DELETE FROM Kiralamalar WHERE ID = @ID";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@ID", ID);
                baglanti.Open();
                komut.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                baglanti.Close();
            }
        }
    }
}
