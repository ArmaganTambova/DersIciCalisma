using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    public class Cirak
    {
        public void SelamVer()
        {
            Console.WriteLine("Ustamın Selamı Var");
        }

        // Parametre Alan Metot
        // Parametre Nedir? Metodun Çağırıldığı Alandan Netoda Kullanması İçin Gönderilen Veriyi Tutan Değişkene Parametre Denir
        public void IsmeSelamVer(string Isim)
        {
            Console.WriteLine($"{Isim} Abi Ustamın Selamı Var");
        }
    }
}
