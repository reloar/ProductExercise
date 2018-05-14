namespace ProductTemplate.Migrations
{
    using ProductTemplate.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProductTemplate.Context.ProductContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ProductTemplate.Context.ProductContext context)
        {
            context.Products.Add(new Products
            {
                Id = 1,
                ProductName = "Modem",
                productDescription = "Wifi",
                Price = 12600,
                Category = new Category { CategoryName = "System Accessories" }
            });

            context.Products.Add(new Products
            {
                Id = 2,
                ProductName = "Sugar",
                productDescription = "Provision",
                Price = 220,
                Category = new Category { CategoryName = "Beverage" }
            });
            context.Products.Add(new Products
            {
                Id = 3,
                ProductName = "Samsung",
                productDescription = "Mobile Phone",
                Price = 220,
                Category = new Category { CategoryName = "Android" }
            });
            context.SaveChanges();
            base.Seed(context);

          //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
