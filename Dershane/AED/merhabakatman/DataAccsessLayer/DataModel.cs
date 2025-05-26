using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer
{
    public class DataModel
    {
        SqlConnection con; SqlCommand cmd;
        public DataModel()
        {
            con = new SqlConnection(ConnecionStrings.ConStrLocal);
            cmd = new SqlCommand();
            cmd.Connection = con;
        }
        //#region Kategoriler Metodları
        //public List<Kategoriler> KategorilerListele()
        //{
        //    try
        //    {
        //        List<Kategoriler> Kategoriler = new List<Kategoriler>();
        //        cmd.CommandText = "SELECT CategoryID,CategoryName,Description FROM Categories";
        //        con.Open();
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            Kategoriler k = new Kategoriler();
        //            k.ID = reader.GetInt32(0);
        //            k.Isim = reader.GetString(1);
        //            k.Aciklama = reader.GetString(2);
        //            Kategoriler.Add(k);
        //        }
        //        return Kategoriler;
        //    }
        //    catch
        //    {

        //        return null;
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //}
        //public void KategorilerYazdır(List<Kategoriler> Kategorilerler)
        //{
        //    for (int i = 0; i < Kategorilerler.Count; i++)
        //    {
        //        Console.WriteLine($"{Kategorilerler[i].ID} - {Kategorilerler[i].Isim} - {Kategorilerler[i].Aciklama}");
        //    }
        //}
        //public bool KategorilerEkle(Kategoriler k)
        //{
        //    try
        //    {
        //        cmd.CommandText = "INSERT INTO Categories(CategoryName,Description) VALUES (@isim,@aciklama) ";
        //        cmd.Parameters.Clear();
        //        cmd.Parameters.AddWithValue("@isim", k.Isim);
        //        cmd.Parameters.AddWithValue("@aciklama", k.Aciklama);
        //        con.Open();
        //        cmd.ExecuteNonQuery();
        //        return true;
        //    }
        //    catch
        //    {

        //        return false;
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //}
        //public Kategoriler KategorilerGetir(int id)
        //{
        //    try
        //    {
        //        cmd.CommandText = "SELECT CategoryID,CategoryName,Description FROM Categories WHERE CategoryID=@id";
        //        cmd.Parameters.Clear();
        //        cmd.Parameters.AddWithValue("@id", id);
        //        con.Open();
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        Kategoriler k = new Kategoriler();
        //        while (reader.Read())
        //        {
        //            k.ID = reader.GetInt32(0);
        //            k.Isim = reader.GetString(1);
        //            k.Aciklama = reader.GetString(2);
        //        }
        //        return k;
        //    }
        //    catch
        //    {

        //        return null;
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //}
        //public bool KategorilerGuncelle(Kategoriler k)
        //{
        //    try
        //    {
        //        cmd.CommandText = "UPDATE Categories SET CategoryName = @isim,Description = @aciklama WHERE CategoryID = @id";
        //        cmd.Parameters.Clear();
        //        cmd.Parameters.AddWithValue("@isim", k.Isim);
        //        cmd.Parameters.AddWithValue("@aciklama", k.Aciklama);
        //        cmd.Parameters.AddWithValue("@id", k.ID);
        //        con.Open();
        //        cmd.ExecuteNonQuery();
        //        return true;
        //    }
        //    catch
        //    {

        //        return false;
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //}
        //#endregion

        #region Ürün Metotları

        public List<Urunler> UrunListele()
        {
            try
            {
                List<Urunler> Urunler = new List<Urunler>();
                cmd.CommandText = "SELECT P.ProductID,P.ProductName,P.SupplierID,S.CompanyName, " +
                    "P.CategoryID,C.CategoryName,P.UnitPrice,P.UnitsInStock " +
                    "FROM Products AS P JOIN Suppliers AS S ON P.SupplierID=S.SupplierID ," +
                    "JOIN Categories AS C ON P.CategoryID=C.CategoryID";
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Urunler u = new Urunler();
                    u.ID = reader.GetInt32(0);
                    u.Isim = reader.GetString(1);
                    u.TedarikciID = reader.GetInt32(2);
                    u.TedarikciSirket = reader.GetString(3);
                    u.KategoriID = reader.GetInt32(4);
                    u.KategoriIsim = reader.GetString(5);
                    u.Fiyat = reader.GetDecimal(6);
                    u.Stok = reader.GetInt16(7);
                    Urunler.Add(u);
                }
                return Urunler;

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

        public void UrunYazdir(List<Urunler> urunler)
        {
            for (int i = 0; i < urunler.Count; i++)
            {
                Console.WriteLine($"{urunler[i].ID} - {urunler[i].Isim} - {urunler[i].TedarikciSirket} - {urunler[i].KategoriIsim}"); 
                    
            }
        }
        #endregion

    }
}
