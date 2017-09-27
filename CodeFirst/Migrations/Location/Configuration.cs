namespace CodeFirst.Migrations.Location
{
    using CodeFirst.data;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirst.data.ProvinceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\Location";
        }

        protected override void Seed(CodeFirst.data.ProvinceContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Provinces.AddOrUpdate(
                p => new { p.ProvinceCode, p.ProvinceName },
                DummyData.getProvinces().ToArray()
            );
            context.SaveChanges();
            context.Cities.AddOrUpdate(
                c => new { c.CityId, c.CityName, c.Population, c.ProvinceCode },
                DummyData.getCities(context).ToArray()
            );
        }
    }
}
