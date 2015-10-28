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
        SqlConnection myConnection = new SqlConnection(@"Data Source=ACADEMY27-VM\SQLEXPRESS;Initial Catalog=db_smileWithStyle;Integrated Security=True");
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
            List<Product> products = new List<Product>();
            DatabaseConnection();
            try
            {
                var myCommand = new SqlCommand("SELECT * FROM Products", myConnection);
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    Product product = new Product();
                    product.Type = myReader["Type"].ToString();
                    product.Name = myReader["Name"].ToString();
                    product.Price = Convert.ToInt32(myReader["Price"].ToString());
                    product.Description = myReader["Description"].ToString();
                    product.ArtNumber = Convert.ToInt32(myReader["ArtNumber"].ToString());
                    product.Quantity = Convert.ToInt32(myReader["Quantity"].ToString());
                    product.ImagePath = myReader["ImagePath"].ToString();
                    product.AvailableWhenSold = Convert.ToInt32(myReader["AvailableWhenSold"].ToString()) == 1
                        ? true
                        : false;

                    products.Add(product);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            CloseDatabaseConnection();

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

        public void ProductsBought(int nr, int amount)
        {
            List<Product> products = new List<Product>();
            DatabaseConnection();
            if (amount > 0)
            {
                try
                {
                    var myCommand = new SqlCommand($"UPDATE Products set Quantity=(Quantity - {amount}) WHERE ArtNumber = {nr}", myConnection);
                    myCommand.ExecuteNonQuery();
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

                finally
                {
                    CloseDatabaseConnection();
                }
            }
        }
    }
}
