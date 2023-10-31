using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDiziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tanımlama
            // "string" Türü Değişken Olarak Tanımlansada Aynı Zamanda Bir Karakter Dizisidir
            //string Isim = "Armağan Tambova";

            //Console.WriteLine("Dizinin Eleman Sayısı = " + Isim.Length);
            //Console.WriteLine("Dizinin 2. Indexindeki Karakter = " + Isim[1]);

            // Dizinin Indexlerine Karakter Atanamaz(ReadOnly) Sadece Okunabilir Alanlardır
            //Isim[2] = "o";

            // Ancak Sona Ekleme Yapılabilir
            //Isim += " & Aptal Kaan";
            //Console.WriteLine(Isim);
            #endregion


            #region İsminizi Karakterlerini Tek Tek Alarak Yazdırınız
            //Console.WriteLine("İsminiz Kaç Karakterli");
            //int KarakterSayi = Convert.ToInt32(Console.ReadLine());

            //string Isim = "";

            //for (int i = 0; i < KarakterSayi; i++)
            //{
            //    Console.WriteLine((i + 1) + ". Karakteri Giriniz");
            //    Isim += Console.ReadLine();
            //}

            //Console.WriteLine("İsminiz = " + Isim);
            #endregion

            #region Metnin İçerisindeki Kaç Adet Boşluk Olduğunu Yazdır
            //Console.WriteLine("Lütfen Bir Metin Giriniz");
            //string Metin = Console.ReadLine();

            //int Sayac = 0;

            //for (int i = 0; i < Metin.Length; i++)
            //{
            //    if (Metin[i] == ' ')
            //    {
            //        Sayac++;
            //    }
            //}

            //if (Sayac > 0)
            //{
            //    Console.WriteLine($"Girdiğiniz Metinde {Sayac} Adet Boşluk Vardır");
            //}
            //else
            //{
            //    Console.WriteLine("Girdiğiniz Metinde Boşluk Bulunmamaktadır");
            //}
            #endregion

            #region Konsoldan Alınan Metnin İçerisinde A/a Karakteri Var Mı?
            //Console.WriteLine("Lütfen Bir Metin Giriniz");
            //string Metin = Console.ReadLine();

            //bool Kontrol = false;

            //for (int i = 0; i < Metin.Length; i++)
            //{
            //    if (Metin[i] == 'a' || Metin[i] == 'A')
            //    {
            //        Kontrol = true;
            //    }
            //}

            //if (Kontrol)
            //{
            //    Console.WriteLine("Girmiş Olduğunuz Metin İçerisinde a/A Karakteri Bulunmaktadır");
            //}
            //else
            //{
            //    Console.WriteLine("Girmiş Olduğunuz Metin İçerisinde a/A Karakteri Bulunmamaktadır");
            //}

            #region Alternatif
            //Console.WriteLine("Lütfen Bir Metin Giriniz");
            //string Metin = Console.ReadLine();

            //if (Metin.Contains('a') ||  Metin.Contains('A'))
            //{
            //    Console.WriteLine("Girmiş Olduğunuz Metin İçerisinde a/A Karakteri Bulunmaktadır");
            //}
            //else
            //{
            //    Console.WriteLine("Girmiş Olduğunuz Metin İçerisinde a/A Karakteri Bulunmamaktadır");
            //}
            #endregion

            #endregion

            #region Konsoldan Alınan Metnin Tüm Karakterlerini Büyük Olarak Yazdırınız

            #region Yol 1
            //Console.WriteLine("Lütfen Bir Metin Giriniz");
            //string Metin = Console.ReadLine();

            //string BuyukHarfli = Metin.ToUpper(); //ToLower

            //Console.WriteLine(BuyukHarfli);
            #endregion

            #region Yol 2
            //Console.WriteLine("Lütfen Bir Metin Giriniz");
            //string Metin = Console.ReadLine();

            //string BuyukMetin = "";

            //for (int i = 0; i < Metin.Length; i++)
            //{
            //    int Sayisal = (int)Metin[i];
            //    if (Sayisal >= 97 && Sayisal <= 122)
            //    {
            //        int BuyukSayisal = Sayisal - 32;
            //        BuyukMetin += (char)BuyukSayisal;
            //    }
            //    else
            //    {
            //        BuyukMetin += Metin[i];
            //    }
            //}

            //Console.WriteLine(BuyukMetin);
            #endregion

            #endregion

            #region İçi Dolu Çeyrek Baklava

            #endregion

            #region İçi Boş Çeyrek Baklava

            #endregion

            #region İçi Dolu Tam Baklava

            #endregion
        }
    }
}
