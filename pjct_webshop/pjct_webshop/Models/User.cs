using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace pjct_webshop.Models
{
    public class User
    {
        public string Login { get; set; }
        [Required(ErrorMessage = "Användarnamn behövs för att logga in.", AllowEmptyStrings = false)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lösenord behövs för att logga in.", AllowEmptyStrings = false)]
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
                SqlCommand myCommand = new SqlCommand("uspLogin", conObj);
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.Add(new SqlParameter("@UserName", UserId));

            }
}

    }