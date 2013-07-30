using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GeoERP.MVC.Areas.Register.Models;
using GeoERP.MVC.ServiceGeoCloud;

namespace GeoERP.MVC.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        private readonly ServiceGeoCloudClient _serviceGeoCloudClient;

        /// <summary>
        /// 
        /// </summary>
        public AdminController()
        {
            _serviceGeoCloudClient = new ServiceGeoCloudClient();
        }

        //
        // GET: /Admin/Admin/

        public ActionResult Index()
        {
            return View();
        }


        #region Bank

        /// <summary>
        /// Prikaz svih banaka u dropdownlist kendoUI kontroli.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult GetBank(int? id)
        {
            // --Proxy za WCF service
            _serviceGeoCloudClient.Open();

            // --test
            ViewBag.Banke = new string[]
            {
                "a", "b", "c"
            };

            // --logika

            _serviceGeoCloudClient.Close();

            return View();
        }

        /// <summary>
        /// Prikaz forme za dodavanje banke.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult AddBank()
        {
            return View();
        }

        /// <summary>
        /// Dodavanje nove banke kroz WCF servis.
        /// </summary>
        /// <param name="bank"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult AddBank(BankViewModel bank)
        {
            // --Proxy za WCF service
            _serviceGeoCloudClient.Open();

            //logika

            _serviceGeoCloudClient.Close();
            return View();
        }

        #endregion

    }
}
