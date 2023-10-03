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

            int sayac = 0;

            while (sayac < 10) // While'nin Koşul Parantezleri İçerisindeki Değer Her Zaman "bool" Veri Üretmelidir
            {
                // While'nin Koşul Parantezleri İçerisindeki Değer "true" Olduğu Sürece Bu Yaşam Alanı Çalışır
                sayac++;
                Console.WriteLine(sayac);
            }
        }
    }
}
