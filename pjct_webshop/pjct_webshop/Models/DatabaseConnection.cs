using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using SmileWithStyleDB;

namespace pjct_webshop.Models
{
    public class DatabaseConnection
    {
        private Class1 databaseClass1 = new Class1();

        public DatabaseConnection ()
        {
            databaseClass1.DatabaseConnection();
        }

        public void ProductsInfo()
        {
            List<Product> products = databaseClass1.getProductInfo();
        }

        public void OrderInfo(int numberOfOrders)
        {
            List<Order> orders = databaseClass1.getOrderInfo(numberOfOrders);
        }
    }
}