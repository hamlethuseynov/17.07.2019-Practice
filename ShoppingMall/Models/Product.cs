using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoppingMall.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Display(Name = "Ad")]
        [Required(ErrorMessage = "Adı yazmalısınız")]
        [MaxLength(20, ErrorMessage = "Ad max 20 xarakter ola bilər")]
        [MinLength(3, ErrorMessage = "Ad min 3 xarakter ola bilər")]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        public Nullable <decimal> DiscountPrice { get; set; }

        public string Photo { get; set; }

        public string Description { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public int LabelId { get; set; }


    }
}