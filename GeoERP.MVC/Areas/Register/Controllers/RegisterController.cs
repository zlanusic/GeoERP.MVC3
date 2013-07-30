using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Security.Cryptography;

using GeoERP.MVC.Areas.Register.Models;
using GeoERP.MVC.ServiceGeoCloud;

namespace GeoERP.MVC.Areas.Register.Controllers
{
    /// <summary>
    /// Kontroler klasa za Register area-u.
    /// </summary>
    public class RegisterController : Controller
    {
        private readonly ServiceGeoCloudClient _serviceGeoCloudClient;
        
        private readonly RegisterCompanyViewModel _companyViewModel;
        private readonly PictureViewModel _pictureViewModel;

        public static string AesDecrypt(string input, string pass)
        {
            
        }

        public RegisterController()
        {
            _serviceGeoCloudClient = new ServiceGeoCloudClient();
        }

        //
        // GET: /Register/Register/

        public ActionResult Index()
        {
            return View();
        }

        #region Company

        /// <summary>
        /// Prikaz forme za registarciju tvrtke, 
        /// gdje korisnik unosi osnovne podatke.
        /// </summary>
        /// <returns>AddCompany view</returns>
        [HttpGet]
        public ActionResult AddCompany()
        {
            return View(new RegisterCompanyViewModel());
        }

        /// <summary>
        /// Registracija tvrtke kroz WCF servis.
        /// </summary>
        /// <param name="company">View model za tvrtku</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult AddCompany(RegisterCompanyViewModel company)
        {
            
            // --Proxy za WCF service
            _serviceGeoCloudClient.Open();

            // --Podaci iz kontrola
            //int customerId = Request.Form["CustomerId"];
            string fullName = Request.Form["FullName"].Trim();
            string shortName = Request.Form["ShortName"].Trim();
            string cityName = Request.Form["CityName"].Trim();
            string addressName = Request.Form["Address"].Trim();
            string director = Request.Form["Director"].Trim();
            string oibNumber = Request.Form["Oib"].Trim();
            string pdvNumber = Request.Form["PdvNum"].Trim();
            string mbNumber = Request.Form["PersonalNumber"].Trim();
            string phoneNumber = Request.Form["Phone"].Trim();
            string mobileNumber = Request.Form["Mobile"].Trim();
            string faxNumber = Request.Form["Fax"].Trim();
            string webAddress = Request.Form["WebPath"].Trim();
            string email1 = Request.Form["Email1"].Trim();
            string email2 = Request.Form["Email2"].Trim();
            string email3 = Request.Form["Email3"].Trim();
            //_pictureViewModel = Request.Form["PictureViewModel"];
            string userName = Request.Form["UserName"].Trim();
            string userPwd = Request.Form["UserPwd"].Trim();

            try
            {
                // --logika
                // --Prvi parametar je povratna vrijednost funkcije za enkripciju na klijentu(auth code koji fja vrati).
                // --Null vrijednosti se odnose na parametre vezani za banku.
                _serviceGeoCloudClient.UnesiNovuFirmu
                    (
                        "enkripcija", fullName, shortName, cityName, addressName
                        , phoneNumber, mobileNumber, faxNumber, email1, email2, email3, webAddress
                        , oibNumber, mbNumber, pdvNumber, null, null, director, null, null, userName, userPwd, null
                    );

            }
            catch (NullReferenceException exception)
            {
                // --implementacija iznimke
                throw;
                
            }
            
            _serviceGeoCloudClient.Close();
            return View(company);
        }

        #endregion

        


        #region UploadImages

        public ActionResult Save(IEnumerable<HttpPostedFileBase> attachments)
        {
            try
            {

                //if(attachments =! null)

                {
                    foreach (var file in attachments)
                    {
                        var fileName = Path.GetFileName(file.FileName);
                        var destinationPath = Path.Combine(Server.MapPath("~/App_Data"), fileName);

                        file.SaveAs(destinationPath);
                    }

                }
                // --vrati prazan string za ukoliko je upload prosao uspjesno
                return Content("");

            }
            catch (Exception)
            {

                throw;
            }
        }

        public ActionResult Remove(string[] fileNames)
        {
            try
            {
                foreach (var fullName in fileNames)
                {
                    var fileName = Path.GetFileName(fullName);
                    var physicalPath = Path.Combine(Server.MapPath("~/App_Data"), fileName);

                    // --implementirati user premissions

                    if (System.IO.File.Exists(physicalPath))
                    {
                        System.IO.File.Delete(physicalPath);
                    }
                }

                // --ako je delete bio uspjesan, vrati prazan string
                return Content("");

            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion


    }
}
