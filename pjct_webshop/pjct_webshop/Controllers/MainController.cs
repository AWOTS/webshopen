using pjct_webshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pjct_webshop.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Butik()
        {
            return View();
        }

        public ActionResult Info()
        {
            return View();
        }
        public ActionResult Kassa()
        {
            return View();
        }

        public ActionResult Heminredning()
        {
            return View();
        }

        public ActionResult Smycken()
        {
            return View();
        }

        public ActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AdminLogin(string name, string password)
        {
            if ("admin".Equals(name) && "123".Equals(password))
            {
                Session["user"] = new User() {Login = name, Name = "Nico-Lina Wernholm"};
                return RedirectToAction("AdminPage", "Main");
            }
            return View();
        }

        public ActionResult AdminPage()
        {
            return View();
        }
    }
}