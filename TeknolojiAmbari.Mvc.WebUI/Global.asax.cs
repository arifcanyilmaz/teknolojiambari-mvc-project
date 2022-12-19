using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using TeknolojiAmbari.Mvc.WebUI.Entity;
using TeknolojiAmbari.Mvc.WebUI.Identity;

namespace TeknolojiAmbari.Mvc.WebUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            Database.SetInitializer(new DataInitializer());
            Database.SetInitializer(new IdentityInitializer());
        }
    }
}
