namespace Exercise11Mvc.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Exercise11Mvc.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Exercise11Mvc.DataAccessLayer.StorageContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Exercise11Mvc.DataAccessLayer.StorageContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            Product pro = new Product() { Name = "Zafar", Price = 2000, Category = "abc", Shelf = "1", Count = 2, Description = "Person" };
            context.Products.AddOrUpdate(t => t.Name, pro);
        }
    }
}
