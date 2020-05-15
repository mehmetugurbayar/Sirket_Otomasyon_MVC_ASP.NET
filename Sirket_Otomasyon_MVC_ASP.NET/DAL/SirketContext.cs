using Sirket_Otomasyon_MVC_ASP.NET.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Sirket_Otomasyon_MVC_ASP.NET.DAL
{
    public class SirketContext: DbContext//tablo özellikleri ve mapping işlemleri yapılır
    {
        public SirketContext() : base("cstr")//connectingstring istiyor bizde base ye parametre olarak connecting string adını yazıyoruz.
        { }

        public DbSet<Musteri> Musteriler { get; set; } // tablonun türü belirlendi

        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Admin> Adminler { get; set; } 

        public DbSet<Yorum> Yorumlar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //fluent api dir
           
            modelBuilder.Entity<Musteri>().ToTable("musteriTbl");
            
            modelBuilder.Entity<Musteri>().Property(m => m.musteriAd).HasMaxLength(15).HasColumnType("varchar").IsRequired();
            modelBuilder.Entity<Musteri>().Property(m => m.musteriSoyad).HasMaxLength(15).HasColumnType("varchar").IsRequired();
            modelBuilder.Entity<Musteri>().Property(m => m.musteriTel).HasMaxLength(15).HasColumnType("varchar");
            modelBuilder.Entity<Musteri>().Property(m => m.musteriAdres).HasMaxLength(15).HasColumnType("varchar");

            modelBuilder.Entity<Urun>().ToTable("urunTbl");
            modelBuilder.Entity<Urun>().Property(u => u.urunKodu).HasMaxLength(15).HasColumnType("varchar").IsRequired();
            modelBuilder.Entity<Urun>().Property(u => u.urunAd).HasMaxLength(15).HasColumnType("varchar").IsRequired();
            modelBuilder.Entity<Urun>().Property(u => u.stokMik).HasMaxLength(15).HasColumnType("varchar").IsRequired();
            modelBuilder.Entity<Urun>().Property(u => u.fiyat).HasMaxLength(15).HasColumnType("varchar").IsRequired();



            modelBuilder.Entity<Admin>().ToTable("adminTbl");

            modelBuilder.Entity<Admin>().Property(a => a.adminKulAd).HasMaxLength(15).HasColumnType("varchar").IsRequired();
            modelBuilder.Entity<Admin>().Property(a => a.adminKulSif).HasMaxLength(15).HasColumnType("varchar").IsRequired();

            modelBuilder.Entity<Yorum>().ToTable("yorumlarTbl");

            modelBuilder.Entity<Yorum>().Property(y => y.yorumBaslik).HasMaxLength(25).HasColumnType("varchar").IsRequired();
            modelBuilder.Entity<Yorum>().Property(y => y.yorum).HasMaxLength(150).HasColumnType("varchar").IsRequired();
        }

    }
}