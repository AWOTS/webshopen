using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace SmileWithStyleDB
{
    public class Order
    {
        public string Address { get; set; }
        public string Town { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PostalCode { get; set; }
        public string Email { get; set; }
        public int TelephoneNr { get; set; }
        public string MessageToAdministrator { get; set; }
    }
}
