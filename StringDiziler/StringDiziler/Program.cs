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
            //string Isim = "Armağan Tambova";

            //Console.WriteLine(Isim + " Adı " + Isim.Length + " Karakterden Oluşmaktadır");

            //for (int i = 0; i < Isim.Length; i++)
            //{
            //    Console.WriteLine(Isim[i]);
            //}
            #endregion
        }
    }
}
