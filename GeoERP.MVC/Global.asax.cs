using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace GeoERP.MVC
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    /// <summary>
    /// Klasa MVC aplikacije. Ovdje sve zapocinje...
    /// </summary>
    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        /// <summary>
        /// Definira routing koji mapira url na odgovarajucu action metodu.
        /// </summary>
        /// <param name="routes"></param>
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // -- Custom route - Home page
            //routes.MapRoute("home", "", new {controller = "Home", action = "Index"});

            // --Default route
            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL routing pattern with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter route defaults
            );

        }

        /// <summary>
        /// Ovdje zapocinje nasa aplikacija.
        /// App start event.
        /// </summary>
        protected void Application_Start()
        {
            // --Registriramo sve area-e
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);

            // --kolekcija ruta koje su definirane unutar aplikacije
            RegisterRoutes(RouteTable.Routes);
        }
    }
}