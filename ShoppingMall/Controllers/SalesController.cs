using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoppingMall.Models;
using ShoppingMall.Data;

namespace ShoppingMall.Controllers
{
    public class SalesController : Controller
    {
        private readonly ProductContext _context;

        public SalesController()
        {
            _context = new ProductContext();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            ViewBag.Categories = _context.Categories.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product Product)
        {
            if (_context.Products.Any(m => m.Name == Product.Name))
            {
                ModelState.AddModelError("Name", "Bu adda mehsul artıq var");
            }

            if (ModelState.IsValid)
            {
                _context.Products.Add(Product);
                _context.SaveChanges();

                return Content(ModelState.IsValid.ToString());
            }

            ViewBag.Categories = _context.Categories.ToList();
            return View(Product);
        }

        public ActionResult Details(string slug)
        {
            return Content(slug);
        }
    }
}
