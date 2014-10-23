using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MacDevelopments.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Demolition()
        {
            return View();
        }

        public ActionResult Construction()
        {
            return View();
        }

        public ActionResult Contracting()
        {
            return View();
        }
    }
}