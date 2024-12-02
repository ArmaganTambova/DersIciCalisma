using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechLib.Filters;
using TechLib.Models;
using System.Text;
using System.Security.Cryptography;
using TechLib.Models.ModelView;

namespace TechLib.Controllers
{
    public class LoginController : Controller
    {
        TechLib_DBEntities DB = new TechLib_DBEntities();

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
                byte[] hashedPassword = PasswordHash.ComputeSha256HashBinary(model.UserPassword);

                Users user = DB.Users.FirstOrDefault(U => U.ID == model.ID);

                if (user != null && user.UserPassword.SequenceEqual(hashedPassword))
                {
                    Session["UserID"] = user.ID;
                    Session["UserRole"] = user.UserRole;

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.Message = "Invalid Number or Password, Please Try Again";
                }
            }

            return View();
        }
    }
}