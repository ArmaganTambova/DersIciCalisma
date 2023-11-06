using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErdalBakkal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Urunler = { "Domates", "Biber", "Soğan", "Yumurta", "Doritos", "Kola", "Ekmek" };
            string[] Birimler = { "Kilo", "Kilo", "Kilo", "Adet", "Adet", "Adet", "Adet" };
            double[] Fiyatlar = { 59.99, 49.90, 14.90, 3, 31.95, 45, 7 };

            Console.WriteLine("Matrix Markete Hoşgeldiniz");

            for (int i = 0; i < Urunler.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {Urunler[i]} {Fiyatlar[i]} TL");
            }

            #region Uygulama 1
            //Console.WriteLine("Lütfen Kaç Adet Ürün Almak İstediğinizi Giriniz");
            //int UrunAdet = Convert.ToInt32(Console.ReadLine());

            //double Toplam = 0;

            //for (int i = 0; i < UrunAdet; i++)
            //{
            //    if (!(i == UrunAdet - 1))
            //    {
            //        Console.WriteLine("Lütfen " + (i + 1) + ". Ürününüzün Numarasını Giriniz");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Lütfen " + (i + 1) + ". Ürününüzün Numarasını Giriniz (Son Ürününüzü Giriyorsunuz)");
            //    }
            //    int UrunNo = Convert.ToInt32(Console.ReadLine());
            //    if (UrunNo > Urunler.Length || UrunNo < 0)
            //    {
            //        Console.WriteLine("Lütfen Geçerli Bir Sayı Giriniz");
            //    }
            //    else
            //    {
            //        Toplam += Fiyatlar[UrunNo - 1];
            //    }
            //}

            //Console.Clear();
            //Console.WriteLine($"Toplam {Toplam} TL");
            #endregion

            #region Uygulama 2
            //double Toplam = 0; bool Kontrol = true;

            //while (Kontrol)
            //{
            //    Console.WriteLine("Lütfen Ürün Numarasını Giriniz");
            //    int UrunNo = Convert.ToInt32(Console.ReadLine());

            //    if (UrunNo > Urunler.Length || UrunNo < 0)
            //    {
            //        Console.WriteLine("Lütfen Geçerli Bir Sayı Giriniz");
            //    }
            //    else
            //    {
            //        Toplam += Fiyatlar[UrunNo - 1];
            //        Console.WriteLine("Alışverişe Devam Edilsin Mi? e/h");
            //        string Secenek = Console.ReadLine();

            //        if (Secenek == "e" || Secenek == "E")
            //        {
            //            Kontrol = true;
            //        }
            //        else
            //        {
            //            Kontrol = false;
            //        }
            //    }
            //}

            //Console.Clear();
            //Console.WriteLine($"Toplam = {Toplam} TL");
            #endregion

            #region Uygulama 3
            //double Toplam = 0; bool Kontrol = true;

            //while (Kontrol)
            //{
            //    Console.WriteLine("Lütfen Ürün Numarasını Giriniz");
            //    int UrunNo = Convert.ToInt32(Console.ReadLine());

            //    if (UrunNo > Urunler.Length || UrunNo < 0)
            //    {
            //        Console.WriteLine("Lütfen Geçerli Bir Sayı Giriniz");
            //    }
            //    else
            //    {
            //        bool KKontrol = false; int Adet = 0;
            //        while (!KKontrol)
            //        {
            //            Console.WriteLine($"{Urunler[UrunNo - 1]} Adlı Üründen Kaç Adet Almak İstersiniz?");
            //            Adet = Convert.ToInt32(Console.ReadLine());
            //            if (Adet <= 0)
            //            {
            //                Console.WriteLine("Lütfen 0'dan Büyük Bir Sayı Giriniz");
            //                KKontrol = false;
            //            }
            //            else
            //            {
            //                KKontrol = true;
            //            }
            //        }

            //        Toplam += Fiyatlar[UrunNo - 1] * Adet;
            //        Console.WriteLine("Alışverişe Devam Edilsin Mi? e/h");
            //        string Secenek = Console.ReadLine();

            //        if (Secenek == "e" || Secenek == "E")
            //        {
            //            Kontrol = true;
            //        }
            //        else
            //        {
            //            Kontrol = false;
            //        }
            //    }
            //}

            //Console.Clear();
            //Console.WriteLine($"Toplam = {Toplam} TL");
            #endregion

            #region Uygulama 4
            //double Toplam = 0; bool Kontrol = true;

            //while (Kontrol)
            //{
            //    Console.WriteLine("Lütfen Ürün Numarasını Giriniz");
            //    int UrunNo = Convert.ToInt32(Console.ReadLine());

            //    if (UrunNo > Urunler.Length || UrunNo < 0)
            //    {
            //        Console.WriteLine("Lütfen Geçerli Bir Sayı Giriniz");
            //    }
            //    else
            //    {
            //        bool KKontrol = false; int Adet = 0;
            //        while (!KKontrol)
            //        {
            //            Console.WriteLine($"{Urunler[UrunNo - 1]} Adlı Üründen Kaç {Birimler[UrunNo - 1]} Almak İstersiniz?");
            //            Adet = Convert.ToInt32(Console.ReadLine());
            //            if (Adet <= 0)
            //            {
            //                Console.WriteLine("Lütfen 0'dan Büyük Bir Sayı Giriniz");
            //                KKontrol = false;
            //            }
            //            else
            //            {
            //                KKontrol = true;
            //            }
            //        }

            //        Toplam += Fiyatlar[UrunNo - 1] * Adet;
            //        Console.WriteLine("Alışverişe Devam Edilsin Mi? e/h");
            //        string Secenek = Console.ReadLine();

            //        if (Secenek == "e" || Secenek == "E")
            //        {
            //            Kontrol = true;
            //        }
            //        else
            //        {
            //            Kontrol = false;
            //        }
            //    }
            //}

            //Console.Clear();
            //Console.WriteLine($"Toplam = {Toplam} TL");
            #endregion
        }
    }
}
