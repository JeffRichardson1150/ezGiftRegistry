using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ezGift.WebMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Save time and be confident your gift will be loved.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "We're here to help you.";

            return View();
        }
    }
}