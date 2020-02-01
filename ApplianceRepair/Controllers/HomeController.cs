using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApplianceRepair.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Services()
        {
            ViewBag.Message = "My Services.";

            return View();
        }

        public ActionResult Blog()
        {
            ViewBag.Message = "My Blog.";

            return View();
        }
    }
}