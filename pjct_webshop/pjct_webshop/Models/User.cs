using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
}