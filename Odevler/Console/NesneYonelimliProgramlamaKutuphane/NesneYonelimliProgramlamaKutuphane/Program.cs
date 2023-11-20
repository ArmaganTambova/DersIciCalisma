using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneYonelimliProgramlamaKutuphane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kitaplar SekerPortakali = new Kitaplar();
            SekerPortakali.KitapAdi = "Şeker Portakalı";
            SekerPortakali.KitabinYazari = "Jose Mauro De Vasconcelos";
            SekerPortakali.KitabinYayinEvi = "Can Yayınları";
            SekerPortakali.KitabinFiyati = 85.00;

            Kitaplar OtomatikPortakal = new Kitaplar();
            OtomatikPortakal.KitapAdi = "Otomatik Portakal";
            OtomatikPortakal.KitabinYazari = "Anthony Burgess";
            OtomatikPortakal.KitabinYayinEvi = "İş Bankası Kültür Yayınları";
            OtomatikPortakal.KitabinFiyati = 20.60;

            Kitaplar FelsefeyeGiris = new Kitaplar();
            FelsefeyeGiris.KitapAdi = "Felsefeye Giriş";
            FelsefeyeGiris.KitabinYazari = "Ahmet Cevizci";
            FelsefeyeGiris.KitabinYayinEvi = "Say Yayınları";
            FelsefeyeGiris.KitabinFiyati = 133.00;

            Kitaplar SeninleBaslamadi = new Kitaplar();
            SeninleBaslamadi.KitapAdi = "Seninle Başlamadı";
            SeninleBaslamadi.KitabinYazari = "Mark Wolynn";
            SeninleBaslamadi.KitabinYayinEvi = "Solas Unitas Yayınları";
            SeninleBaslamadi.KitabinFiyati = 102.95;

            Kitaplar Mesaj = new Kitaplar();
            Mesaj.KitapAdi = "Mesaj";
            Mesaj.KitabinYazari = "Carl Sagan";
            Mesaj.KitabinYayinEvi = "Say Yayınları";
            Mesaj.KitabinFiyati = 190.00;

            Kitaplar Aeden = new Kitaplar();
            Aeden.KitapAdi = "Aeden";
            Aeden.KitabinYazari = "Akilah Azra Kohen";
            Aeden.KitabinYayinEvi = "Everest Yayınları";
            Aeden.KitabinFiyati = 146.25;

            Kitaplar SucVeCeza = new Kitaplar();
            SucVeCeza.KitapAdi = "Suç ve Ceza";
            SucVeCeza.KitabinYazari = "Fyodor Dostoyevski";
            SucVeCeza.KitabinYayinEvi = "İş Bankası Kültür Yayınları";
            SucVeCeza.KitabinFiyati = 56.00;

            Kitaplar TurlerinKokeni = new Kitaplar();
            TurlerinKokeni.KitapAdi = "Türlerin Kökeni";
            TurlerinKokeni.KitabinYazari = "Charles Darwin";
            TurlerinKokeni.KitabinYayinEvi = "Yason Yayıncılık";
            TurlerinKokeni.KitabinFiyati = 105.60;

            Kitaplar InsaninTureyisi = new Kitaplar();
            InsaninTureyisi.KitapAdi = "İnsanın Türeyişi";
            InsaninTureyisi.KitabinYazari = "Charles Darwin";
            InsaninTureyisi.KitabinYayinEvi = "Alfa Yayıncılık";
            InsaninTureyisi.KitabinFiyati = 97.20;

            Kitaplar Fi = new Kitaplar();
            Fi.KitapAdi = "Fi";
            Fi.KitabinYazari = "Akilah Azra Kohen";
            Fi.KitabinYayinEvi = "Everest Yayınları";
            Fi.KitabinFiyati = 136.50;

            Console.WriteLine($"{SekerPortakali.KitapAdi} - {SekerPortakali.KitabinYazari} / {SekerPortakali.KitabinYayinEvi} / {SekerPortakali.KitabinFiyati}TL");
            Console.WriteLine($"{OtomatikPortakal.KitapAdi} - {OtomatikPortakal.KitabinYazari} / {OtomatikPortakal.KitabinYayinEvi} / {OtomatikPortakal.KitabinFiyati}TL");
            Console.WriteLine($"{FelsefeyeGiris.KitapAdi} - {FelsefeyeGiris.KitabinYazari} / {FelsefeyeGiris.KitabinYayinEvi} / {FelsefeyeGiris.KitabinFiyati}TL");
            Console.WriteLine($"{SeninleBaslamadi.KitapAdi} - {SeninleBaslamadi.KitabinYazari} / {SeninleBaslamadi.KitabinYayinEvi} / {SeninleBaslamadi.KitabinFiyati}TL");
            Console.WriteLine($"{Mesaj.KitapAdi}  -  {Mesaj.KitabinYazari} / {Mesaj.KitabinYayinEvi} / {Mesaj.KitabinFiyati}TL");
            Console.WriteLine($"{Aeden.KitapAdi} - {Aeden.KitabinYazari} / {Aeden.KitabinYayinEvi} / {Aeden.KitabinFiyati}TL");
            Console.WriteLine($"{SucVeCeza.KitapAdi} - {SucVeCeza.KitabinYazari} / {SucVeCeza.KitabinYayinEvi} / {SucVeCeza.KitabinFiyati}TL");
            Console.WriteLine($"{TurlerinKokeni.KitapAdi} - {TurlerinKokeni.KitabinYazari} / {TurlerinKokeni.KitabinYayinEvi} / {TurlerinKokeni.KitabinFiyati}TL");
            Console.WriteLine($"{InsaninTureyisi.KitapAdi} - {InsaninTureyisi.KitabinYazari} / {InsaninTureyisi.KitabinYayinEvi} / {InsaninTureyisi.KitabinFiyati}TL");
            Console.WriteLine($"{Fi.KitapAdi} - {Fi.KitabinYazari}  /  {Fi.KitabinYayinEvi} / {Fi.KitabinFiyati}TL");
        }
    }
    class Kitaplar
    {
        public string KitapAdi;
        public string KitabinYazari;
        public string KitabinYayinEvi;
        public double KitabinFiyati;
    }
}
