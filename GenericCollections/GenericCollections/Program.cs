using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Nedir?
            /*
             Jenerik Koleksiyonlar
             * "ArrayList" Koleksiyonunun Jenerik Karşılığıdır
             * "ArrayList"lerin Sahip Olduğu Tüm Metotlara Sahiptir
             * Jeneriklik İle Birlikte Tür Güvenliği Tam Anlamıyla Sağlanır
             * Tanımlarken "ArrayList" Değil "List" Kullanılacaktır
             * Jenerik Tür Eklemeyi Unutmayınız
            */
            #endregion

            #region Tanımlama ve Kullanım
            //List<int> Sayilar = new List<int>();
            //// "integer" Türünde Değer Alan Jenerik Koleksiyon Tanımlaması

            //Sayilar.Add(45);

            ////Sayilar.Add("Murtaza"); // "Sayilar" Koleksiyonu Sadece "integer" Türünde Veri Alabilir

            //Sayilar.AddRange(new int[] { -5, 4, 78, 13, 12, 21}); // Dizi Olarak Çoklu Eleme Yapılabilir

            //Sayilar.Insert(3, 70); // 3. Index'e 70 Değerini Ekle


            ////for (int i = 0; i < Sayilar.Count; i++)
            ////{
            ////    Console.WriteLine(Sayilar[i]);
            ////}

            //// "foreach"
            //// "foreach" Sadece Dizi (Array) Ve Koleksiyon (Collections)larda Kullanılabilir
            //foreach (int Eleman in Sayilar) // "Sayilar" Koleksiyonu İçindeki Her Eleman "Eleman" İsmiyle Açılacaktır
            //{
            //    Console.WriteLine(Eleman);
            //}
            #endregion

            #region Nesnelerle Kullanım
            //List<Ogrenciler> ogrenciler = new List<Ogrenciler>();
            //// "Ogrenci" Sınıfından Nesne Alabilen Generic Collections

            //Ogrenciler Ogr1 = new Ogrenciler() {Isim = "Armağan", Soyisim = "Tambova", Sinif = "10/D", No = 517 };
            //ogrenciler.Add(Ogr1);

            //Ogrenciler Ogr2 = new Ogrenciler() { Isim = "Burhan Kaan", Soyisim = "Aydıngör", Sinif = "10/D", No = 514};
            //ogrenciler.Add(Ogr2);

            //Ogrenciler Ogr3 = new Ogrenciler() { Isim = "Alperen", Soyisim = "Fidan", Sinif = "10/D", No = 508};
            //ogrenciler.Add(Ogr3);

            //foreach (Ogrenciler Item in ogrenciler)
            //{
            //    Console.WriteLine($"{Item.No} {Item.Isim} {Item.Soyisim} {Item.Sinif}");
            //}
            #endregion
        }
    }
}
