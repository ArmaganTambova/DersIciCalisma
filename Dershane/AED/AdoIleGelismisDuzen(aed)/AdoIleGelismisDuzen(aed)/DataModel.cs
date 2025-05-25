using AdoİleGelismisDüzen;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoİleGelismisDüzen
{
    public class DataModel
    {
        SqlConnection con; SqlCommand cmd;
        public DataModel()
        {
            con = new SqlConnection(@"Data Source = DESKTOP-ES2GGHE\SQLEXPRESS; Initial Catalog = NORTHWND; Integrated Security = True");
            cmd = con.CreateCommand();
        }
        #region Kategori Metodları
        public List<Kategori> KategoriListele()
        {
            try
            { 
                List<Kategori> Kategoriler = new List<Kategori>();
                cmd.CommandText = "SELECT CategoryID,CategoryName,Description FROM Categories";
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Kategori k = new Kategori();
                    k.ID = reader.GetInt32(0);
                    k.Isim = reader.GetString(1);
                    k.Aciklama = reader.GetString(2);
                    Kategoriler.Add(k);
                }
                return Kategoriler;
            }
            catch
            {

                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public void KategoriYazdır(List<Kategori> kategoriler)
        {
            for (int i = 0; i < kategoriler.Count; i++)
            {
                Console.WriteLine($"{kategoriler[i].ID} - {kategoriler[i].Isim} - {kategoriler[i].Aciklama}");
            }
        }
        public bool KategoriEkle(Kategori k)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Categories(CategoryName,Description) VALUES (@isim,@aciklama) ";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@isim", k.Isim);
                cmd.Parameters.AddWithValue("@aciklama", k.Aciklama);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {

                return false;
            }
            finally
            {
                con.Close();
            }
        }
        public Kategori KategoriGetir(int id)
        {
            try
            {
                cmd.CommandText = "SELECT CategoryID,CategoryName,Description FROM Categories WHERE CategoryID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Kategori k = new Kategori();
                while (reader.Read())
                {
                    k.ID = reader.GetInt32(0);
                    k.Isim = reader.GetString(1);
                    k.Aciklama = reader.GetString(2);
                }
                return k;
            }
            catch
            {

                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public bool KategoriGuncelle(Kategori k)
        {
            try
            {
                cmd.CommandText = "UPDATE Categories SET CategoryName = @isim,Description = @aciklama WHERE CategoryID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@isim", k.Isim);
                cmd.Parameters.AddWithValue("@aciklama", k.Aciklama);
                cmd.Parameters.AddWithValue("@id", k.ID);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {

                return false;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion
    }
}
