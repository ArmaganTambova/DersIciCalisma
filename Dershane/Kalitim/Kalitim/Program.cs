using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tanımlama
            //Kaltım  OOP(Object Orianted programming)'in oldulkça önemli bir parçasıdır.
            //Bir sınıfta diğerine fieldleri ve metodları miras bırakmak için kullanılır.
            //Base class birden çok sınıfa kalıtım yapabilir
            //Bir sınıf sadece bir sınıfa kalıtım yapabilir multiple desteklenemez.
            //Multiple Inhertance için arayüz(Interface) konusunu öğreneceğiz.
            #endregion

            #region Kullanım
            Personel Prs = new Personel();
            Prs.Isim = "Armağan";
            Prs.Soyisim = "Tambova";
            Prs.Departman = "Müdür";

            Ogrenci Ogr = new Ogrenci();
            Ogr.Isim = "Alperen";
            Ogr.Soyisim = "Fidan";
            Ogr.Okul = "Özel Matrix Yazılım Anadolu Lisesi";
            Ogr.Sinif = "11/D";
            #endregion
        }
    }
}
