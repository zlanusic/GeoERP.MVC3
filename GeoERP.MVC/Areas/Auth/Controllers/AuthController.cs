﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GeoERP.MVC.Areas.Auth.Models;

namespace GeoERP.MVC.Areas.Auth.Controllers
{
    public class AuthController : Controller
    {
        //
        // GET: /Auth/Auth/

        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Potrebno za swapping _login view(formu)
        /// </summary>
        /// <returns>Parcijalni view _Login</returns>
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// Prijavljuje korisnika.
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Login(LoginModel model)
        {
            //RedirectToAction("AdminCompany", "Admin");
            //return View();

            return null;
        }

        public ActionResult LogOff()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

    }
}
