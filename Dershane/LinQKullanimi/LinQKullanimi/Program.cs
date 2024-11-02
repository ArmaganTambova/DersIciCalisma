using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LinQKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Nedir LinQ

            //Microsoft abinin sql sorgularının kullanım kolaylığını fark edip c# kullanan zavallı yazılımcılara armağan ettiği Collection yönetim ve sorgulama tekniğidir.

            #endregion

            #region LinQ Kullanımı

            //List<int> sayilar = new List<int>();
            //sayilar.AddRange(new int[] { 17, 22, 3, 84, 7, 77, 15, 32, 17, 27, -90, 33 });
            //List<int> buyuksayilar = (from item in sayilar where item > 50 select item).ToList();

            //foreach (int item in buyuksayilar)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Lambda Expression

            //List<int> sayilar = new List<int>();
            //sayilar.AddRange(new int[] { 17, 22, 3, 84, 7, 77, 15, 32, 17, 27, -90, 33 });
            //List<int> buyuksayilar = sayilar.Where(item => item > 50).ToList();

            //foreach (int item in buyuksayilar)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            List<int> sayilar = new List<int>();
            sayilar.AddRange(new int[] { 17, 22, 3, 84, 7, 77, 15, 32, 17, 27, -90, 33 });
            List<string> isimler = new List<string>();
            isimler.AddRange(new string[] { "Ankara", "Adana", "İzmir", "Bursa", "İstanbul", "Çorum", "Sivas", "Eskişehir" });

            #region WHERE

            //List<int> negatif = sayilar.Where(s => s < 0).ToList();
            //foreach (int item in negatif)
            //{
            //    Console.WriteLine(item);
            //}

            ////List<string> filtre = isimler.Where(i => i.Length > 5).ToList();
            ////filtre.ForEach(f => Console.WriteLine(f));

            //isimler.Where(i => i.Length > 5).ToList().ForEach(f => Console.WriteLine(f));

            #endregion

            #region First

            //int sayi = sayilar.First(s => s > 50);
            //Console.WriteLine("50'den büyük ilk sayı = " + sayi);

            //string isim = isimler.First(i => i.Contains("İ"));
            //Console.WriteLine(isim);

            #endregion

            #region FirstOrDefault

            //int ilkCiftSayi = sayilar.First(s => s % 2 == 0);
            //Console.WriteLine(ilkCiftSayi);

            //int yuzdenbuyukilksayi = sayilar.First(s => s > 100);
            //Console.WriteLine(yuzdenbuyukilksayi);

            //int yuzdenbuyukilksayi = sayilar.FirstOrDefault(s => s > 100);
            //Console.WriteLine(yuzdenbuyukilksayi);

            #endregion

            #region Last

            //int sayi = sayilar.Last(s => s > 50);
            //Console.WriteLine("50'den büyük son sayı = " + sayi);

            //string isim = isimler.Last(i => i.Contains("İ"));
            //Console.WriteLine(isim);

            #endregion

            #region Count

            //Console.WriteLine(sayilar.Count(s => s > 50));

            #endregion

            #region Max - Min - Sum - Average

            //int enbuyuk = sayilar.Max();
            //int enkucuk = sayilar.Min();

            //int enkucukpozitifSayi = sayilar.Where(s => s > 0).Min();

            //int toplam = sayilar.Sum();

            //double ortalama = sayilar.Average();

            //Console.WriteLine($"En Büyük = {enbuyuk}\nEn Küçük = {enkucuk}\nToplam = {toplam}\nOrtalama = {ortalama}");

            #endregion

            #region Orderby - Reverse

            //sayilar.OrderBy(s => s).ToList().ForEach(i => Console.WriteLine(i));
            //Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
            //sayilar.OrderByDescending(s => s).ToList().ForEach(i => Console.WriteLine(i));

            //isimler.Reverse();
            //isimler.ForEach(i => Console.WriteLine(i));

            #endregion

            List<Ogrenci> ogrenciler = new List<Ogrenci>();
            ogrenciler.Add(new Ogrenci("Murtaza", "Şuayipoğlu", "11/E", 14));
            ogrenciler.Add(new Ogrenci("Ali", "Suatoğlu", "11/E", 14));
            ogrenciler.Add(new Ogrenci("Veli", "Kayaoğlu", "11/E", 14));
            ogrenciler.Add(new Ogrenci("Ayşe", "Sucuoğlu", "12/E", 14));
            ogrenciler.Add(new Ogrenci("Muratcan", "Mahmutoğlu", "11/E", 14));

            #region WHERE

            //11/E Sınıfında okuyan öğrenciler

            //List<Ogrenci> onbir = ogrenciler.Where(o => o.Sinif == "11/E").ToList();
            //onbir.ForEach(i => Console.WriteLine(i.Sinif + " "+ i.Isim + " " + i.SoyIsim));

            #endregion
        }
    }

    class Ogrenci
    {
        public string Isim { get; set; }
        public string SoyIsim { get; set; }
        public string Sinif { get; set; }
        public int Yas { get; set; }
        public Ogrenci(string Isim, string SoyIsim, string Sinif, int Yas)
        {
            this.Isim = Isim;
            this.SoyIsim = SoyIsim;
            this.Sinif = Sinif;
            this.Yas = Yas;
        }
    }
}
