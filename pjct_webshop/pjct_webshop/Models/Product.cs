using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace pjct_webshop.Models
{
    public class Product
    {
        public List<Product> ProductList = new List<Product>();

        public Product()
        {

        }

        public int ArtikelNr { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public bool AvailableWhenSold { get; set; }
        public Image ImgSrc { get; set; }
    }
}