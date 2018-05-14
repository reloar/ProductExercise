using ProductTemplate.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProductTemplate.Context
{
    public class ProductContext:DbContext
    {
        public ProductContext():base($"name={nameof(ProductContext)}")
        {

        }
        public DbSet<Products> Products { get; set; }
    }
}