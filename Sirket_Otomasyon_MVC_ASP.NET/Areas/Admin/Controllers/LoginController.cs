using Sirket_Otomasyon_MVC_ASP.NET.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sirket_Otomasyon_MVC_ASP.NET.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        SirketContext ctx = new SirketContext();

        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Sirket_Otomasyon_MVC_ASP.NET.Models.Admin a)
        {
            HttpContext.Session.Add("kullanici", a.adminKulAd); //session oluşturduk
            HttpContext.Session.Add("sifre", a.adminKulSif);


            using (SirketContext ctx = new SirketContext())
            {
                var adminList = ctx.Adminler.Find(1);


                if ((adminList.adminKulAd == a.adminKulAd) && (adminList.adminKulSif == a.adminKulSif))
                {


                    return RedirectToAction("Ekle", "Musteri", new { area = "" });
                }


            }

            return RedirectToAction("Index");




        }

    }
}