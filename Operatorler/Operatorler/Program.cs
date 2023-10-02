using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Aritmasiksel Operatörler
            ////Toplama  +
            ////Çıkarma  -
            ////Çarpma   *
            ////Bölme    /
            ////Atama    =    //Tanımlanan Değişkene Veri Atamak İçin Kullanılır

            //// ÖZEL OPERATÖRLER
            ////+=, -=, *=, /=, ++, --


            //int sayi1 = 13;
            //int sayi2 = 5;

            //// sayi1 ile sayi2'yi Topla toplam İsmindeki Değişkene At
            //int toplam = sayi1 + sayi2;
            //Console.Write("Toplam = ");
            //Console.WriteLine(toplam);

            //// sayi1'den sayi2'yi Çıkart fark İsmindeki Değişkene At
            //int fark = sayi1 - sayi2;
            //Console.Write("Fark = ");
            //Console.WriteLine(fark);

            //// sayi1'den sayi2'yi Çarp carpim İsmindeki Değişkene At
            //int carpim = sayi1 * sayi2;
            //Console.Write("Çarpım = ");
            //Console.WriteLine(carpim);

            //// Bölme İşlemnin Ondalık Sonuç Vermesini İstiyorsak Bölme İşleminde Kullanılan Değişkenlerin: double float veya decimal Olması Gerekir
            //int bolum = sayi1 / sayi2;
            //Console.Write("Bölüm = ");
            //Console.WriteLine(bolum);

            //double sayi3 = 13;
            //double sayi4 = 5;
            //double bolum2 = sayi3 / sayi4;
            //Console.Write("Bölüm = ");
            //Console.WriteLine(bolum2);

            //// Mod = İki Sayının Birbirine Bölümünden Kalan
            //int mod = sayi1 % sayi2;
            //Console.Write("Mod = ");
            //Console.WriteLine(mod);

            ////
            //Console.WriteLine(sayi1);
            //// sayi1'e Değişkeninin Üzerine 10 Ekle
            //sayi1 += 10;
            //Console.WriteLine(sayi1);
            //// sayi1'e 1 Ekle
            //sayi1++;
            //Console.WriteLine(sayi1);
            #endregion

            #region Karşılaştırma Operatörleri
            ////Büyüktür      = >
            ////Küçüktür      = <
            ////Eşittir       = ==
            ////Büyük Eşit    = >=
            ////Küçük Eşit    = <=
            ////Eşit Değil    = !=
            ////Değil (Tersi) = !

            //// Karşılaştırma Operatörleri Her Zaman Boolean Veri Döndürür

            //int sayi = 22;

            //Console.Write("Sayı 10'dan Büyük Mü? = ");
            //Console.WriteLine(sayi > 10);

            //Console.Write("Sayı 10'dan Küçük Mü? = ");
            //Console.WriteLine(sayi < 10);

            //Console.Write("Sayı 10'a Eşit Mi? = ");
            //Console.WriteLine(sayi == 10);

            //Console.Write("Sayı 10'dan Büyük Eşit Mi? = ");
            //Console.WriteLine(sayi >= 10);

            //Console.Write("Sayı 10'dan Küçük Eşit Mi? = ");
            //Console.WriteLine(sayi <= 10);

            //Console.Write("Sayı 10'a Eşit Değil Mi? = ");
            //Console.WriteLine(sayi != 10);


            //// ! Her Zaman Başa Yazılır
            //Console.WriteLine(!true);

            //Console.Write("Sayı 10'dan Büyük Değil Mi? = ");
            //Console.WriteLine(!(sayi > 10));
            #endregion

            #region Mantıksal Operatörler
            //// && = Ve Anlamında Kullanılan Mantıksal Operatördür
            ////   true  &&  true  = true
            ////   true  &&  false = false
            ////   false &&  true  = false
            ////   false &&  false = false

            //// || = Veya Anlamında Kullanılan Mantıksal Operatördür
            ////   true  ||  true  = true
            ////   true  ||  false = true
            ////   false ||  true  = true
            ////   false ||  fasle = false

            //// Mantıksal Operatörler "Ve" "Veya" Komutlarına İhtiyaç Duyduğumuzda Duyduğumuzda Kullanılır
            //// Genellikle Karşılaştırma Operatörleri İle Birlikte Kullanılır
            //// Boolean Veri Türleri İle Koşulları Çoğaltmak Veya Aynı Koşula Birden Çok Değişken Eklemek İçin Tercih Edilir
            //// Mantıksal Operatörlerin Sağına Ve Soluna Bollean Veri Olmalıdır

            //int sayi = 21;

            //// Sayı Değişkeni İçindeki Veri 10 İle 20 Arasında Mı?
            //Console.Write("Sayı = ");
            //Console.WriteLine(sayi);

            //Console.Write("10'dan Büyük Mü? = ");
            //Console.WriteLine(sayi > 10);

            //Console.Write("20'den Küçük Mü? = ");
            //Console.WriteLine(sayi < 20);

            //Console.Write("10 İle 20 Arasında Mı? = ");
            //Console.WriteLine(sayi > 10 && sayi < 20);
            #endregion
        }
    }
}
