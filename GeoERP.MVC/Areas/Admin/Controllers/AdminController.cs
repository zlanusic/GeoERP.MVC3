using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using GeoERP.MVC.Areas.Admin.Models;

namespace GeoERP.MVC.Areas.Admin.Controllers
{
    /// <summary>
    /// Pristup Admin kontroleru imaju samo admin korisnici.
    /// </summary>
    //[Authorize (Roles = "Admin")]
    public class AdminController : Controller
    {
        //
        // GET: /Admin/Admin/

        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Prikaz glavnog meni-a i svih podataka o tvrtki(samo ako je korisnik admin rola).
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult AdminCompany()
        {
            return View();
        }

        /// <summary>
        /// Dohvat forme sa podacima za izmjenu profila korisnika.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public PartialViewResult _EditProfil()
        {
            return PartialView();
        }

        /// <summary>
        /// Edit podataka na profilu korisnika.
        /// </summary>
        /// <param name="model">POCO klasa.</param>
        /// <returns>Vraca Json objekt.</returns>
        [HttpPost]
        public ActionResult _EditProfil(ProfilModel model)
        {
            return View();
        }

    }
}
