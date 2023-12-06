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
            string[] PeriyodikTabloListesi = new string[118];

            PeriyodikTablo Hydrogen = new PeriyodikTablo();
            Hydrogen.AtomAdlari = "Hydrogen";
            Hydrogen.AtomSembolleri = "H";
            Hydrogen.KutleNumaralari = 1;
            Hydrogen.Kategoriler = "";
        }
    }
}
