using Sirket_Otomasyon_MVC_ASP.NET.DAL;
using Sirket_Otomasyon_MVC_ASP.NET.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sirket_Otomasyon_MVC_ASP.NET.Controllers
{
    public class MusteriController : Controller
    {
        MusteriContext ctx;
        // GET: Musteri //url ye Musteri yazdığında çalışacak olan action Index
        public ActionResult Index()
        { 
            return View();
        }
        #region FormCollectionEkle
        //public ActionResult MusteriEkle(FormCollection fc)
        //{
        //    using (MusteriContext ctx = new MusteriContext())
        //    {
        //        ctx.Musteriler.Add(new Musteri { musteriAd = fc["txtMusteriAd"].Trim(), musteriSoyad = fc["txtMusteriSoyad"] });
        //        ctx.SaveChanges();

        //    }
        //    return View();
        //}

        #endregion

      public ActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(Musteri m)
        {
            try
            {
                if (ModelState.IsValid) //geçerli bir değermi
                {

                    using (ctx = new MusteriContext())
                    {
                        ctx.Musteriler.Add(m);

                        if (ctx.SaveChanges() > 0)
                        {
                            return RedirectToAction("Liste");//farklı bir controlle veya actiona yönlendirme
                        }
                        ctx.SaveChanges();

                    } 
                }
                return View();
            }
            catch (DbEntityValidationException) 
            {
                Response.Write("hata"); //entity validation hatası deneme
                throw;
            }


        }     
        public ActionResult Liste()
        {
            using (ctx= new MusteriContext())
            {
               var musteriler = ctx.Musteriler.ToList(); // dbseti to list diyip listeye çeviriyıruz
                return View(musteriler); //sayfaya musterileri yani tabloyu döndürürü.
            }

        }

        [HttpGet] 
        public ActionResult Duzenle(int? id) //nullable id değerini aldık hangi eleman olduğubu anlamak için
        {
            using (ctx= new MusteriContext())
            {
               var musteri= ctx.Musteriler.Find(id);
                return View(musteri);
            }
        }

        [HttpPost]
        public ActionResult Duzenle(Musteri m)//musterinin dbset de musterinin statesinin değiştirilmesi lazım
        {
            using (ctx = new MusteriContext())
            {
                //giriş metoduna m atıp durumunu değiştirildi yapaırz
                ctx.Entry(m).State = EntityState.Modified; 

                if (ctx.SaveChanges()>0)
                {
                    
                    return RedirectToAction("Liste");
                }
                return View();

            }
        }

        public ActionResult Sil(int? id)
        {
            using (ctx = new MusteriContext())
            {
                ctx.Musteriler.Remove(ctx.Musteriler.Find(id));

                ctx.SaveChanges();
                    return RedirectToAction("Liste");
                
                

            }

        }
    }

}