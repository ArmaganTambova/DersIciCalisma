using DataAccsessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace merhabakatman
{
    class Program
    {
        static void Main(string[] args)
        {
            DataModel dm = new DataModel();
            //List<Kategoriler> kategoriler = dm.KategorilerListele();
            //dm.KategorilerYazdır(kategoriler);
            List<Urunler> urunler = dm.UrunListele();
            dm.UrunYazdir(urunler);

        }
    }
}
