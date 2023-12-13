using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// namespace
// Kod Kütüphaneleri "using" İle Eklenir
// ArrayList System.Collections namespace'si İçerisinde Bulunur
using System.Collections;

namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Nedir?
            /*
             Öyle Bir Dizi Hayal Edin Ki...
             * Eleman Sayısı Artsın
             * Ekle Diyince Sona Eklesin
             * Sil Diyince Silsin
             * Bul Diyince Var Abi Desin
             * Nerede Diyince Yerini Göstersin
             * Araya Eleman Ekle Diyince Eklesin
             * Ve Bunları Tür Bağımsız Olarak Yapsın
             İşte Bunların Hepsini Yapabilen
             Mucize Ürün Geldi...
             ArrayList Karşınızda
            */
            #endregion

            // Tüm Türler "object" Türünden Doğarlar
            // "object" Tür Güvenliğini Bozar

            ArrayList Liste = new ArrayList();
            Liste.Add("Süleyman");
            Liste.Add("Şuayip");
            Liste.Add("Murtaza");
            Liste.Add("Kezban");
            Liste.Add("Remziye");
            Liste.Add(45);
            Liste.Add(12.9);
            Liste.Add(60);
            Liste.Insert(3, "Kahraman");
            Liste.AddRange(new string[] { "Araba", "Bisiklet", "Korna"});

            Console.WriteLine($"Dizinin Eleman Sayısı = {Liste.Count}");
            Console.WriteLine($"Dizinin Kapasitesi =  {Liste.Capacity}");

            for (int i = 0; i < Liste.Count; i++)
            {
                Console.WriteLine(Liste[i]);
            }
        }
    }
}
