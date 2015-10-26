using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pjct_webshop.Models
{
    public class Order_model
    {
        public List<Produkt_model> orderVaror { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string adress { get; set; }
        public string stad { get; set; }
        public string postNr { get; set; }
        public string email { get; set; }
        public string telefonNR { get; set; }
        public string meddelande { get; set; }
        public int Id { get; private set; }
    }
}