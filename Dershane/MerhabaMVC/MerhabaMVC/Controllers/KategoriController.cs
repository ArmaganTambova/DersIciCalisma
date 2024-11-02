using MerhabaMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MerhabaMVC.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori
        public ActionResult Listele()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ekle(Kategori model)
        {
            if (ModelState.IsValid)
            {

            }

            return View();
        }
    }
}