using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MacDevelopments.Controllers
{
    public class ServicesController : Controller
    {
        public ActionResult Index()
        {
            return View("Company/About");
        }

        public ActionResult Summary()
        {
            return View();
        }
    }
}