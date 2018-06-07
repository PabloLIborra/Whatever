using MvcApplication1.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using WebMatrix.WebData;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.EN.Whatever;

namespace MvcApplication1
{
    // Nota: para obtener instrucciones sobre cómo habilitar el modo clásico de IIS6 o IIS7, 
    // visite http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            if (!Roles.RoleExists("usuario"))
            {
                Roles.CreateRole("usuario");
            }
            if (!Roles.RoleExists("admin"))
            {
                Roles.CreateRole("admin");
            }

            


            AreaRegistration.RegisterAllAreas();
            

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();
        }
    }
}