using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriErisimKatmani
{
    public class Tur
    {
        // ENTITY MODEL YAKLAŞIMI
        // Veritabanındaki Tabloların İçindeki Her Satır Verinin C# Kısmında Nesne Olarak Kullanılmasını Sağlamak Amacıyla, Her Tablonun Sınıf Karşılığını Oluşturuyoruz
        // Veriler Dağınık Bir Şekilde Değil, Sınıf Nesnesi Olarak Taşındığı İçin CleanCode Yapısına Uygun Kodlama Sağlanmış Olur

        public int ID {  get; set; }

        public string Isim { get; set; }
    }
}
