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

        public static List<Produkt_model> varukorgsList = new List<Produkt_model>();

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
            AllProduct_model ap = new AllProduct_model();
            ap.GetAll();
            List<Produkt_model> modelList = new List<Produkt_model>();
            modelList.AddRange(ap.lista.FindAll(x => x.Type.Equals("Heminredning")));
            return View(modelList);
        }

        public ActionResult Heminredning()
        {
            AllProduct_model ap = new AllProduct_model();
            ap.GetAll();
            List<Produkt_model> modelList = new List<Produkt_model>();
            modelList.AddRange(ap.lista.FindAll(x => x.Type.Equals("Heminredning")));
            return View(modelList);
        }

        public ActionResult Halsband()
        {
            AllProduct_model ap = new AllProduct_model();
            ap.GetAll();
            List<Produkt_model> modelList = new List<Produkt_model>();
            modelList.AddRange(ap.lista.FindAll(x => x.Type.Equals("Halsband")));
            return View(modelList);
        }

        public ActionResult Ringar()
        {
            AllProduct_model ap = new AllProduct_model();
            ap.GetAll();
            List<Produkt_model> modelList = new List<Produkt_model>();
            modelList.AddRange(ap.lista.FindAll(x => x.Type.Equals("Ringar")));
            return View(modelList);
        }

        public ActionResult Örhängen()
        {
            AllProduct_model ap = new AllProduct_model();
            ap.GetAll();
            List<Produkt_model> modelList = new List<Produkt_model>();
            modelList.AddRange(ap.lista.FindAll(x => x.Type.Equals("Örhängen")));
            return View(modelList);
        }

        public ActionResult Armband()
        {
            AllProduct_model ap = new AllProduct_model();
            ap.GetAll();
            List<Produkt_model> modelList = new List<Produkt_model>();
            modelList.AddRange(ap.lista.FindAll(x => x.Type.Equals("Armband")));
            return View(modelList);
        }

        public ActionResult Töjningar()
        {
            AllProduct_model ap = new AllProduct_model();
            ap.GetAll();
            List<Produkt_model> modelList = new List<Produkt_model>();
            modelList.AddRange(ap.lista.FindAll(x => x.Type.Equals("Töjningar")));
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

        public ActionResult SearchResult()
        {
            AllProduct_model products = new AllProduct_model();
            return View();
        }
    }
}