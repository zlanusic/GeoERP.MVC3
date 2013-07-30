using System.Web.Mvc;

namespace GeoERP.MVC.Areas.Register
{
    /// <summary>
    /// Admin area routing klasa za registraciju.
    /// </summary>
    public class RegisterAreaRegistration : AreaRegistration
    {
        /// <summary>
        /// Naziv area-e: Admin.
        /// </summary>
        public override string AreaName
        {
            get
            {
                return "Register";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            // --Custom routing
            context.MapRoute(null, "register", new {controller = "Register", action = "Index"});
            context.MapRoute(null, "register/addcompany", new {controller = "Register", action = "AddCompany"});
            context.MapRoute(null, "register/getbank", new {controller = "Register", action = "GetBank"});

            // --Default routing
            context.MapRoute(
                "Register_default",
                "Register/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
