using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veriErisimKatmani
{
    internal class veriModel
    {
        SqlConnection baglanti;
        SqlCommand komut;

        public veriModel()
        {
            baglanti = new SqlConnection(@"DataSource=.\SQLEXPRESS; InitialCatalog=KoMat_kutuphane_DB; Integrated Security=True");
            komut = baglanti.CreateCommand();
        }

        #region Dil Metodları

        public bool dilekle(Dil model)
        {
            try
            {
                komut.CommandText = "INSERT INTO Diller(dil) VALUES(@dil)";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@dil", model.dil);
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

        #endregion
    }
}
