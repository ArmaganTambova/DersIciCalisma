using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziVeNesne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Önemli Kural
            // Unutulmamalıdır Ki Her Sınıf Aynı Zamanda Bir Tür Oluşturur
            // Örneğin: İlaç Sınıfında Türerilen Nesnenin Türü İlaçtır
            #endregion

            // Öğrenci Sınıfından Nesne Alabilen Dizi
            Ogrenci[] Ogrenciler = new Ogrenci[5];
            // Ogrenciler Dizisinin Türü "Ogrenci"

            Ogrenci Ogr1 = new Ogrenci();
            Ogr1.Isim = "Armağan";
            Ogr1.Soyad = "Tambova";
            Ogr1.No = 517;
            Ogrenciler[0] = Ogr1;

            Ogrenci Ogr2 = new Ogrenci();
            Ogr2.Isim = "Burhan Kaan";
            Ogr2.Soyad = "Aydıngör";
            Ogr2.No = 514;
            Ogrenciler[1] = Ogr2;

            Ogrenci Ogr3 = new Ogrenci();
            Ogr3.Isim = "Poyraz";
            Ogr3.Soyad = "Salih";
            Ogr3.No = 510;
            Ogrenciler[2] = Ogr3;

            Ogrenci Ogr4 = new Ogrenci();
            Ogr4.Isim = "Cemrenaz";
            Ogr4.Soyad = "Türkanoğlu";
            Ogr4.No = 515;
            Ogrenciler[3] = Ogr4;

            Ogrenci Ogr5 = new Ogrenci();
            Ogr5.Isim = "Nisa Nur";
            Ogr5.Soyad = "Uçar";
            Ogr5.No = 522;
            Ogrenciler[4] = Ogr5;

            for (int i = 0; i < Ogrenciler.Length; i++)
            {
                Console.WriteLine($"{Ogrenciler[i].Isim} {Ogrenciler[i].Soyad} - {Ogrenciler[i].No}");
            }
        }
    }
}
