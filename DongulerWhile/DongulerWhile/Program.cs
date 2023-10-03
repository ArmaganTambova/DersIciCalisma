using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongulerWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region While Döngüsünü Hatırlayalım
            // Bir Başlangıç Değerinden "bit" Son Değerine Kadar Belirli Bir Artış Miktarıyla Bir İşlemin Birden Çok Kez Tekrarlanmasını Sağlayan Yapılardır

            //  Başlangıç
            //  Koşul
            //  İterasyon

            // 1 ile 10 Arasındaki Sayıları Yazdırın

            //Console.WriteLine("1");
            //Console.WriteLine("2");
            //Console.WriteLine("3");
            //Console.WriteLine("4");
            //Console.WriteLine("5");
            //Console.WriteLine("6");
            //Console.WriteLine("7");
            //Console.WriteLine("8");
            //Console.WriteLine("9");
            //Console.WriteLine("10");

            //

            //int sayac = 0;

            //while (sayac < 10) // While'nin Koşul Parantezleri İçerisindeki Değer Her Zaman "bool" Veri Üretmelidir
            //{
            //    // While'nin Koşul Parantezleri İçerisindeki Değer "true" Olduğu Sürece Bu Yaşam Alanı Çalışır
            //    sayac++;
            //    Console.WriteLine(sayac);
            //}
            #endregion


            //Ödevler
            #region 0 - 100 Arasındaki Sayıları Yazdır
            //int sayac = 0;

            //while (sayac < 100)
            //{
            //    sayac++;
            //    Console.WriteLine(sayac);
            //}
            #endregion

            #region 20 - 50 Arasındaki Sayıları Yazdır
            //int sayac = 19;

            //while (sayac < 50)
            //{
            //    sayac++;
            //    Console.WriteLine(sayac);
            //}
            #endregion

            #region 0 - 100 Arasındaki Çift Sayıları Yazdır
            //int sayac = 0;

            //while (sayac <= 100)
            //{
            //    if (sayac % 2 == 0)
            //    {
            //        Console.WriteLine(sayac);
            //    }
            //    sayac++;
            //}
            #endregion

            #region Konsoldan Alınan 2 Sayı Arasındaki Tüm Çift Sayıları Yazdır
            //Console.WriteLine("Lütfen İlk Sayıyı Giriniz");
            //string strSayi1 = Console.ReadLine();

            //Console.WriteLine("Lütfen İkinci Sayıyı Giriniz");
            //string strSayi2 = Console.ReadLine();

            //int Sayi1 = Convert.ToInt32(strSayi1);
            //int Sayi2 = Convert.ToInt32(strSayi2);

            //if (Sayi1 > Sayi2)
            //{
            //    while (Sayi2 <= Sayi1)
            //    {
            //        if (Sayi2 % 2 == 0)
            //        {
            //            Console.WriteLine(Sayi2);
            //        }
            //        Sayi2++;
            //    }
            //}
            //else
            //{
            //    while (Sayi1 <= Sayi2)
            //    {
            //        if (Sayi1 % 2 == 0)
            //        {
            //            Console.WriteLine(Sayi1);
            //        }
            //        Sayi1++;
            //    }
            //}
            #endregion

            #region Konsoldan Alınan Sayının Farktöriyelini Hesapla
            //Console.WriteLine("Lütfen Faktöriyelini Hesaplamak İstediğiniz Sayıyı Giriniz");
            //int Sayi = Convert.ToInt32(Console.ReadLine());

            //long Faktoriyel = 1;
            //int i = 1;

            //while (i <= Sayi)
            //{
            //    Faktoriyel *= i;
            //    i++;
            //}
            //Console.WriteLine($"{Sayi}! = {Faktoriyel}");
            #endregion
        }
    }
}
