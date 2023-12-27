using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErdalBakkalGenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ürünler
            List<Urunler> UrunlerListesi = new List<Urunler>();

            Urunler Urun1 = new Urunler() { Urun = "Domates", Birimler = "Kilo", Fiyatlar = 59.99 };
            Urunler Urun2 = new Urunler() { Urun = "Biber", Birimler = "Kilo", Fiyatlar = 49.90};
            Urunler Urun3 = new Urunler() { Urun = "Soğan", Birimler = "Kilo", Fiyatlar = 14.90 };
            Urunler Urun4 = new Urunler() { Urun = "Yumurta", Birimler = "Adet", Fiyatlar = 3.00};
            Urunler Urun5 = new Urunler() { Urun = "Doritos", Birimler = "Adet", Fiyatlar = 31.95};
            Urunler Urun6 = new Urunler() { Urun = "Kola", Birimler = "Adet", Fiyatlar = 45.00};
            Urunler Urun7 = new Urunler() { Urun = "Ekmek", Birimler = "Adet", Fiyatlar = 7.00};

            UrunlerListesi.Add(Urun1);
            UrunlerListesi.Add(Urun2);
            UrunlerListesi.Add(Urun3);
            UrunlerListesi.Add(Urun4);
            UrunlerListesi.Add(Urun5);
            UrunlerListesi.Add(Urun6);
            UrunlerListesi.Add(Urun7);
            #endregion

            double Toplam = 0; bool Kontrol = true;

            while (Kontrol)
            {
                int i = 1;
                foreach (Urunler Urun in UrunlerListesi)
                {
                    Console.WriteLine($"{i}) {Urun.Urun} {Urun.Fiyatlar}TL");
                    i++;
                }

                Console.WriteLine("Lütfen Ürün Numarasını Giriniz");
                int UrunNo = Convert.ToInt32(Console.ReadLine());

                if (UrunNo > UrunlerListesi.Count || UrunNo < 0)
                {
                    Console.WriteLine("Lütfen Geçerli Bir Sayı Giriniz");
                }
                else
                {
                    bool KKontrol = false; int Adet = 0;
                    while (!KKontrol)
                    {
                        Console.WriteLine($"{UrunlerListesi[UrunNo - 1].Urun} Adlı Üründen Kaç {UrunlerListesi[UrunNo - 1].Birimler} Almak İstersiniz?");
                        Adet = Convert.ToInt32(Console.ReadLine());
                        if (Adet <= 0)
                        {
                            Console.WriteLine("Lütfen 0'dan Büyük Bir Sayı Giriniz");
                            KKontrol = false;
                        }
                        else
                        {
                            KKontrol = true;
                        }
                    }

                    Toplam += UrunlerListesi[UrunNo - 1].Fiyatlar * Adet;
                    Console.WriteLine("Alışverişe Devam Edilsin Mi? e/h");
                    string Secenek = Console.ReadLine();

                    if (Secenek == "e" || Secenek == "E")
                    {
                        Kontrol = true;
                    }
                    else
                    {
                        Kontrol = false;
                    }
                }
            }

            Console.Clear();
            Console.WriteLine($"Toplam = {Toplam} TL");
        }
    }
}
