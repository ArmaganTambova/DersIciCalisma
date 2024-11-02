using MerhabaMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MerhabaMVC.Controllers
{
    public class VeriTasimaController : Controller
    {
        // GET: VeriTasima
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            Ogrenci ogr = new Ogrenci();
            ogr.Id = 1;
            ogr.Isim = "Murtaza";
            ogr.Soyisim = "Şuayipoğlu";

            ViewBag.IsimSoyad = "Alperen Fidan";

            TempData["İsim Soyad"] = "Ayşehan Muhteşemgil";

            ViewBag.Ogrenci = ogr; // Unboxing İle Alınacak

            return View(ogr);
        }

        [HttpPost]
        public ActionResult Ekle(Ogrenci model)
        {
            return View();
        }
    }
}