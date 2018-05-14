using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductTemplate.Models
{
    public class Products
    {
        public int Id { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string productDescription { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public virtual Category Category { get; set; }
    }
}