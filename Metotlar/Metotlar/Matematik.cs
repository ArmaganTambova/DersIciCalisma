using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    public class Matematik
    {
        // Kendisine Gönderilen 2 Sayının Toplamını Yazdıran Metot
        public void İkiSayiToplam(int Sayi1, int Sayi2)
        {
            int Toplam = Sayi1 + Sayi2;
            Console.WriteLine($"Toplam = {Toplam}");
        }

        // Kendisine Gönderilen Sayının Karesini Yazdıran Metot
        public void SayininKaresiniYaz(int Sayi)
        {
            int Karesi = Sayi * Sayi;
            Console.WriteLine($"Sayının Karesi = {Karesi}");
        }

        /*
         * Metotlar Çağırıldıkları Alana Veri Döndürebilirler
         * Bunun İçin Metodun "void" Olan Kımsını Döndürülecek Olan Verinin Türü İle Değiştiriyoruz
          
         * "void" = Metot Geriye Veri Döndürmüyor Anlamında Kullanılır
         * Geriye Veri Döndüren Metotlar Mutlaka "return" Kullanmak Zorundadır
         * "return" İle Döndürülecek Verinin Türü Metot Geri Dönüş İle Aynı Olmalıdır
        */
        public int SayininKaresiniDondur(int Sayi)
        {
            int Karesi = Sayi * Sayi;
            return Karesi;
        }

        // Kendisine Gönderilen Sayının Asal Olup Olmadığını Kontrol Eden Metot
        public bool AsalKontrol(int Sayi)
        {
            if (Sayi == 0 || Sayi == 1)
            {
                return false;
            }

            bool AsalMi = true;

            for (int i = 2; i < Sayi; i++)
            {
                if (Sayi % i == 0)
                {
                    AsalMi = false;
                    break;
                }
            }

            return AsalMi;
        }

        #region Ödev, 2-20
        // 2 İle 20 Arasındaki İkiz Asalları Bulan Metot
        public string IkizAsalKontrol()
        {
        }
        #endregion

        // Kendisine Gönderilen Taban Ve Üst Değeri İle Sayının Kuvvetini Hesaplayan Metot
        public int KuvvetHesaplama(int Taban, int Üs)
        {
            if (Üs == 1)
            {
                return Taban;
            }

            if (Üs == 0)
            {
                return 1;
            }

            int Sayi = 0;

            for (int i = 1; i < Üs; i++)
            {
                Sayi += Taban * Üs;
                Taban = Sayi;
            }

            return Sayi;
        }
    }
}
