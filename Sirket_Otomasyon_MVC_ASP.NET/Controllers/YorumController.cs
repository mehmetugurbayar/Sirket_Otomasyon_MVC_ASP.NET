using Sirket_Otomasyon_MVC_ASP.NET.DAL;
using Sirket_Otomasyon_MVC_ASP.NET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sirket_Otomasyon_MVC_ASP.NET.Controllers
{
    public class YorumController : Controller
    {
        // GET: Yorum
        public ActionResult Index()
        {
            return View();
        }

        SirketContext ctx;
   public ActionResult Yorum()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Yorum(Yorum y)
        {
            if (ModelState.IsValid)
            {
                using (ctx = new SirketContext())
                {
                    ctx.Yorumlar.Add(y);
                    if (ctx.SaveChanges() > 0)
                    {
                        return RedirectToAction("Oku");
                    }

                }
            }
                

            return View();
        }

        public ActionResult Oku()
        {
            using (ctx = new SirketContext())
            {
             var YorumlarList = ctx.Yorumlar.ToList();
                return View(YorumlarList);
            }

        }

        public ActionResult Sil(int? id)
        {

            if ((Session["kullanici"] == null) || (Session["sifre"] == null)) //giriş yapılmamışsa silinmez

            {
                return RedirectToAction("Login", "Admin");
            }
            using (ctx = new SirketContext())
            {
                ctx.Yorumlar.Remove(ctx.Yorumlar.Find(id));

                ctx.SaveChanges();
                return RedirectToAction("Oku");



            }

        }

    }
}