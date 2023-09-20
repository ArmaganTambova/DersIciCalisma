using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegiskenTanimlama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // YORUM SATIRI
            //  DeğişkenTürü DeğişkenAdı AtamaOperatörü BaşlangıçDeğeri SatırKapama



            // TAM SAYI DEĞİŞKENLERİ:

            //  byte 8 Bitlik Yer Kaplar, 0 ile 255 Arasında Değer Alabilir, byte Negatif Sayı Alamaz
            //ÖDEV: Neden byte Türü Maksimum 255 Alabilir İspatlayınız
            byte Sayi1 = 255;
            Console.WriteLine(Sayi1);

            //  short 16 Bitlik Yer Kaplar, ...
            short shrt = 300;
            Console.WriteLine(shrt);

            //  int 32 Bit Yer Kaplar, ...
            int tamsayi = 65454;
            Console.WriteLine(tamsayi);

            //  long 64 Bit Yer Kaplar, ...
            long lng = 65651;
            Console.WriteLine(lng);



            // ONDALIK SAYI DEĞİŞKENLERİ

            //  float 32 Bitlik Yer Kaplar, float'a Atılan Değerin Sonuna Mutlaka "f" Eklenmelidir
            float bilimsel = 45.2f;
            Console.WriteLine(bilimsel);

            //  double 64 Bitlik Yer Kaplar
            double ondalik = 45.3;
            Console.WriteLine(ondalik);

            //  decimal 128 Bitlik Yer Kaplar
            decimal parasal = 45.4m;
            Console.WriteLine(parasal);



            // METİNSEL DEĞİŞKENLERİ

            // char Sadece 1 Karakter Alabilir
            char karakter = 'A';
            Console.WriteLine(karakter);

            // string Bütün Metinleri Alır
            string metin = "Selam Ben Armağan";
            Console.WriteLine(metin);



            // KARAR DEĞİŞKENİ

            // bool Karar Değişkenidir
            bool tamammi = true;//false
            Console.WriteLine(tamammi);




            // KARAKTERİN SAYISAL DEĞERİNİ ALMA
            int sayisal = Convert.ToInt32(karakter);
            Console.WriteLine(sayisal);

            // Sayısal Değer Aralıkları **
            //   A - Z   65 - 90
            //   a - z   97 - 122
        }
    }
}
