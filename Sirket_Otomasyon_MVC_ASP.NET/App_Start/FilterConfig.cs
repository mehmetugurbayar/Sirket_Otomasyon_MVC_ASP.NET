﻿using System.Web;
using System.Web.Mvc;

namespace Sirket_Otomasyon_MVC_ASP.NET
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
