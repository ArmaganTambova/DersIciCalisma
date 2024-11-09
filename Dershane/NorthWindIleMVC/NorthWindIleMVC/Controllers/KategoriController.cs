using NorthWindIleMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthWindIleMVC.Controllers
{
    public class KategoriController : Controller
    {
        NORTHWNDEntities DB = new NORTHWNDEntities();

        // GET: Kategori
        public ActionResult Index()
        {
            List<Categories> categories = DB.Categories.ToList();
            return View(categories);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Categories model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    DB.Categories.Add(model);
                    DB.SaveChanges();
                    ViewBag.Message = "Ekleme Başarılı";
                    ViewBag.Status = "1";
                }
                catch
                {
                    ViewBag.Message = "Ekleme Başarılı Değil";
                    ViewBag.Status = "0";
                }
            }

            return View();
        }

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            Categories c = DB.Categories.Find(Id);

            if (c != null)
            {
                return View(c);
            }

            return RedirectToAction("Index", "Kategori");
        }

        [HttpPost]
        public ActionResult Edit(Categories model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    DB.Entry(model).State = EntityState.Modified;
                    DB.SaveChanges();
                    ViewBag.Message = "Başarıyla Güncellendi";
                    ViewBag.Status = "1";
                }
                catch
                {
                    ViewBag.Message = "Güncelleme Tamamlanmadı";
                    ViewBag.Status = "0";
                }
            }

            return View();
        }
    }
}