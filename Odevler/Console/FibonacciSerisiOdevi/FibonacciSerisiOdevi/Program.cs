using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSerisiOdevi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> Sayilar = new List<double>();

            double Sayi = 0;
            double Onceki = 0;
            double Toplam = 0;

            Console.WriteLine("Lütfen Seriyi Hangi Basamağa Kadar Götürmek İstediğinizi Giriniz");
            double Basamak = Convert.ToDouble(Console.ReadLine());

            for (int i = 0; i <= Basamak; i++)
            {
                if (Sayi == 0)
                {
                    Sayi += 1;
                    Onceki = 0;
                }
                else
                {
                    Toplam = Sayi + Onceki;
                    Console.WriteLine($"{i}) {Onceki} + {Sayi} = {Toplam}");
                    Sayilar.Add(Toplam);
                    Onceki = Sayi; Sayi = Toplam;
                }
            }

            Console.WriteLine("**********    **********");

            for (int i = 0; i < Sayilar.Count; i++)
            {
                Console.Write($"{Sayilar[i]}, ");
            }
        }
    }
}
