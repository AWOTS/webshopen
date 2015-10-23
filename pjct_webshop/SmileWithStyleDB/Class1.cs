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
        SqlConnection myConnection = new SqlConnection("Data Source = localhost");
        private SqlParameter myParam;
        SqlDataReader myReader = null;

        private void DatabaseConnection()
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

        private void CloseDatabaseConnection()
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

        private string GetImages(string input)
        {
            myParam = new SqlParameter("@ArtNumber", SqlDbType.VarChar, 11);
            myParam.Value = input;
            string thisImage = "";

            try
            {
                var myCommand = new SqlCommand(
                 "SELECT ImagePath FROM Procucts WHERE ArtNumber = @ArtNumber", myConnection);
                myCommand.Parameters.Add(myParam);
                while (myReader.Read())
                {
                    thisImage = myReader["ImagePath"].ToString();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return thisImage;
        }
    }
}
