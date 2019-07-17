using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingMall.Models
{
    public class Label
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Product> Products { get; set; }
    }
}