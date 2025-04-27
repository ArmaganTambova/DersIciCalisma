using JQueryAJAXKullanimi.Models;
using JQueryAJAXKullanimi.Models.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JQueryAJAXKullanimi.Controllers
{
    public class DefaultController : Controller
    {
        private readonly AJAXTestModel DB = new AJAXTestModel();

        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SehirGetir()
        {
            return View();
        }

        [HttpGet]
        public ActionResult SehirİlceSec()
        {
            ViewBag.City_ID = new SelectList(DB.Cities, "ID", "Name");

            ViewBag.County_ID = new SelectList(DB.Counties.Where(X => X.City_ID == 1), "ID", "Name");

            return View();
        }

        public JsonResult LoadCounties(int City_ID)
        {
            List<County> counties = DB.Counties.Where(X => X.City_ID == City_ID).ToList();

            var SelectListItems = counties.Select(X => new { ID = X.ID, Name = X.Name });

            return Json(SelectListItems, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult getCity(int ID)
        {
            City C = DB.Cities.FirstOrDefault(X => X.ID == ID);

            //CityDTO cdto = new CityDTO { ID = C.ID, Name = C.Name };
            var cdto = new { ID = C.ID, Name = C.Name }; // Annonymous Type

            return Json(cdto, JsonRequestBehavior.AllowGet);
        }
    }
}