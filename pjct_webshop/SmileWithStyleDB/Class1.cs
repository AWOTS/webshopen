using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SmileWithStyleDB
{
    public class Class1
    {
        SqlConnection myConnection = new SqlConnection("localhost/SQLEXPRESS; Catalog = db_smileWithStyle; Integrated Security = true");
        SqlDataReader myReader = null;

        public void DatabaseConnection()
        {
            try
            {
                myConnection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void CloseDatabaseConnection()
        {
            try
            {
                myConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public List<Product> getProductInfo()
        {
            Product product;
            List<Product> products = new List<Product>();

            try
            {
                var myCommand = new SqlCommand(
                 "SELECT * FROM Procucts", myConnection);
                while (myReader.Read())
                {
                    product = new Product();
                    products.Add(product);
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return products;
        }

        public List<Product> AddNewProduct(Product newProduct)
        {
            Product product;
            List<Product> products = new List<Product>();

            try
            {
                var myCommand = new SqlCommand(
                 "INSERT INTO Procucts VALUES", myConnection);

               // "SELECT * FROM Procucts", myConnection);
                while (myReader.Read())
                {
                    product = new Product();
                    products.Add(product);
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return products;
        }

        public List<Order> getOrderInfo(int numberOfOrders)
        {
            Order order;
            List<Order> orders = new List<Order>();

            if (numberOfOrders > 0 && numberOfOrders < 500)
            {
                try
                {
                    var myCommand = new SqlCommand(
                     "SELECT TOP (@numberOfOrders) * FROM Order", myConnection);
                    while (myReader.Read())
                    {
                        order = new Order();
                        orders.Add(order);
                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

                return orders;
            }
            else
            {
                return orders;
            }
        }
    }
}
