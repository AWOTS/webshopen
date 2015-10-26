using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pjct_webshop.Models
{
    public class Produkt_model
    {
        public string name { get; set; }
        public string  descripton { get; set; }
        public string type { get; set; }
        public string imgSource { get; set; }
        public int price { get; set; }
        public int amount { get; set; }
        public bool availableWhenOutOfStock { get; set; }
        public int Id { get; private set; }
    }
}