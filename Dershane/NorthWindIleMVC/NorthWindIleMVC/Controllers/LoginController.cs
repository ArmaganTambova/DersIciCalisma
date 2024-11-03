using NorthWindIleMVC.Models;
using NorthWindIleMVC.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthWindIleMVC.Controllers
{
    public class LoginController : Controller
    {
        NORTHWNDEntities DB = new NORTHWNDEntities();

        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                Employees Employee = DB.Employees.FirstOrDefault(E => E.UserName == model.Username && E.Password == model.Password);

                if (Employee != null)
                {
                    Session["Employee"] = Employee;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.Error = "Kullanıcı Bulunamadı";
                }
            }

            return View();
        }
    }
}