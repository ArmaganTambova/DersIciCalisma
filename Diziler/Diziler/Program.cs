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


            //int[] sayilar = {15, 45, 7, 16, 22, 81, 1, 13, 14, 58, 6, 4, 5, 36, -5};

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

            #region Öğrenci Kayıt Uygulaması
            //Console.WriteLine("Lütfen Kaç Öğrenci Kayıt Etmek İstediğinizi Yazınız");
            //int OgrenciAdedi = Convert.ToInt32(Console.ReadLine());
            //Console.Clear();

            //string[] Ogrenciler = new string[OgrenciAdedi];

            //for ( int i = 0; i < OgrenciAdedi; i++ )
            //{
            //    if (i == OgrenciAdedi - 1)
            //    {
            //        Console.WriteLine("Lütfen Öğrencinin Adı ve Soyadını Ayrı Şekilde Yazarak Giriniz (Son Öğrenci)");
            //        string OgrenciAdi = Console.ReadLine();
            //        Ogrenciler[i] = OgrenciAdi;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Lütfen Öğrencinin Adı ve Soyadını Ayrı Şekilde Yazarak Giriniz");
            //        string OgrenciAdi = Console.ReadLine();
            //        Ogrenciler[i] = OgrenciAdi;
            //    }
            //}

            //Console.Clear();
            //Console.WriteLine("*+*+* Öğrenciler *+*+*");

            //for ( int i = 0; i < Ogrenciler.Length; i++)
            //{
            //    Console.WriteLine(Ogrenciler[i]);
            //}

            #region Alternatif Versiyon
            //List<string> Ogrenciler = new List<string>();

            //bool Devam = true;

            //while (Devam)
            //{
            //    Console.WriteLine("Lütfen Öğrencinin Adı ve Soyadını Ayrı Şekilde Yazarak Giriniz");
            //    string OgrenciAdi = Console.ReadLine();
            //    Ogrenciler.Add(OgrenciAdi);
            //    Console.WriteLine(OgrenciAdi + " Adlı Öğrenci Başarıyla Kaydedilmiştir");
            //    Console.WriteLine("Öğrenci Eklemeye Devam Etmek İster Misiniz? E/H");
            //    string Secim = Console.ReadLine();
            //    if (Secim == "h" || Secim == "H")
            //    {
            //        Console.Clear();
            //        Devam = false;
            //    }
            //    else
            //    {
            //        Console.Clear();
            //        continue;
            //    }
            //}

            //Console.WriteLine("*+*+* Öğrenciler *+*+*");
            //Console.WriteLine("*+*+* " + Ogrenciler.Count + " Adet Öğrenci Eklendi *+*+*");

            //foreach (string Ogrenci in Ogrenciler)
            //{
            //    Console.WriteLine(Ogrenci);
            //}
            #endregion

            #endregion

            // Ödevler
            #region Bir Dizi Oluşturun ve Bu Dizinin Elemanlarını Ekrana Yazdırın
            //int[] sayilar = { 15, 45, 7, 16, 22, 81, 1, 13, 14, 58, 6, 4, 5, 36, -5 };

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}
            #endregion

            #region Bir Dizinin Elemanlarını Kullanıcıdan Alarak Diziye Atayın ve Sonra Diziyi Ekrana Yazdırın
            //Console.WriteLine("Lütfen Kaç Adet Değişken Girmek İstediğinizi Seçin");
            //int Adet = Convert.ToInt32(Console.ReadLine());
            //Console.Clear();

            //string[] Degisken = new string[Adet];

            //for (int i = 0; i < Adet; i++)
            //{
            //    if (i == Adet - 1)
            //    {
            //        Console.WriteLine("Değişken Adı Yazınız (Son Değişkeni Ekliyorsunuz)");
            //        string DegiskenAdi = Console.ReadLine();
            //        Degisken[i] = DegiskenAdi;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Değişken Adı Yazınız");
            //        string DegiskenAdi = Console.ReadLine();
            //        Degisken[i] = DegiskenAdi;
            //    }
            //}

            //Console.Clear();
            //Console.WriteLine("*+*+* Değişkenler *+*+*");

            //for (int i = 0;i < Degisken.Length;i++)
            //{
            //    Console.WriteLine(Degisken[i]);
            //}
            #endregion

            #region Bir Dizinin Elemanlarını Toplayarak Toplamı Ekrana Yazdırın
            //int[] sayilar = { 15, 45, 7, 16, 22, 81, 1, 13, 14, 58, 6, 4, 5, 36, -5 };

            //int Toplam = 0;

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Toplam += sayilar[i];
            //}

            //Console.WriteLine("Dizideki Sayıların Toplamı = " + Toplam);
            #endregion

            #region İki Dizinin Elemanlarını Toplayarak Yeni Bir Dizi Oluşturun
            //int[] sayilar1 = { 15, 45, 7, 16, 22, 81, 1, 13, 14, 58, 6, 4, 5, 36, -5 };
            //int[] sayilar2 = { 45, -50, -59, 78, 1250, -81, 58, 17, -4, 85, 7, -98, 125, -143, 63 };

            //int[] Toplamlar = new int[sayilar1.Length];

            //for (int i = 0; i < sayilar1.Length; i++)
            //{
            //    Toplamlar[i] = sayilar1[i] + sayilar2[i];
            //}

            //Console.WriteLine("*+*+* Toplamlar *+*+*");

            //for (int i = 0;i < Toplamlar.Length;i++)
            //{
            //    Console.WriteLine(Toplamlar[i]);
            //}
            #endregion

            #region Dizinin Elemanlarını Ters Çevirerek Yeni Bir Dizi Oluşturun
            //int[] sayilar = { 15, 45, 7, 16, 22, 81, 1, 13, 14, 58, 6, 4, 5, 36, -5 };

            //int[] Terssayilar = new int[sayilar.Length];

            //int Deger = 0;

            //for (int i = sayilar.Length - 1; i >= 0; i--)
            //{
            //    Terssayilar[Deger] = sayilar[i];
            //    Deger++;
            //}

            //Console.WriteLine("*+*+* Ters Dizi *+*+*");

            //for (int i = 0; i < Terssayilar.Length; i++)
            //{
            //    Console.WriteLine(Terssayilar[i]);
            //}
            #endregion

            #region Bir Dizinin En Büyük Elemanını Bulun
            //int[] sayilar = { 15, 45, 7, 16, 22, 81, 1, 13, 14, 58, 6, 4, 5, 36, -5 };

            #region Yol 1
            ////int EnBuyuk = sayilar.Max();
            ////Console.WriteLine("En Büyük Sayı = " + EnBuyuk);
            #endregion

            #region Yol 2
            //int EnBuyuk = sayilar[0];

            //for (int i = 1; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] > EnBuyuk)
            //    {
            //        EnBuyuk = sayilar[i];
            //    }
            //}

            //Console.WriteLine("En Büyük Sayı = " + EnBuyuk);
            #endregion

            #endregion

            #region Bir Dizinin En Küçük Elemanını Bulun
            //int[] sayilar = { 15, 45, 7, 16, 22, 81, 1, 13, 14, 58, 6, 4, 5, 36, -5 };

            #region Yol 1
            ////int EnKucuk = sayilar.Min();
            ////Console.WriteLine("En Küçük Sayı = " + EnKucuk);
            #endregion

            #region Yol 2
            //int EnKucuk = sayilar[0];

            //for (int i = 1; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] < EnKucuk)
            //    {
            //        EnKucuk = sayilar[i];
            //    }
            //}

            //Console.WriteLine("En Küçük Sayı = " + EnKucuk);
            #endregion

            #endregion

            #region İki Diziyi Birleştirerek Yeni Bir Dizi Oluşturun
            //int[] sayilar1 = { 15, 45, 7, 16, 22, 81, 1, 13, 14, 58, 6, 4, 5, 36, -5 };
            //int[] sayilar2 = { 45, -50, -59, 78, 1250, -81, 58, 17, -4, 85, 7, -98, 125, -143, 63 };

            #region Yol 1
            //int[] Birlesik = sayilar1.Concat(sayilar2).ToArray();

            //Console.WriteLine("*+*+* Birleşik Dizi *+*+*");

            //for (int i = 0; i < Birlesik.Length; i++)
            //{
            //    Console.WriteLine(Birlesik[i]);
            //}
            #endregion

            #region Yol 2
            //int[] Birlesik = new int[sayilar1.Length + sayilar2.Length];

            //Array.Copy(sayilar1, Birlesik, sayilar1.Length);
            //Array.Copy(sayilar2, 0, Birlesik, sayilar1.Length, sayilar2.Length);

            //for (int i = 0; i < Birlesik.Length; i++)
            //{
            //    Console.WriteLine(Birlesik[i]);
            //}
            #endregion

            #region Yol 3
            //int[] Birlesik = new int[sayilar1.Length + sayilar2.Length];

            //for (int i = 0; i < sayilar1.Length; i++)
            //{
            //    Birlesik[i] = sayilar1[i];
            //}

            //int Deger = sayilar1.Length;
            //int BlaBla = 0;

            //for (int i = Deger; i < sayilar1.Length + sayilar2.Length; i++)
            //{
            //    Birlesik[i] = sayilar2[BlaBla];
            //    BlaBla++;
            //}

            //for (int i = 0; i < Birlesik.Length; i++)
            //{
            //    Console.WriteLine(Birlesik[i]);
            //}
            #endregion

            #endregion

            #region İsimlerden Oluşan Bir Dizide Belirli Bir İsmin Kaç Kez Geçtiğini Bulun (Bulunacak İsmi Konsoldan İsteyin)
            //string[] İsimler = { "Armağan", "Armağan", "Armağan", "Poraz", "BiSenEksiktinKaan", "Poraz", "Armağan" };

            //Console.WriteLine("Kontrol Etmek İstediğiniz İsmi Giriniz (Armağan, Poraz, BiSenEksiktinKaan)");
            //string Strİsin = Console.ReadLine();

            //int Sayi = 0;

            //for (int i = 0; i < İsimler.Length; i++)
            //{
            //    if (İsimler[i] == Strİsin)
            //    {
            //        Sayi++;
            //    }
            //}

            //if (Sayi > 0)
            //{
            //    Console.WriteLine(Strİsin + " İsmi " + Sayi + " Kez Bulundu ");
            //}
            //else
            //{
            //    Console.WriteLine("Aradığınız İsmi Bulamadık");
            //}
            #endregion

            #region Bir Dizinin İçinde Belirli Bir Elemanın Indexini Bulun
            //int[] sayilar1 = { 15, 45, 7, 16, 22, 81, 1, 13, 14, 58, 6, 4, 5, 36, -5 };

            //Console.WriteLine("Lütfen Aratmak İstediğiniz Değeri Girin (Sadece Sayı)");
            //int Sayi = Convert.ToInt32(Console.ReadLine());

            #region Yol 1
            //bool Kontrol = sayilar1.Contains(Sayi);

            //if (Kontrol)
            //{
            //    int Index = Array.IndexOf(sayilar1, Sayi);
            //    Console.WriteLine("Aradığınız Sayının Indexi = " + Index);
            //}
            //else
            //{
            //    Console.WriteLine("Aradığınız Sayı Dizide Bulunmamakta");
            //}

            #region Alternatif
            //int Index = Array.IndexOf(sayilar1, Sayi);

            //if (Index != -1)
            //{
            //    Console.WriteLine("Aradığınız Sayının Indexi = " + Index);
            //}
            //else
            //{
            //    Console.WriteLine("Aradığınız Sayı Dizide Bulunamadı");
            //}
            #endregion

            #endregion

            #region Yol 2
            //int Index = Array.FindIndex(sayilar1, Eleman => Eleman == Sayi);

            //if (Index != -1)
            //{
            //    Console.WriteLine("Aradığınız Sayının Indexi = " + Index);
            //}
            //else
            //{
            //    Console.WriteLine("Aradığınız Sayı Dizide Bulunamadı");
            //}
            #endregion

            #region Yol 3
            //for (int i = 0; i < sayilar1.Length; i++)
            //{
            //    if (sayilar1[i] == Sayi)
            //    {
            //        Console.WriteLine("Aradığınız Sayının Indexi = " + i);
            //        break;
            //    }
            //    else
            //    {
            //        continue;
            //    }
            //}
            #endregion

            #endregion

            #region Bir Dizinin Elemanlarını Tek ve Çift Sayılar Olarak Ayırarak İki Dizi Oluşturun
            //int[] sayilar1 = { 15, 45, 7, 16, 22, 81, 1, 13, 14, 58, 6, 4, 5, 36, -5 };

            //int Cift1 = 0;
            //int Tek1 = 0;

            //for (int i = 0; i < sayilar1.Length; i++)
            //{
            //    if (sayilar1[i] % 2 == 0)
            //    {
            //        Cift1++;
            //    }
            //    else
            //    {
            //        Tek1++;
            //    }
            //}


            //int[] CiftSayilar = new int[Cift1];
            //int[] TekSayilar = new int[Tek1];

            //int Cift = 0;
            //int Tek = 0;

            //for (int i = 0; i < sayilar1.Length; i++)
            //{
            //    if (sayilar1[i] % 2 == 0)
            //    {
            //        CiftSayilar[Cift] = sayilar1[i];
            //        Cift++;
            //    }
            //    else
            //    {
            //        TekSayilar[Tek] = sayilar1[i];
            //        Tek++;
            //    }
            //}

            //Console.WriteLine("*+*+* Çift Sayılar *+*+*");

            //for (int i = 0; i < CiftSayilar.Length; i++)
            //{
            //    Console.WriteLine(CiftSayilar[i]);
            //}

            //Console.WriteLine("*+*+* Tek Sayılar *+*+*");

            //for (int i = 0; i <= TekSayilar.Length; i++)
            //{
            //    Console.WriteLine(TekSayilar[i]);
            //}
            #endregion
        }
    }
}
