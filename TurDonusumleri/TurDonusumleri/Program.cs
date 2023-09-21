using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Farklı Amaçlar İçin Kullanılan Değişkenlerin, Amaçlarına Göre Farklı Türlerde Oluşturulması Gerektiğini Değişken Türleri Dersinde Öğrenmiştik
             * Örneğin: Metinsel Veriler İçin "string", Tamsayılar İçin "short, int, long" gibi türler kullanılır.
             
             * C# TypeSafe Bir Dil Olduğu İçin Türlerin Birbirine Dönüşümünde Önemlidir. Verileri Kafamıza Göre İstediğimiz Türe Atamayız
             
             * Tür Dönüştürmek İçin "Convert" Sııfının Uygun Metotlarını Kullanacağız
             
             // "short" Türüne Dönüştürmek
              * Convert.ToInt16()   => 16 Bitlik Tamsayı Türüne Döndür

             // "int" Türüne Dönüştürmek
              * Convert.ToInt32()   => 32 Bitlik Tamsayı Türüne Döndür

             // "long" Türüne Dönüştürmek
              * Convert.ToInt64()   => 64 Bitlik Tamsayı Türüne Döndür

             // "double" Türüne Dönüştürmek
              * Convert.ToDouble()  => "double" Türüne Döndür

             // "decimal" Türüne Dönüştürmek
              * Convert.ToDecimal() => "decimal" Türüne Döndür

             // "string" Türüne Dönüştürmek
              * Convert.ToString()  => "string" Türüne Döndür
            */

            //string sayi1 = "45";
            //string sayi2 = "15";

            //// "string" Veri Türü Sembollerden Oluşan Bir Yapıdır. Matematiksel Bir Anlam İfade Etmez
            //// Bu Sebeple "string" Veriler Arasında Kullanılan "+" Operatörü Matematiksel Olarak Toplama Yapmak Yerine Metinsel Olarak Yan Yana Ekler
            //Console.WriteLine(sayi1 + sayi2);

            //// Öylseyse "string" Veriler Matematiksel İşlemlerde Kullanılacak İse En Uygun Sayısal Türe Dönüştürülmelidir
            //short s1 = Convert.ToInt16(sayi1); // "sayi1" Değişkeni İçerisindeki Veriyi "short" Türüne Dönüştür
            //short s2 = Convert.ToInt16(sayi2); // "sayi2" Değişkeni İçerisindeki Veriyi "short" Türüne Dönüştür
            //Console.WriteLine(s1 + s2);

            #region Konsoldan Veri Almak
            //// Bilgisayara Inputlar Aracılığıyla Girilen Verinin Türü Her Zaman "string"dir

            ////Konsoldan Veri Almak İçin Girilen Komut "Console.ReadLine()"dır
            //Console.WriteLine("Lütfen Bir Sayı Giriniz");
            ////Konsoldan Aldığın Veriyi "strsayi" İsmindeki Değişkene At
            //string strsayi = Console.ReadLine();
            //int sayi = Convert.ToInt32(strsayi);
            //Console.WriteLine(sayi * 2);
            #endregion

            #region Konsoldan Alınan 2 Sayının Toplamını Yazdırınız
            //Console.WriteLine("Lütfen 1. Sayıyı Giriniz:");
            //string strsayi1 = Console.ReadLine();

            //Console.WriteLine("Lütfen 2. Sayıyı Giriniz:");
            //string strsayi2 = Console.ReadLine();

            //int sayi1 = Convert.ToInt32(strsayi1);
            //int sayi2 = Convert.ToInt32(strsayi2);

            //Console.WriteLine("Sayıların Toplamı:");
            //Console.WriteLine(sayi1 + sayi2);
            #endregion

            #region Konsoldan Alınan 2 Sayının Toplam, Fark, Çarpım, Bölüm Ve Mod'unu Yazdırınız
            //Console.WriteLine("Lütfen 1. Sayıyı Giriniz:");
            //string strsayi1 = Console.ReadLine();

            //Console.WriteLine("Lütfen 2. Sayıyı Giriniz:");
            //string strsayi2 = Console.ReadLine();

            //int sayi1 = Convert.ToInt32(strsayi1);
            //int sayi2 = Convert.ToInt32(strsayi2);
            //double DoubleSayi1 = Convert.ToDouble(strsayi1);
            //double DoubleSayi2 = Convert.ToDouble(strsayi2);

            //int Toplam = sayi1 + sayi2;
            //int Fark = sayi1 - sayi2;
            //int Carpim = sayi1 * sayi2;
            //double Bolum = DoubleSayi1 / DoubleSayi2;
            //double Mod = DoubleSayi1 % DoubleSayi2;

            //Console.Write("Toplam = ");
            //Console.WriteLine(Toplam);

            //Console.Write("Fark = ");
            //Console.WriteLine(Fark);

            //Console.Write("Çarpım = ");
            //Console.WriteLine(Carpim);

            //Console.Write("Bölüm = ");
            //Console.WriteLine(Bolum);

            //Console.Write("Mod = ");
            //Console.WriteLine(Mod);
            #endregion

            #region Konsoldan Alınan 2 Yazılı Notunun Ortalamasını Hesaplayınız
            //Console.WriteLine("Lütfen 1. Yazılı Notunuzu Giriniz:");
            //string strNot1 = Console.ReadLine();

            //Console.WriteLine("Lütfen 2. Yazılı Notunuzu Giriniz:");
            //string strNot2 = Console.ReadLine();

            //double Not1 = Convert.ToDouble(strNot1);
            //double Not2 = Convert.ToDouble(strNot2);
            //double Ortalama = (Not1 + Not2) / 2;
            //Console.WriteLine("Ortalamanız = " + Ortalama);
            #endregion
        }
    }
}