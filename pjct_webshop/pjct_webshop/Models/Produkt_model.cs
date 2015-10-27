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
        //  price = p.
                type = p.Type;
            imgSource = p.ImagePath;
            amount = p.Quantity;
            availableWhenOutOfStock = p.AvailableWhenSold;
            Id = p.ArtNumber;
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
        public int price { get; set; }
        public int amount { get; set; }
        public bool availableWhenOutOfStock { get; set; }
        public int Id { get; private set; }
        
        public void saveProduct()
        {
            Product p =new Product() {Name = this.name};
        }
    }
}