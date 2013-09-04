using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using GeoERP.MVC.ServiceGeoCloud;
using GeoERP.MVC.Areas.Admin.Models;
using System.Web.Helpers;

// --using WebAPI implementation  
namespace GeoERP.MVC.Areas.Admin.Controllers
{
    /// <summary>
    /// Pristup Admin kontroleru imaju samo admin korisnici.
    /// </summary>
    //[Authorize (Roles = "Admin")]
    public class AdminController : Controller
    {
        #region Private Members

        // --Proxy klasa
        private static ServiceGeoCloudClient _serviceGeoCloudClient;

        #endregion

        /// <summary>
        /// Konstruktor
        /// </summary>
        public AdminController()
        {
            // --Proxy objekt
            _serviceGeoCloudClient = new ServiceGeoCloudClient();
        }

        //
        // GET: /Admin/Admin/
        public ActionResult Index()
        {
            return View();
        }

        #region Custom Action Methods

        /// <summary>
        /// Prikaz glavnog meni-a i svih podataka o tvrtki(samo ako je korisnik admin rola!!).
        /// </summary>
        /// <returns></returns>
        [HttpGet, ActionName("Company")]
        public ActionResult AdminCompanyDetails()
        {
            return View();
        }

        #endregion

        #region ProfileView

        /// <summary>
        /// Dohvat forme sa podacima pomoću ajax poziva za izmjenu profila korisnika.
        /// Ne koristimo server post back sindrom!!
        /// </summary>
        /// <returns></returns>
        [AcceptVerbs(HttpVerbs.Get), ActionName("Profile")]
        public ActionResult GetProfileDetails(int? idProfile)
        {
            //try
            //{
            //    _serviceGeoCloudClient.Open();
            //    _serviceGeoCloudClient.DohvatiFirmu(null, 1);
            //    _serviceGeoCloudClient.Close();
            //}
            //catch (Exception)
            //{
                
            //    return new JsonResult{ Data = new { success = "Fail", msg = "Greška pri dohvatu podataka sa servera!"}, JsonRequestBehavior = JsonRequestBehavior.AllowGet};
            //}

            //return new JsonResult { Data = new { success = "Succesfully", msg = "Uspješan dohvat Vaših podataka!" }, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

            return View();
        }

        /// <summary>
        /// Edit podataka na profilu tvrtke svakog korisnika pomoću ajax poziva.
        /// Ne koristimo server post back sindrom!!
        /// </summary>
        /// <param name="modelToUpdate">POCO klasa.</param>
        /// <returns>Vraća će Json objekt.</returns>
        [AcceptVerbs(HttpVerbs.Post), ActionName("Profile")]
        public JsonResult EditProfileDetails(ProfileModel modelToUpdate)
        {
            try
            {
                // --Otvara konekciju prema servisu.
                _serviceGeoCloudClient.Open();

                // --Pozivamo metodu iz servisa i ažuriramo podatke.
                _serviceGeoCloudClient.UnesiNovuFirmu(null, modelToUpdate.FullName, modelToUpdate.ShortName,
                    modelToUpdate.City, modelToUpdate.Address,
                    modelToUpdate.Phone, modelToUpdate.Mobile, modelToUpdate.Fax,
                    modelToUpdate.Email1, modelToUpdate.Email2, modelToUpdate.Email3, modelToUpdate.Url,
                    modelToUpdate.OibNum, modelToUpdate.Mb,
                    modelToUpdate.PdvNum, null, null, modelToUpdate.Owner, null, null, null, null, null);

                // --Zatvaramo konekciju sa servisom.
                _serviceGeoCloudClient.Close();
            }
            catch (Exception ex)
            {
                return new JsonResult { Data = new { success = false, msg = "Greška na serveru!" } };
            }

            return new JsonResult { Data = new { success = true, msg = "Podaci uspješno ažurirani!" } };
        }

        #endregion
        
    }
}
