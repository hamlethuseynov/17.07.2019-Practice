using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ShoppingMall.Models;


namespace ShoppingMall.Data
{
    public class ProductContext:DbContext
    {
        internal object products;

        public ProductContext() : base("ShoppingContext")
        {

        }

        public DbSet<Product> Products  { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Label> Labels { get; set; }
    }
}
