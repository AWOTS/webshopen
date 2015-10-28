using pjct_webshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;

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
            AllProduct_model ap = new AllProduct_model();
            ap.GetAll();
            List<Produkt_model> modelList = new List<Produkt_model>();
            modelList.AddRange(ap.lista.FindAll(x => x.type.Equals("Heminredning")));
            return View(modelList);
        }

        public ActionResult Halsband()
        {
            AllProduct_model ap = new AllProduct_model();
            List<Produkt_model> modelList = new List<Produkt_model>();
            modelList.AddRange(ap.lista.FindAll(x => x.type == "Halsband"));
            return View(modelList);
        }
        public ActionResult Ringar()
        {
            AllProduct_model ap = new AllProduct_model();
            List<Produkt_model> modelList = new List<Produkt_model>();
            modelList.AddRange(ap.lista.FindAll(x => x.type == "Ringar"));
            return View(modelList);
        }
        public ActionResult Örhängen()
        {
            AllProduct_model ap = new AllProduct_model();
            List<Produkt_model> modelList = new List<Produkt_model>();
            modelList.AddRange(ap.lista.FindAll(x => x.type == "Örhängen"));
            return View(modelList);
        }
        public ActionResult Töjningar()
        {
            AllProduct_model ap = new AllProduct_model();
            List<Produkt_model> modelList = new List<Produkt_model>();
            modelList.AddRange(ap.lista.FindAll(x => x.type == "Töjningar"));
            return View(modelList);
        }

        public ActionResult AdminLogin()
        {
            return View();
        }

        UserLogic UL = new UserLogic();
        User UserClass = new User();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AdminLogin(User u)
        {
            string message = "";
            if (!ModelState.IsValid)
            {
                return View(u);
            }
            else if (ModelState.IsValid)
            {
                if (UL.CheckUserLogin(u) > 0)
                {
                    return RedirectToAction("AdminPage", "Main");
                }
                else
                {
                    message = "Användarnamnet eller lösenordet var ingen succé.";
                }
            }

            else
            {
                message = "Alla fält måste vara ifyllda.";
            }

            if (Request.IsAjaxRequest())
            {
                return Json(message, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return RedirectToAction("AdminLogin", "Main");
            }

        }

        public ActionResult AdminPage()
        {
            return View();
        }
    }
}