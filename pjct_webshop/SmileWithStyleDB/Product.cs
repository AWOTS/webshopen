using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace SmileWithStyleDB
{
    public class Product
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Size { get; set; }   
        public int ArtNumber { get; set; }
        public int Quantity { get; set; }
        public string ImagePath { get; set; }
        public bool AvailableWhenSold { get; set; }    
    }
}
