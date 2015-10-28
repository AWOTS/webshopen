using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading;
using System.Text;


namespace pjct_webshop.Models
{
    public class User
    {
        public int UserID { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }

    public class UserLogic
    {
        string myConnection = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
        public int CheckUserLogin(User u)
        {
            using (SqlConnection conObj = new SqlConnection(myConnection))
            {
                //SqlCommand myCommand = new SqlCommand("uspLogin", conObj);
                //myCommand.CommandType = CommandType.StoredProcedure;
                ////myCommand.Parameters.Clear();
                //myCommand.Parameters.Add(new SqlParameter("@UserName", u.UserName));
                //myCommand.Parameters.Add(new SqlParameter("@Password", u.Password));
                //conObj.Open();
                //var a = myCommand.ExecuteNonQuery();
                //return 2;

                SqlCommand myCommand = new SqlCommand("uspLogin", conObj);
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.Add(new SqlParameter("@UserName", u.UserName));
                myCommand.Parameters.Add(new SqlParameter("@Password", u.Password));
                conObj.Open();
                return Convert.ToInt32(myCommand.ExecuteScalar());

            }
        }
    }
}