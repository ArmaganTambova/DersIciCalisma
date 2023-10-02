using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosullar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Koşulalr Program Akışında, Akış Kontrol Sistemleri Olarak Tanımlanabilir
             * "Tamam mı - Devam Mı" Gibi Akışa Yön Verilecek Alanlarda Kullanılır
             * Koşul Komutları "if", "else" ve "else if" tir
            */

            /*
             * if(Koşul Parantezi)
             {
                Yaşam Alanı Parantezi
                Koşul Sağlanıyor İse Bu Alanın İçerisindeki Kodlar Çalışır, Sağlanmıyor İse Bu Alanı Atlar
             }
             * "if" Komutunun Koşul Parantezi İçerisindeki İfade "boolean" Türünde Veri Üretmelidir
            */

            #region "if" Kullanımı
            //int sayi = 7;

            //if (sayi > 5)
            //{
            //    // "sayi" Değişkeni İçerisindeki Veri 5'ten Büyük İse "true" Sonuç Üretilir
            //    // "if" in Koşul Parantezi İçerisindeki Veri "true" İse Yaşamalanı Parantezleri İçerisindeki Kodlar Çalışacaktır

            //    Console.WriteLine("Sayı 5'ten Büyüktür");
            //}
            //// Eğer Koşul Sağlanmıyorsa Yaşam Alanını Atlayıp Buradan Devam Eder
            #endregion

            #region "if" "else" Kullanımı
            //// Koşulun Hem Sağlandığı Hemde Sağlanmadığı Durumlarda Yapılacak İşlemleri Tanımlayabilmek İçin Kullanılır

            //int sayi = 12;

            //if (sayi > 10)
            //{
            //    Console.WriteLine("Sayı 10'dan Büyüktür");
            //}
            //else
            //{
            //    // "else" in Koşul Parantezi Olmaz Çünkü "else" "if" in Koşulu Sağlanmadığında Çalışır
            //    // Yani "if" İçerisindeki Değer "false" ise "else" Mutlaka Çalışacaktır

            //    Console.WriteLine("Sayı 10'dan Küçüktür");
            //}
            //// "if" ve "else" Blokları Geçildikten Sonra Program Buradan Çalışmaya Devam Eder
            #endregion

            #region "if" "else if" "else" Kullanımı
            //// Birbirine Bağlı Birden Çok Koşul Kullanılmak İstendiğinde "if", "else if" ve "else" Kullanılır

            //int sayi = 10;

            //if (sayi > 10)
            //{
            //    Console.WriteLine("Sayı 10'dan Büyüktür");
            //}
            //else if (sayi == 10)
            //{
            //    // Eğer Üstteki Koşulum "false" İse Bunuda Kontrol Et
            //    // "Üstteki Değilse Eğer" Anlamında Kullanılır

            //    Console.WriteLine("Sayı 10'a Eşittir");
            //}
            //else
            //{
            //    // Üsttekilerin Hiçbiri "true" Döndürmez İse, Hiçbir Koşulum Sağlanmaz İse Burayı Çalıştırır
            //    // "if" "else if" lerdeki Koşulların Herhangi Biri "true" Sonuç Döndürse "else" Çalışmaz

            //    Console.WriteLine("Sayı 10'dan Küçüktür");
            #endregion


            #region Konsoldan Alınana Sayı Pozitif Mi, Negatif Mi?
            //Console.WriteLine("Lütfen Sayıyı Giriniz");

            //string strSayi = Console.ReadLine();
            //int Sayi = Convert.ToInt32(strSayi);

            //if (Sayi > 0)
            //{
            //    Console.WriteLine("Sayınız Pozitif (+)");
            //}
            //else if (Sayi < 0)
            //{
            //    Console.WriteLine("Sayınız Negatif (-)");
            //}
            //else
            //{
            //    Console.WriteLine("Sayınız Nötr");
            //}
            #endregion

            #region Konsoldan Alınan Sayı Çift Mi, Tek Mi?
            //Console.WriteLine("Lütfen Bir Sayı Giriniz");

            //string strSayi = Console.ReadLine();
            //int Sayi = Convert.ToInt32(strSayi);

            //if ((Sayi % 2) == 0)
            //{
            //    Console.WriteLine("Sayınız Çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("Sayınız Tekdir");
            //}
            #endregion

            #region Konsoldan Alınan 2 Notun Ortalaması 50 Üstü İse Geçtiniz, Değilse Kaldınız Yazılacak
            //Console.WriteLine("Lütfen İlk Notunucu Giriniz");
            //string strNot1 = Console.ReadLine();

            //Console.WriteLine("Lütfen İkinci Notunuzu Giriniz");
            //string strNot2 = Console.ReadLine();

            //double Not1 = Convert.ToDouble(strNot1);
            //double Not2 = Convert.ToDouble(strNot2);
            //double Ortalama = (Not1 + Not2) / 2;

            //if (Ortalama >= 50)
            //{
            //    Console.WriteLine("Ortalamanız = " + Ortalama + "\n" + "Geçtiniz");
            //}
            //else
            //{
            //    Console.WriteLine("Ortalamanız = " + Ortalama + "\n" + "Kaldınız");
            //}
            #endregion

            #region Konsoldan Kullanıcının Yaşını Alıp Ergen, Yetişkin ve Yaşlı Olarak Sınıflandır
            //Console.WriteLine("Lütfen Yaşınızı Giriniz");
            //string strYas = Console.ReadLine();

            //byte Yas = Convert.ToByte(strYas);

            //if (Yas < 8)
            //{
            //    Console.WriteLine("Geçerli Bir Sınıflandırma İçerisine Alınamadınız");
            //}
            //else if (Yas >= 8 && Yas <= 20)
            //{
            //    Console.WriteLine("Ergen");
            //}
            //else if (Yas > 20 && Yas < 65)
            //{
            //    Console.WriteLine("Genç");
            //}
            //else
            //{
            //    Console.WriteLine("Yaşlı");
            //}
            #endregion

            #region Konsoldan Alınan 2 Sayıdan Hangisinin Daha Büyük Olduğunu Yazdırma
            //Console.WriteLine("Lütfen İlk Sayıyı Giriniz");
            //string strSayi1 = Console.ReadLine();

            //Console.WriteLine("Lütfen İkinci Sayıyı Giriniz");
            //string strSayi2 = Console.ReadLine();

            //int Sayi1 = Convert.ToInt32(strSayi1);
            //int Sayi2 = Convert.ToInt32(strSayi2);

            //if (Sayi1 > Sayi2)
            //{
            //    Console.WriteLine("Büyük Sayı = " + Sayi1);
            //}
            //else
            //{
            //    Console.WriteLine("Büyük Sayı = " + Sayi2);
            //}
            #endregion

            #region Konsoldan Bir Harf Alıp O Harfin Sesli Harf Olup Olmadığını Kontrol Ederek Yazdır
            //Console.WriteLine("Lütfen Bir Harf Yazın");
            //string Yazi = Console.ReadLine();

            //char YaziC = Convert.ToChar(Yazi);

            //if (Yazi == "a" || Yazi == "A")
            //{
            //    Console.WriteLine("Harfiniz Sesli Bir Harf Olan " + Yazi);
            //}
            //else if (Yazi == "e" || Yazi == "E")
            //{
            //    Console.WriteLine("Harfiniz Sesli Bir Harf Olan " + Yazi);
            //}
            //else if (Yazi == "ı" || Yazi == "I")
            //{
            //    Console.WriteLine("Harfiniz Sesli Bir Harf Olan " + Yazi);
            //}
            //else if (Yazi == "i" || Yazi == "İ")
            //{
            //    Console.WriteLine("Harfiniz Sesli Bir Harf Olan " + Yazi);
            //}
            //else if (Yazi == "o" || Yazi == "O")
            //{
            //    Console.WriteLine("Harfiniz Sesli Bir Harf Olan " + Yazi);
            //}
            //else if (Yazi == "ö" || Yazi == "Ö")
            //{
            //    Console.WriteLine("Harfiniz Sesli Bir Harf Olan " + Yazi);
            //}
            //else if (Yazi == "u" || Yazi == "U")
            //{
            //    Console.WriteLine("Harfiniz Sesli Bir Harf Olan " + Yazi);
            //}
            //else if (Yazi == "ü" || Yazi == "Ü")
            //{
            //    Console.WriteLine("Harfiniz Sesli Bir Harf Olan " + Yazi);
            //}
            //else
            //{
            //    Console.WriteLine("Harfiniz Sesli Bir Harf Olmayan " + Yazi);
            //}
            #endregion

            #region Konsoldan Bir Sayı Alıp O Numaraya Karşılık Gelen Ayı Yazdır
            //Console.WriteLine("Lütfen Karşılığını Bulmak İstediğiniz Sayıyı Giriniz");
            //string Sayi = Console.ReadLine();

            //if (Sayi == "1")
            //{
            //    Console.WriteLine("Ocak");
            //}
            //else if (Sayi == "2")
            //{
            //    Console.WriteLine("Şubat");
            //}
            //else if (Sayi == "3")
            //{
            //    Console.WriteLine("Mart");
            //}
            //else if (Sayi == "4")
            //{
            //    Console.WriteLine("Nisan");
            //}
            //else if (Sayi == "5")
            //{
            //    Console.WriteLine("Mayıs");
            //}
            //else if (Sayi == "6")
            //{
            //    Console.WriteLine("Haziran");
            //}
            //else if (Sayi == "7")
            //{
            //    Console.WriteLine("Temmuz");
            //}
            //else if (Sayi == "8")
            //{
            //    Console.WriteLine("Ağustos");
            //}
            //else if (Sayi == "9")
            //{
            //    Console.WriteLine("Eylül");
            //}
            //else if (Sayi == "10")
            //{
            //    Console.WriteLine("Ekim");
            //}
            //else if (Sayi == "11")
            //{
            //    Console.WriteLine("Kasım");
            //}
            //else if (Sayi == "12")
            //{
            //    Console.WriteLine("Aralık");
            //}
            //else
            //{
            //    Console.WriteLine("Geçersiz Bir Değer Girdiniz");
            //}
            #endregion
        }
    }
}
