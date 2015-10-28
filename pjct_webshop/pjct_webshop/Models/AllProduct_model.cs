using SmileWithStyleDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pjct_webshop.Models
{
    public class AllProduct_model
    {
     //   private List<Produkt_model> lista = new List<Produkt_model>();
        public List<Produkt_model> lista { get; private set; }
        public void GetAll()
        {
            Class1 hej = new Class1();
            foreach(Product p  in hej.getProductInfo())
            {
                lista.Add(new Produkt_model(p));
            }
        }
    }
}