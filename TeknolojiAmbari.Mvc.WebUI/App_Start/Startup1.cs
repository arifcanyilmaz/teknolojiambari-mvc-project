using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System;
using System.Threading.Tasks;

[assembly: OwinStartup(typeof(TeknolojiAmbari.Mvc.WebUI.App_Start.Startup1))]

namespace TeknolojiAmbari.Mvc.WebUI.App_Start
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions()
            {
                AuthenticationType = "ApplicationCooki",
                LoginPath = new PathString("/Account/Login")
            }); ;
        }
    }
}
