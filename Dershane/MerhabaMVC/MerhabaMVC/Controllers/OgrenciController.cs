using MerhabaMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MerhabaMVC.Controllers
{
    public class OgrenciController : Controller
    {
        // GET: Ogrenci
        public ActionResult Listele()
        {
            List<Ogrenci> Ogrenciler = new List<Ogrenci>();
            Ogrenciler.Add(new Ogrenci() { Id = 1, Isim = "Mazlum", Soyisim = "Altan" });
            Ogrenciler.Add(new Ogrenci() { Id = 2, Isim = "Elif Tuğçe", Soyisim = "Altaş" });
            Ogrenciler.Add(new Ogrenci() { Id = 3, Isim = "Ahmet", Soyisim = "Altay" });
            Ogrenciler.Add(new Ogrenci() { Id = 4, Isim = "Yaşar Utku Anıl", Soyisim = "Altın" });
            Ogrenciler.Add(new Ogrenci() { Id = 5, Isim = "Alperen", Soyisim = "Fidan" });
            return View(Ogrenciler);
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ekle(Ogrenci model)
        {
            return View();
        }
    }
}