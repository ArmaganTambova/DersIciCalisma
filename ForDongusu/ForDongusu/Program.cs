using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tanımlama
            // While Düngüsünün Derli Toplu Halidir
            // While Temel Olarak Sonsuz Döngü Oluşturmak İçin Kullanılırken "For" Sınırlı ve Düzenli Döngüler İçin Kullanılır

            //for(int sayac = 0; sayac <= 10;  sayac++)
            //{
            //    Console.WriteLine(sayac);
            //}
            #endregion


            #region 0-100 Arasındaki Sayıları Yazdırma
            //for(int i = 0; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Konsol'a Adınızı 100 Defa Yazdır
            //Console.ForegroundColor = ConsoleColor.DarkMagenta;

            //for (int i = 0; i <= 100; i++)
            //{
            //    Console.WriteLine("Armağan");
            //}
            #endregion

            #region 100-0 Arasındaki Sayılar Yazdırma
            //for(int i = 100; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region 0-100 Arasındaki Çift Sayıları Yazdırınız
            //for(int i = 0; i <= 100; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion

            #region 0'dan Konsoldan Alınan Sayıya Kadar Olan Çift Sayıları Yazdırınız
            //Console.WriteLine("Lütfen Sayı Giriniz");
            //int Sayi = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("*-*-*-*-*-*-*-*-*-*");

            //for(int i = 0; i <= Sayi; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion

            #region 0-100 Arasında 4'e Bölünebilen Kaç Sayı Var
            //int Deger = 0;

            //for(int i = 0; i <= 100; i++)
            //{
            //    if(i % 4 == 0)
            //    {
            //        Deger++;
            //    }
            //}

            //Console.WriteLine(Deger);
            #endregion

            #region 0-100 Arasında 4'e Bölünen Kaç Sayı Var ve Toplamları Kaç
            //int Deger = 0;
            //int Toplam = 0;

            //for(int i = 0; i <= 100; i++)
            //{
            //    if(i % 4 == 0)
            //    {
            //        Deger++;
            //        Toplam += i;
            //    }
            //}

            //Console.WriteLine("Kaç Tane Sayı Var = " + Deger);
            //Console.WriteLine("Toplamları = " + Toplam);
            #endregion

            // Ödev
            #region Konsoldan Alınan 2 Sayı Arasında 5'e Kalansız Bölünen Sayı Adedi ve Toplamını Hesaplayan Program
            //Console.WriteLine("Lütfen İlk Sayıyı Giriniz");
            //int Sayi1 = Convert.ToInt32(Console.ReadLine());
            //// int Sayi1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen İkinci  Sayıyı Giriniz");
            //int Sayi2 = Convert.ToInt32(Console.ReadLine());
            //// int Sayi2 = int.Parse(Console.ReadLine());

            //int Deger = 0; int Toplam = 0; bool Kontrol = false;

            //if (Sayi1 < Sayi2)
            //{
            //    for (int i = Sayi1; i <= Sayi2; i++)
            //    {
            //        if (i % 5 == 0)
            //        {
            //            Toplam += i;
            //            Deger++;
            //        }
            //    }
            //}
            //else if (Sayi1 > Sayi2)
            //{
            //    for (int i = Sayi2; i <= Sayi1; i++)
            //    {
            //        if (i % 5 == 0)
            //        {
            //            Toplam += i;
            //            Deger++;
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Sayılar Eşit Olamaz");
            //    Kontrol = true;
            //}

            //if (!Kontrol)
            //{
            //    Console.WriteLine("Toplamları = " + Toplam + "\n" + "Adetleri = " + Deger);
            //}
            #endregion

            // Ödev
            #region Konsoldan Alınan 2 Sayının Arasındaki Tüm Sayıların Ortalamasını Hesaplayan Program
            //Console.WriteLine("Lütfen İlk Sayıyı Giriniz");
            //int Sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Lütfen İkinci Sayıyı Giriniz");
            //int Sayi2 = Convert.ToInt32(Console.ReadLine());

            //int Toplam = 0; int Sayac = 0; bool Kontrol = false;

            //if (Sayi1 < Sayi2)
            //{
            //    for (int i = Sayi1; i <= Sayi2; i++) 
            //    {
            //        Toplam += i;
            //        Sayac++;
            //    }
            //}
            //else if (Sayi2 < Sayi1)
            //{
            //    for (int i = Sayi2; i <= Sayi1; i++)
            //    {
            //        Toplam += i;
            //        Sayac++;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Sayılar Eşit Olamaz");
            //}

            //double Ortalama = (double)Toplam / Sayac;
            //Console.WriteLine("Aralıktaki Sayıların Ortalaması = " + Ortalama);
            #endregion

            // Ödev
            #region Konsoldan Alınan Basamak Değerinin Çarpım Tablosunu Yazdırınız
            //Console.WriteLine("Lütfen Sayıyı Giriniz");
            //int Deger = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(Deger + " x " + i + " = " + (Deger * i));
            //}
            #endregion

            #region Çarpım Tablosunun Üçler Basamağını Yazdırınız
            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine("3 x " + i + " = " + (3 * i));
            //}
            #endregion
        }
    }
}
