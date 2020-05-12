namespace Sirket_Otomasyon_MVC_ASP.NET.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Sirket_Otomasyon_MVC_ASP.NET.DAL.MusteriContext>
    {
        public Configuration()
        {
        
            AutomaticMigrationsEnabled = true; //otomatik olarak verileri veritabanına göndermek için
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Sirket_Otomasyon_MVC_ASP.NET.DAL.MusteriContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
