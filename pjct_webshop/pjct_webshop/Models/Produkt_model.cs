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
            name = p.Name;
            descripton = p.Description;
            price = p.Price;
            type = p.Type;
            imgSource = p.ImagePath;
            amount = p.Quantity;
            availableWhenOutOfStock = p.AvailableWhenSold;
            ArtNr = p.ArtNumber;
        }

        public void SaveToDB()
        {
            Product p = new Product() { Name = this.name };
            Class1 c1 = new Class1();
            //c1.saveNewProduct(p);
        }
        public string name { get; set; }
        public string descripton { get; set; }
        public string type { get; set; }
        public string imgSource { get; set; }
        public double price { get; set; }
        public int amount { get; set; }
        public bool availableWhenOutOfStock { get; set; }
        public string ArtNr { get; private set; }
        
        public void saveProduct()
        {
            Product p =new Product() {Name = this.name};
        }
    }
}