using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeoERP.MVC.Controllers
{
    public class HomeController : Controller
    {
        // --GET: /Home/
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        // --GET: /Home/
        public PartialViewResult _About()
        {
            return PartialView();
        }

        // --GET: /Home/
        public PartialViewResult _Contact()
        {
            return PartialView();
        }

    }
}
