namespace ShoppingMall.Migrations
{
    using ShoppingMall.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ShoppingMall.Data.ProductContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ShoppingMall.Data.ProductContext context)
        {
            Category ctr1 = new Category
            {
                Name = "Phones"
            };

            Category ctr2 = new Category
            {
                Name = "Laptops"
            };

            context.Categories.AddOrUpdate(ctr1);
            context.Categories.AddOrUpdate(ctr2);
            context.SaveChanges();

            Label lbl1 = new Label
            {
                Name = "New"
            };

            Label lbl2 = new Label
            {
                Name = "Old"
            };
            context.Labels.AddOrUpdate(lbl1);
            context.Labels.AddOrUpdate(lbl2);
            context.SaveChanges();

            Product prd1 = new Product
            {
                Name = "IphoneX",
                Price = 1700,
                DiscountPrice = 1500,
                Photo = "test",
                Description = "Apple Smartphone",
                CategoryId = ctr1.Id,
                LabelId = lbl1.Id

            };
            Product prd2 = new Product
            {
                Name = "Lenovo",
                Price = 2400,
                DiscountPrice = 2100,
                Photo = "test",
                Description = "Lenovo Thinkpad",
                CategoryId = ctr2.Id,
                LabelId = lbl2.Id

            };
            context.Products.AddOrUpdate(prd1);
            context.Products.AddOrUpdate(prd2);
            context.SaveChanges();
        }
    }
}
