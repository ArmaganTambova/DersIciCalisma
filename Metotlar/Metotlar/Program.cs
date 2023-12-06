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

            #region Çırak Sınıfı
            //// "Cirak" Sınıfından Referans Alan Nesne Var Edildi
            //Cirak cirak = new Cirak();

            //// Program "SelamVer" İsimli Metot'dan Devam Eder
            //cirak.SelamVer();
            //// Metot İşlemi Bitince Bu Alandan Devam Eder

            //cirak.IsmeSelamVer(); // Parametre Alan Metotlar, Parametre Olarak Veri Gönderilmeden Çalışamazlar

            //cirak.IsmeSelamVer("Armağan");
            #endregion

            #region Matematik Sınıfı
            Matematik Mat = new Matematik();

            //
            Mat.İkiSayiToplam(18, 22);

            //
            Mat.SayininKaresiniYaz(12);

            //
            int SayininKaresi = Mat.SayininKaresiniDondur(12);
            Console.WriteLine($"Sayının Karesi = {SayininKaresi}");

            //
            Console.WriteLine("Lütfen Asallık Kontrolü Yapılacak Sayıyı Giriniz");
            int Sayi = Convert.ToInt32(Console.ReadLine());

            if (Mat.AsalKontrol(Sayi))
            {
                Console.WriteLine("Sayınız Asal Bir Sayıdır");
            }
            else
            {
                Console.WriteLine("Sayınız Asal Bir Sayı Değildir");
            }

            //
            Console.WriteLine("Lütfen Sayının Tabanını Giriniz");
            int Taban = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen Sayının Üssünü Giriniz");
            int Us = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Sayınızın Kuvveti = {Mat.KuvvetHesaplama(Taban, Us)}");

            //
            string IkizAsallar = Mat.IkizAsalKontrol();

            if (IkizAsallar != null)
            {
                Console.WriteLine(IkizAsallar);
            }
            else
            {
                Console.WriteLine("2-20 Sayıları Arasında İkizasal Sayı Bulunmamaktadır");
            }
            #endregion
        }
    }
}
