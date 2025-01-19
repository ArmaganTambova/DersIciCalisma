using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApplicationProgramingInterfaceNedir.API
{
    public class DefaultController : ApiController
    {
        // Sunucuda Sadece Veri Çekmek İsteniyorsa "GET" Metodunu Kullanmamız Tavsiye Edilir

        public string Get()
        {
            return SelamVer();
        }

        // Get      : Sunucudan Veri Çekmek İstediğimizde Kullanmamız Tavsiye Edilir
        // Post     : Api'ye Veri Göndermek İstediğimizde Kullanırız
        // Put      : Genelikle Update İşlemlerinde Kullanılması Tavsiye Edilir
        // Delete   : Crud İşlemlerinde Delete Yapılmak İstenildiğinde Kullanılması Tavsiye Edilir

        public string Post(string Isim)
        {
            if (!string.IsNullOrEmpty(Isim))
            {
                return "Merhaba " + Isim + " Ben Api";
            }

            return "Tanışmıyoruz";
        }

        public string SelamVer()
        {
            return "Buyur Abi GETirdim";
        }
    }
}
