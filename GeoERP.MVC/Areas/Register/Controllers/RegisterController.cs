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
        
        /// <summary>
        /// Enkripcija podataka na klijentu.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        //public static string AesDecrypt(object obj)
        //{
        //    RijndaelManaged aes = new RijndaelManaged();
        //    MD5CryptoServiceProvider hashAes = new MD5CryptoServiceProvider();
        //    try
        //    {
        //        byte[] hash = new byte[32];
        //        byte[] temp = hashAes.ComputeHash(buffer: System.Text.Encoding.ASCII.GetBytes(pass));
        //        Array.Copy(temp, 0, hash, 0, 16);
        //        Array.Copy(temp, 0, hash, 15, 16);
        //        aes.Key = hash;
        //        aes.Mode = CipherMode.ECB;
        //        var desDecrypter = aes.CreateDecryptor();
        //        byte[] buffer = Convert.FromBase64String(input);
        //        string decrypted = System.Text.Encoding.ASCII.GetString(desDecrypter.TransformFinalBlock(buffer, 0, buffer.Length));
        //        return decrypted;
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //}

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

        /// <summary>
        /// Potrebno za swapping _registerCompany view(formu).
        /// </summary>
        /// <returns>Parcijalni _registerCompany view.</returns>
        public PartialViewResult _RegisterCompany()
        {
            return PartialView();
        }

        /// <summary>
        /// Registracija korisnika.
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult _RegisterCompany(RegisterModel model)
        {
            
            // --Proxy za WCF service
            _serviceGeoCloudClient.Open();

            //string encrypt = AesDecrypt();

            // --Podaci iz kontrola
            //int customerId = Request.Form["CustomerId"];

            string email1 = Request.Form["email"].Trim();
            string userName = Request.Form["userName"].Trim();
            string firstName = Request.Form["firstName"].Trim();
            string lastName = Request.Form["lastName"].Trim();
            string userPwd1 = Request.Form["userPwd1"].Trim();
            string userPwd2 = Request.Form["userPwd2"].Trim();

            
            try
            {
                // --logika
            }
            catch (NullReferenceException exception)
            {
                // --implementacija iznimke
                throw;
                
            }
            
            _serviceGeoCloudClient.Close();
            return View();
        }
    }
}
