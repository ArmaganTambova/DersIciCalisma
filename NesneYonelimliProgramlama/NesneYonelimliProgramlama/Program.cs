using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneYonelimliProgramlama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Nesne Yönelimli Programlama Nedir?
            /*
            Object Oriented Programming
            * Kısaca Her İşlevin Nesneler Olarak Soyutlandığı Programlama Yaklaşımıdır
            * Değişkenlerin Dağınık Bir Şekilde Tutulması Yerine Nesneler Aracılığıyla Tutulmasını Sağlar
            * Gerçek Hayatın Simülize Edilmesi Olarak Tanımlanabilir
            * Sınıf Olarak "Tanımlanan" Yapıların "Nesnelleştirilmesidir"
            */
            #endregion


            #region Öğrenci Sınıfı
            Ogrenci Ogr = new Ogrenci();
            Ogr.Isim = "Murtaza";
            Ogr.SoyIsım = "Şuayıpoğlu";
            Ogr.Sinif = "10/D";
            Ogr.Yas = 15;
            Console.WriteLine($"{Ogr.Isim} {Ogr.SoyIsım}");

            Ogrenci Ogr2 = new Ogrenci();
            Ogr2.Isim = "Hede";
            Ogr2.SoyIsım = "Hüde";
            Ogr2.Sinif = "10/D";
            Ogr2.Yas = 15;
            Console.WriteLine($"{Ogr2.Isim} {Ogr2.SoyIsım}");
            #endregion
        }
    }
    class Ogrenci
    {
        // Field
        public string Isim;
        public string SoyIsım;
        public string Sinif;
        public int Yas;
    }
}
