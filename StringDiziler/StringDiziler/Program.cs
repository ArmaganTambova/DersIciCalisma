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
            // "string" Türü Değişken Olarak Tanımlansada Aynı Zamanda Bir Karakter Dizisidir
            string Isim = "Armağan Tambova";

            Console.WriteLine("Dizinin Eleman Sayısı = " + Isim.Length);
            Console.WriteLine("Dizinin 2. Indexindeki Karakter = " + Isim[1]);

            // Dizinin Indexlerine Karakter Atanamaz (ReadOnly) Sadece Okunabilir Alanlardır
            //Isim[2] = "o";

            // Ancak Sona Ekleme Yapılabilir
            Isim += " & Aptal Kaan";
            Console.WriteLine(Isim);
        }
    }
}
