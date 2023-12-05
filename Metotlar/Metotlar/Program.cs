using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tanımlama
            // Metotlar / Functions
            // Ana Programı Küçük Parçalara Ayırarak İhtiyaç Duyduğunda Çalıştırmak Üzere Programladığımız Küçük Program Parçalarıdır
            // Metotlar Sınıfların İçerisinde Tanımlanabilir
            #endregion

            #region Çıkar Sınıfı
            // "Cirak" Sınıfından Referans Alan Nesne Var Edildi
            Cirak cirak = new Cirak();

            // Program "SelamVer" İsimli Metot'dan Devam Eder
            cirak.SelamVer();
            // Metot İşlemi Bitince Bu Alandan Devam Eder

            cirak.IsmeSelamVer(); // Parametre Alan Metotlar, Parametre Olarak Veri Gönderilmeden Çalışamazlar

            cirak.IsmeSelamVer("Armağan");
            #endregion
        }
    }
}
