using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace vidz.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Vidz Corp";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact:";

            return View();
        }
    }
}