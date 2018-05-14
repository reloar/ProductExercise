using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProductTemplate.Context;
using ProductTemplate.Models;

namespace ProductTemplate.Repository
{
    public class ProductRepository : IProductRepository
    {
        ProductContext _context = new ProductContext();
        public IEnumerable<Products> Getproducts()
        {
            return _context.Set<Products>().ToList();
        }
    }
}