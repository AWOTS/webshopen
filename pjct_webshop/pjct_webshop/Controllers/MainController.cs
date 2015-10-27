using pjct_webshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using pjct_webshop.Models;
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
            List<Produkt_model> modelList = new List<Produkt_model>();
            modelList.AddRange(ap.lista.FindAll(x => x.type == "Heminredning"));
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AdminLogin(string name, string password)
        {
            var dbConnect = new DatabaseConnection();
            var dbCommand = new SqlCommand();

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