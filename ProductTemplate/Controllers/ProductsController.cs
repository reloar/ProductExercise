using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProductTemplate.Context;
using ProductTemplate.Models;
using ProductTemplate.Repository;

namespace ProductTemplate.Controllers
{
    public class ProductsController : Controller
    {
        private ProductContext _context = new ProductContext();
     

        public ActionResult Index()
        {
            return View();
            
        }
        public ActionResult ProductList()
        {
            return View(_context.Products.ToList());
        }

       
    }
}
