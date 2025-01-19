using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class VeriModel
    {
        public void KatilimciEkle(Katilimci k)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=Sozlu; Integrated Security=True");
            SqlCommand komut = new SqlCommand();

            komut.CommandText = "INSERT INTO Sozlu(Isim, Soyisim, Yas, Telefon, Sehir) VALUES(@Isim, @Soyisim, @Yas, @Telefon, @Sehir)";
            komut.Parameters.Clear();
            komut.Parameters.AddWithValue("@Isim", k.Isim);
            komut.Parameters.AddWithValue("@Soyisim", k.Soyisim);
            komut.Parameters.AddWithValue("@Yas", k.Yas);
            komut.Parameters.AddWithValue("@Telefon", k.Telefon);
            komut.Parameters.AddWithValue("@Sehir", k.Sehir);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public void KatilimciSil(int ID)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=Sozlu; Integrated Security=True");
            SqlCommand komut = new SqlCommand();

            komut.CommandText = "DELETE FROM Katilimcilar WHERE ID = @ID";
            komut.Parameters.Clear();
            komut.Parameters.AddWithValue("@ID", ID);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public void KatilimciDuzenle(Katilimci k)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=Sozlu; Integrated Security=True");
            SqlCommand komut = new SqlCommand();

            komut.CommandText = "UPDATE Katilimcilar SET Isim = @Isim, Soyisim = @Soyisim, Yas = @Yas, Telefon = @Telefon, Sehir = @Sehir WHERE ID = @ID";
            komut.Parameters.Clear();
            komut.Parameters.AddWithValue("@Isim", k.Isim);
            komut.Parameters.AddWithValue("@Soyisim", k.Soyisim);
            komut.Parameters.AddWithValue("@Yas", k.Yas);
            komut.Parameters.AddWithValue("@Telefon", k.Telefon);
            komut.Parameters.AddWithValue("@Sehir", k.Sehir);
            komut.Parameters.AddWithValue("@ID", k.ID);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public DataTable KatilimciListele()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=Sozlu; Integrated Security=True");
            SqlCommand komut = new SqlCommand();

            komut.CommandText = "SELECT ID, Isim, Soyisim, Yas, Telefon, Sehir FROM Katilimcilar";
            komut.Parameters.Clear();

            baglanti.Open();
            SqlDataReader reader = komut.ExecuteReader();

            while (reader.Read())
            {
                int ID = reader.GetInt32(0);
                string Isim = reader.GetString(1);
                string Soyisim = reader.GetString(2);
                int Yas = reader.GetInt32(3);
                string Telefon = reader.GetString(4);
                string Sehir = reader.GetString(5);
            }

            baglanti.Close();

            DataTable table = new DataTable();

            table.Load(reader);

            return table;
        }
    }
}
