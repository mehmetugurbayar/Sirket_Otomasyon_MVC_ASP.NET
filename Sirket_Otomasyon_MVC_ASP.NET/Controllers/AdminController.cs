using Sirket_Otomasyon_MVC_ASP.NET.DAL;
using Sirket_Otomasyon_MVC_ASP.NET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sirket_Otomasyon_MVC_ASP.NET.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Login()
        {

            return View();
        }

  

        [HttpPost]
        public ActionResult Login(Admin a) //admin türünde veri alırız
        {
            HttpContext.Session.Add("kullanici", a.adminKulAd); //session oluşturduk
            HttpContext.Session.Add("sifre", a.adminKulSif);



            using (SirketContext ctx = new SirketContext())
                {
                    var adminList = ctx.Adminler.Find(1); //id si 1 olan admin i getir
                    /*dbsetten gelen admin bilgisi ile parametre olarak gelen admin karşılaştırılır*/

                    if ((adminList.adminKulAd == a.adminKulAd) && (adminList.adminKulSif == a.adminKulSif))
                    {
                       
                        return RedirectToAction("Ekle","Musteri");
                    }


                }
            
            
                return View();
            


        }
    }
}