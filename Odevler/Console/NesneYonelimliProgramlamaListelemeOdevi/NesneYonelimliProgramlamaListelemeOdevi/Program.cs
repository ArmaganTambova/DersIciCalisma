using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneYonelimliProgramlamaListelemeOdevi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ürünler
            Urunler[] Urun = new Urunler[10];

            Urunler Prf1 = new Urunler();
            Prf1.Marka = "Tom Ford";
            Prf1.Model = "Bitter Peach";
            Prf1.Fiyat = 11490.00;
            Prf1.Stok = 100;
            Urun[0] = Prf1;

            Urunler Prf2 = new Urunler();
            Prf2.Marka = "Tom Ford";
            Prf2.Model = "Ebene Fume";
            Prf2.Fiyat = 8540.00;
            Prf2.Stok = 58;
            Urun[1] = Prf2;

            Urunler Prf3 = new Urunler();
            Prf3.Marka = "Dior";
            Prf3.Model = "Sauvage Elixir";
            Prf3.Fiyat = 7535.00;
            Prf3.Stok = 12;
            Urun[2] = Prf3;

            Urunler Prf4 = new Urunler();
            Prf4.Marka = "Dolce & Gabanna";
            Prf4.Model = "King";
            Prf4.Fiyat = 6325.00;
            Prf4.Stok = 0;
            Urun[3] = Prf4;

            Urunler Prf5 = new Urunler();
            Prf5.Marka = "Jean Paul Gaultier";
            Prf5.Model = "Le Beau Male";
            Prf5.Fiyat = 3846.00;
            Prf5.Stok = 13;
            Urun[4] = Prf5;

            Urunler Prf6 = new Urunler();
            Prf6.Marka = "Jean Paul Gaultier";
            Prf6.Model = "Scandal Le Parfum";
            Prf6.Fiyat = 3846.00;
            Prf6.Stok = 14;
            Urun[5] = Prf6;

            Urunler Prf7 = new Urunler();
            Prf7.Marka = "Hermes";
            Prf7.Model = "Terre D'Hermes Eau Intense Vetiver";
            Prf7.Fiyat = 4740.00;
            Prf7.Stok = 86;
            Urun[6] = Prf7;

            Urunler Prf8 = new Urunler();
            Prf8.Marka = "Yves Saint Laurent";
            Prf8.Model = "Y Le Parfum";
            Prf8.Fiyat = 5230.00;
            Prf8.Stok = 1;
            Urun[7] = Prf8;

            Urunler Prf9 = new Urunler();
            Prf9.Marka = "Bvlgari";
            Prf9.Model = "Le Gemme Men Ambero";
            Prf9.Fiyat = 9773.00;
            Prf9.Stok = 12;
            Urun[8] = Prf9;

            Urunler Prf10 = new Urunler();
            Prf10.Marka = "Giorgio Armani";
            Prf10.Model = "Prive İndigo Tanzanite";
            Prf10.Fiyat = 11800.00;
            Prf10.Stok = 23;
            Urun[9] = Prf10;
            #endregion

            string[] ListelenenModeller = { " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };

            bool Kontrol = true; bool SKontrol = true; bool AKontrol = true; int Sayac = 1; int Secim = 0; int Index = 0; int Adet = 0; string DSecim = " "; string Onay = " ";

            while (Kontrol)
            {
                for (int i = 0; i < Urun.Length; i++)
                {
                    if (Urun[i].Stok != 0 && Urun[i].Stok >= 1)
                    {
                        Console.WriteLine($"{Sayac}) {Urun[i].Marka} - {Urun[i].Model} / {Urun[i].Fiyat}TL");
                        ListelenenModeller[Sayac - 1] = Urun[i].Model;
                        Sayac++;
                    }
                }

                Sayac--;

                while (SKontrol)
                {
                    Console.WriteLine("Lütfen Hangi Ürünü Almak İstediğinizi Seçiniz");
                    Secim = Convert.ToInt32(Console.ReadLine());

                    if (!(Secim <= 0 || Secim > Sayac))
                    {
                        Console.Clear();
                        SKontrol = false;
                    }
                    else
                    {
                        Console.WriteLine("Geçerli Bir Değer Girmediniz");
                    }
                }

                while (AKontrol)
                {
                    for (int i = 0; i < Urun.Length; i++)
                    {
                        if (Urun[i].Model == ListelenenModeller[Secim - 1])
                        {
                            Index = i;
                        }
                    }

                    Console.WriteLine($"Lütfen Seçmiş Olduğunuz Üründen ({Urun[Index].Marka} - {Urun[Index].Model}) Kaç Adet Almak İstediğinizi Giriniz");
                    Adet = Convert.ToInt32(Console.ReadLine());

                    if (Adet > Urun[Index].Stok)
                    {
                        Console.WriteLine($"Seçtiğiniz Üründen Elimizde {Urun[Index].Stok} Adet Kalmıştır, Lütfen Tekrar Miktar Bilgisi Giriniz");
                    }
                    else if (Adet <= 0)
                    {
                        Console.WriteLine("Lütfen 0'dan Büyük Bir Miktar Giriniz");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine($"Seçmiş Olduğunuz Üründen ({Adet}) Adet Satın Almak Üzeresiniz Onaylıyor Musunuz? e/h - {Urun[Index].Fiyat * Adet} TL");
                        Onay = Console.ReadLine();

                        if (Onay == "e" || Onay == "E")
                        {
                            Console.WriteLine("Satın Alım Başarıyla Gerçekleşmiştir");
                            Urun[Index].Stok = Urun[Index].Stok - Adet;
                            AKontrol = false;
                        }
                        else
                        {
                            Console.WriteLine("Satın Alım İptal Edilmiştir");
                            AKontrol = false;
                        }
                    }
                }

                Console.WriteLine("Ürün Almaya Devam Etmek İster Misiniz? e/h");
                DSecim = Console.ReadLine();

                if (DSecim == "e" || DSecim == "E")
                {
                    for (int i = 0; i < ListelenenModeller.Length; i++)
                    {
                        ListelenenModeller[i] = " ";
                    }

                    Kontrol = true; SKontrol = true; AKontrol = true; Sayac = 1; Secim = 0; Index = 0; Adet = 0; DSecim = " "; Onay = " ";
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Kontrol = false;
                }
            }
            Console.WriteLine("Bizi Tercih Ettiğiniz İçin Teşekkürler");
        }
    }
}
