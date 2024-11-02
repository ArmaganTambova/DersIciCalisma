using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MerhabaMVC.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default

        // Temel Olarak Listeleme Yapılacak Olan Sayfaları Temsil Eder

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        // Bu Function Ekle Sayfası Açılırken Otomatik Olarak Çalışır
        public ActionResult Ekle()
        {
            return View(); // View'e Git
        }

        [HttpPost]
        // Bu Function Ekle Sayfasındaki Herhangi Bir Post İşleminden Sonra Çalışır
        public ActionResult Ekle(string isim, double fiyat)
        {
            // Metotdun Aldığı Parametreler View İçerisindeki Araçların name Özelliği İle Aynı Olmalıdır
            // Verileri Controller'a Otomatik Olarak Taşır
            return View();
        }
    }
}