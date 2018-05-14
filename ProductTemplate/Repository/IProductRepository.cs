using ProductTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductTemplate.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Products> Getproducts();
    }
}