using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlarOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PeriyodikTablo periyodikTablo = new PeriyodikTablo();

            //Console.WriteLine(periyodikTablo.AtomAdlari.Length);
            //Console.WriteLine(periyodikTablo.AtomSembolleri.Length);
            //Console.WriteLine(periyodikTablo.KutleNumaralari.Length);
            //Console.WriteLine(periyodikTablo.Ketegoriler.Length);

            for (int i = 0; i < periyodikTablo.AtomAdlari.Length; i++)
            {
                Console.WriteLine($"{periyodikTablo.AtomAdlari[i]} ({periyodikTablo.AtomSembolleri[i]}) - {periyodikTablo.KutleNumaralari[i]} / {periyodikTablo.Ketegoriler[i]}");
            }
        }
    }
}
