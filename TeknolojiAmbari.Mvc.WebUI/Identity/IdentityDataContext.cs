using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeknolojiAmbari.Mvc.WebUI.Entity;

namespace TeknolojiAmbari.Mvc.WebUI.Identity
{
    public class IdentityDataContext : IdentityDbContext<ApplicationUser>
    {
        public IdentityDataContext() : base("dataConnection")
        {
            
        }
    }
}