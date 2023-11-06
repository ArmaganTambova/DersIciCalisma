using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AraTatilOdevi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Kitap Sistemi
            string[] KitapAdi = { "Şeker Portakalı", "Otomatik Portakal", "Felsefeye Giriş", "Seninle Başlamadı", "Mesaj", "Aeden", "Suç ve Ceza", "Türlerin Kökeni", "İnsanın Türeyişi", "Fi", "Çi", "Pi", "Beyin", "Don Kişot", "Dijital Kaos", "Epigenetik", "Zamanın Kısa Tarihi", "Büyük Sorulara Kısa Yanıtlar", "Romeo ve Juliet", "Hayvanlardan Tanrılara: Sapiens" };
            string[] KitabinYazari = { "Jose Mauro De Vasconcelos", "Anthony Burgess", "Ahmet Cevizci", "Mark Wolynn", "Carl Sagan", "Akilah Azra Kohen", "Fyodor Dostoyevski", "Charles Darwin", "Charles Darwin", "Akilah Azra Kohen", "Akilah Azra Kohen", "Akilah Azra Kohen", "David Eagleman", "Miguel de Cervantes", "Tanol Türkoğlu", "Bernhard Kegel", "Stephen W. Hawking", "Stephen W. Hawking", "William Shakespeare", "Yuval Noah Harari" };
            string[] KitabinTuru = { "Roman", "Roman", "Araştırma-İnceleme", "Araştırma-İnceleme", "Bilim-Kurgu", "Roman", "Roman", "Bilim-Teknoloji-Mühendislik", "Bilim-Teknoloji-Mühendislik", "Roman", "Roman", "Roman", "Bilim-Teknoloji-Mühendislik", "Roman", "Bilim-Kurgu", "Bilim-Teknoloji-Mühendislik", "Bilim-Teknoloji-Mühendislik", "Bilim-Teknoloji-Mühendislik", "Dünya Klasikleri", "Bilim-Teknoloji-Mühendislik" };
            string[] KitabinYayinEvi = { "Can Yayınları", "İş Bankası Kültür Yayınları", "Say Yayınları", "Sola Unitas Yayınları", "Say Yayınları", "Everest Yayınları", "İş Bankası Kültür Yayınları", "Yason Yayıncılık", "Alfa Yayınları", "Everest Yayınları", "Everest Yayınları", "Everest Yayınları", "Domingo Yayınevi", "Koridor Yayınları", "Epsilon Yayınevi", "Say Yayınları", "Alfa Bilim", "Alfa Yayıncılık", "İş Bankası Kültür Yayınları", "Kolektif Kitap" };
            double[] KitabinFiyati = { 85.00, 28.60, 133.00, 102.95, 190.00, 146.25, 56.80, 105.60, 97.20, 136.50, 90.35, 136.50, 92.14, 68.87, 117.95, 152.00, 90.35, 74.75, 13.86, 166.85 };

            string[] KitaplarinTurleri = { "Roman", "Araştırma-İnceleme", "Bilim-Kurgu", "Bilim-Teknoloji-Mühendislik", "Dünya Klasikleri" };
            string[] KitaplarinYazarlari = { "Jose Mauro De Vasconcelos", "Anthony Burgess", "Ahmet Cevizci", "Mark Wolynn", "Carl Sagan", "Akilah Azra Kohen", "Fyodor Dostoyevski", "Charles Darwin", "David Eagleman", "Miguel de Cervantes", "Tanol Türkoğlu", "Bernhard Kegel", "Stephen W. Hawking", "William Shakespeare", "Yuval Noah Harari" };

            bool Kontrol = true;

            Console.WriteLine("Hoşgeldiniz");

            while (Kontrol)
            {
                Console.WriteLine("Lütfen Kitapları Nasıl Sıralamak İstediğinizi Seçiniz\n1- Türe Göre\n2- Yazara Göre\nHangi Listeleme Yöntemini Seçmek İstersiniz?");
                int Secim = Convert.ToInt32(Console.ReadLine());

                if (Secim == 1)
                {
                    int sayac = 1;

                    for (int i = 0; i < KitaplarinTurleri.Length; i++)
                    {
                        Console.WriteLine($"{sayac}-) {KitaplarinTurleri[i]}");
                        sayac++;
                    }
                }
                else if (Secim == 2)
                {
                    int sayac = 1;

                    for (int i = 0; i < KitaplarinTurleri.Length; i++)
                    {
                        Console.WriteLine($"{sayac}-) {KitaplarinYazarlari[i]}");
                        sayac++;
                    }
                }
                else
                {
                    Console.WriteLine("Geçerli Bir Seçenek Girmediniz");
                }
            }
            #endregion

            #region İlaç Sistemi

            #endregion
        }
    }
}
