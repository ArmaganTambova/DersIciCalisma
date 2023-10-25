using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Dizi (Array) Nedir?
            /*
             * Aynı Türden Verileri Bir Arada, Belirli Bir Sıra Numarası (Index) İle Kullanılmasını Sağlayan Yapıya Dizi (Array) Denir
             * Dizinin Eleman Sayısı Başlangıçta Belirtilmek Zorundadır
             * "0, 1, 2, 3, 4" Şeklinde Index Numaraları Artarak Gider
             * 10 Eleman Alabilen Bir Dizi Tanımlandığında RAM Üzerinde 10 Adet Veri Tutulacak Alan Açılır. Her Bir Alan Bir Değişken Olarak Düşünülebilir
            */
            #endregion


            #region Diziye Neden İhtiyaç Duyuyoruz?
            // Programımızda 10 Adet Sayı Tutulacaktır Ne Yaparız?

            //int Sayi1 = 0;
            //int Sayi2 = 0;
            //int Sayi3 = 0;
            //int Sayi4 = 0;
            //int Sayi5 = 0;
            //int Sayi6 = 0;
            //int Sayi7 = 0;
            //int Sayi8 = 0;
            //int Sayi9 = 0;
            //int Sayi10 = 0;

            // Verileri Bu Şekilde Tutmak Kullanışlı Değil. Yönetilmesi Mümkün Olmayan Bir Sistem Kurduk
            // Ayrıca Aynı Şekilde Hazırladığımız Sistemin Verilerini Konsola Yazdırmak İstediğimizde Döngü Kullanarak Yazdıramayız
            // Öyleyse Ne Yapmalıyız? Çözüm Aşağıdaki region'da
            #endregion

            #region Dizi Tanımlama ve Kullanımı - 1
            //int[] sayilar = new int[10];
            //// Şu Anda RAM Üzerinde 10 Adet Değişken Tanımladık

            //sayilar[0] = 123;
            //// "sayilar" Dizisinin 0 Indexli Elemanına 123 Sayısını Attık

            //sayilar[1] = 22;
            //sayilar[2] = 32;
            //sayilar[3] = 15;
            //sayilar[4] = 20;
            //sayilar[5] = 5;
            //sayilar[6] = 3;
            //sayilar[7] = -77;
            //sayilar[8] = 25;
            //sayilar[9] = 45;

            //// sayilar[10] = 5; Bu İşlem Yapılamaz. 10 Elemanlı Bir Dizinin 10. Index Numarası Olmaz

            //// Yukarıda Tanımlanan Dizinin Eleman Sayısını Consol'da Yazdırın
            //Console.WriteLine(sayilar.Length);
            //Console.WriteLine("*-*-*-*-*-*-*-*" + "\n");

            //// Yukarıda Tanımlanan Dizinin 3. Indexindeki Veriyi Konsola Yazdırınız
            //Console.WriteLine(sayilar[3]);
            //Console.WriteLine("*-*-*-*-*-*-*-*" + "\n");

            //// Dizinin Tüm Elemanlarını Yazdırınız
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}
            #endregion

            #region Dizi Tanımlama ve Kullanımı - 2
            //string[] isimler = {"Fadlihan", "Onur", "Yusuf", "Alperen Efe", "Poyraz", "Burhan", "Cemrenaz", "Armağan", "İbrahim", "Ceyhun", "Ekrem", "Ali", "Nisa"};

            //Console.WriteLine("İsimler Dizisindeki Eleman Sayısı = " + isimler.Length + "\n");
            //Console.WriteLine("İsimler:");
            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine(isimler[i]);
            //}
            #endregion


            int[] sayilar = {15, 45, 7, 16, 22, 81, 1, 13, 14, 58, 6, 4, 5, 36, -5};

            #region Yukarıdaki Dizideki Pozitif Sayıları Yazdırınız
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] > 0)
            //    {
            //        Console.WriteLine(sayilar[i]);
            //    }
            //}
            #endregion

            #region Yukarıdaki Dizideki Sayıların Ortalamasını Bulunuz
            //int Toplam = 0; int Deger = 0;

            //for (int i = Deger; i < sayilar.Length; i++)
            //{
            //    Toplam += sayilar[i];
            //    Deger++;
            //}

            //double Ortalama = (double)Toplam / Deger;
            //Console.WriteLine("Dizide " + Deger + " Adet Sayı Bulunmakta" + "\n" + "Bu Sayıların Ortalaması = " + Ortalama);
            #endregion

            // Ödev
            #region Yukarıdaki Dizideki Çift Sayıları Yazdırınız
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] % 2 == 0)
            //    {
            //        Console.WriteLine(sayilar[i]);
            //    }
            //}
            #endregion

            // Ödev
            #region Yukarıdaki Dizideki 50 Üstü Sayıları Yazdırınız
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] > 50)
            //    {
            //        Console.WriteLine(sayilar[i]);
            //    }
            //}
            #endregion

            // Ödev
            #region Yukarıdaki Dizideki 20 - 30 Arasındaki Sayıları Yazdırınız
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] >= 20 && sayilar[i] <= 30)
            //    {
            //        Console.WriteLine(sayilar[i]);
            //    }
            //}
            #endregion

            // Ödev
            #region Yukarıdaki Dizideki 3'ün Katı Olan Sayıları Yazdırınız
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] % 3 == 0)
            //    {
            //        Console.WriteLine(sayilar[i]);
            //    }
            //}
            #endregion

            // Ödev
            #region Yukarıdaki Dizideki Çift Sayıların Ortalamasını Bulunuz
            //int Deger = 0; int Toplam = 0;

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] % 2 == 0)
            //    {
            //        Toplam += sayilar[i];
            //        Deger++;
            //    }
            //}

            //double Ortalama = (double)Toplam / Deger;
            //Console.WriteLine("Dizideki Çift Sayıların Ortalaması = " + Ortalama);
            #endregion

            #region Alışveriş Listesi Oluşturmak
            //Console.WriteLine("Kaç Adet Ürün Gireceksiniz");
            //int UrunAdedi = Convert.ToInt32(Console.ReadLine());
            //Console.Clear();

            //string[] Liste = new string[UrunAdedi];

            //for (int i = 0; i < UrunAdedi; i++)
            //{
            //    if (i == UrunAdedi - 1)
            //    {
            //        Console.WriteLine("Ürün Adı Yazınız (Son Ürünü Ekliyorsunuz)");
            //        string UrunAdi = Console.ReadLine();
            //        Liste[i] = UrunAdi;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ürün Adı Yazınız");
            //        string UrunAdi = Console.ReadLine();
            //        Liste[i] = UrunAdi;
            //    }
            //}

            //Console.Clear();
            //Console.WriteLine("*+*+* Ürünler Listesi *+*+*");

            //for (int i = 0; i < Liste.Length; i++)
            //{
            //    Console.WriteLine(Liste[i]);
            //}
            #endregion
        }
    }
}
