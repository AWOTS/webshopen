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
        public ActionResult AdminPage()
        {
            return View();
        }

        public ViewResult _AdminLogin()
        {
            return View();
        }
    }
}