using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Sirket_Otomasyon_MVC_ASP.NET
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start() //uygulama baþlayýnca çalýþýr
        {
            AreaRegistration.RegisterAllAreas();

            RouteConfig.RegisterRoutes(RouteTable.Routes);//rota routeconfig de oluþturuluyor

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters); //programý mvc project olarak açýnca eklendiler
          
            BundleConfig.RegisterBundles(BundleTable.Bundles);


        }
    }
}
