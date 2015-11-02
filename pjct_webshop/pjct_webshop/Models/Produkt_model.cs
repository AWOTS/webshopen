using SmileWithStyleDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SmileWithStyleDB;

namespace pjct_webshop.Models
{
    public class Produkt_model
    {
        public Produkt_model()
        { }
        public Produkt_model(Product p)
        {
            Name = p.Name;
            Description = p.Description;
            Price = p.Price;
            Type = p.Type;
            ImagePath = p.ImagePath;
            Quantity = p.Quantity;
            AvailableWhenSold = p.AvailableWhenSold;
            ArtNumber = p.ArtNumber;
        }

        public void SaveToDB()
        {
            Product p = new Product() { Name = this.Name };
            Class1 c1 = new Class1();
            //c1.saveNewProduct(p);
        }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ArtNumber { get; set; }
        public int Quantity { get; set; }
        public string ImagePath { get; set; }
        public bool AvailableWhenSold { get; set; }
        public double Price { get; set; }
        public void saveProduct()
        {
            Product p =new Product() {Name = this.Name};
        }
    }
}