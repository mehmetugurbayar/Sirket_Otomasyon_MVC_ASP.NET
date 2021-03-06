﻿using Sirket_Otomasyon_MVC_ASP.NET.DAL;
using Sirket_Otomasyon_MVC_ASP.NET.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sirket_Otomasyon_MVC_ASP.NET.Controllers
{
    public class UrunController : Controller
    {
        // GET: Urun
        SirketContext ctx;
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Ekle()
        {

            if ((Session["kullanici"] == null) || (Session["sifre"] == null))

            {
                return RedirectToAction("Login", "Admin");
            }
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(Urun u)
        {
            if ((Session["kullanici"] == null) || (Session["sifre"] == null))

            {
                return RedirectToAction("Login", "Admin");
            }
            if (ModelState.IsValid) 
            {
                using (ctx = new SirketContext())
                {
                    ctx.Urunler.Add(u);

                    if (ctx.SaveChanges() > 0)
                    {
                        return RedirectToAction("Liste");
                    }
                    //ctx.SaveChanges();
                }
            }
            return View();
        }
        public ActionResult Liste()
        {

            if ((Session["kullanici"] == null) || (Session["sifre"] == null))

            {
                return RedirectToAction("Login", "Admin");
            }
            using (ctx = new SirketContext())
            {
                var urunler = ctx.Urunler.ToList(); 
                return View(urunler); 
            }

        }

        [HttpGet]
        public ActionResult Duzenle(int? id) 
        {
            if ((Session["kullanici"] == null) || (Session["sifre"] == null))
            
            {
                return RedirectToAction("Login", "Admin");
            }
            using (ctx = new SirketContext())
            {
                var urun = ctx.Urunler.Find(id);
                return View(urun);
            }
        }

        [HttpPost]
        public ActionResult Duzenle(Urun u)
        {

            if ((Session["kullanici"] == null) || (Session["sifre"] == null))

            {
                return RedirectToAction("Login", "Admin");
            }
            using (ctx = new SirketContext())
            {

                if (ModelState.IsValid)
                {

                    ctx.Entry(u).State = EntityState.Modified;

                    if (ctx.SaveChanges() > 0)
                    {

                        return RedirectToAction("Liste");
                    }
                }
                return View();

            }
        }

        public ActionResult Sil(int? id)
        {

            if ((Session["kullanici"] == null) || (Session["sifre"] == null))

            {
                return RedirectToAction("Login", "Admin");
            }
            using (ctx = new SirketContext())
            {
                ctx.Urunler.Remove(ctx.Urunler.Find(id));

                ctx.SaveChanges();
                return RedirectToAction("Liste");



            }

        }
    }
}