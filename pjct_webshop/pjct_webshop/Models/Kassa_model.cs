using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pjct_webshop.Models
{
    public class Kassa_model
    {
        public List<Produkt_model> varukorg { get; set; }
        public int antal { get; set; }
        public int totalSumma { get; set; }
    }


}