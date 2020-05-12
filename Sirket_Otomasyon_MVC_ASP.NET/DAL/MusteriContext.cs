using Sirket_Otomasyon_MVC_ASP.NET.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Sirket_Otomasyon_MVC_ASP.NET.DAL
{
    public class MusteriContext: DbContext//tablo özellikleri ve mapping işlemleri yapılır
    {
        public MusteriContext() : base("cstr")//connectingstring istiyor bizde base ye parametre olarak connecting string adını yazıyoruz.
        { }

        public DbSet<Musteri> Musteriler { get; set; } // tablonun türü belirlendi

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //fluent api dir
            modelBuilder.Entity<Musteri>().ToTable("musteriTbl");
            
            modelBuilder.Entity<Musteri>().Property(m => m.musteriAd).HasMaxLength(15).HasColumnType("varchar").IsRequired();
            modelBuilder.Entity<Musteri>().Property(m => m.musteriSoyad).HasMaxLength(15).HasColumnType("varchar").IsRequired();

        }

    }
}