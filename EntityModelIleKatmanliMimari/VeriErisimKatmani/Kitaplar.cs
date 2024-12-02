using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriErisimKatmani
{
    public class Kitaplar
    {
        public int ID {  get; set; }
        public short SiraNo {  get; set; }
        public int TurID { get; set; }
        public int YayinEviID { get; set; }
        public int DilID { get; set; }
        public string Isim {  get; set; }
        public string Barkod { get; set; }
    }
}
