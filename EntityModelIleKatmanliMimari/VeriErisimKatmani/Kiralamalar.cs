using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriErisimKatmani
{
    public class Kiralamalar
    {
        public int ID { get; set; }
        public int KitapID { get; set; }
        public DateTime KiralamaTarihi { get; set; }
        public DateTime TeslimTarihi { get; set; }
        public string Aciklamalar {  get; set; }
    }
}
