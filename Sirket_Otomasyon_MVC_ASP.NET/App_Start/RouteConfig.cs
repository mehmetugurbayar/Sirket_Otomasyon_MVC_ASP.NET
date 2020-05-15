using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Sirket_Otomasyon_MVC_ASP.NET
{
    public class RouteConfig //ROTALAMA işlemleri
    {
        public static void RegisterRoutes(RouteCollection routes) //rotaları collection olarak tutarız
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

           

            routes.MapRoute( //rotalar.Yenirota -- yeni rota eklerken bu şekilde
                name: "Default",
                url: "{controller}/{action}/{id}", //url pattern i
                
                defaults: new { controller = "Admin", action = "Login", id = UrlParameter.Optional }
              

            );

           
        }
    }
}
