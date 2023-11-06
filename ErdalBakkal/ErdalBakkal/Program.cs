using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErdalBakkal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Uygulama 1
            string[] Urunler = { "Domates", "Biber", "Soğan", "Yumurta", "Doritos", "Kola", "Ekmek" };
            double[] Fiyatlar = { 59.99, 49.90, 14.90, 3, 31.95, 45, 7 };

            for (int i = 0; i < Urunler.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {Urunler[i]} {Fiyatlar[i]} TL");
            }
            #endregion
        }
    }
}
