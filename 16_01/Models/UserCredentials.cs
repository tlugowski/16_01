using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _16_01.Models
{
    public class UserCredentials
    {
        public string Login { get; set; }
        [Display(Name="Hasło")]
        public string Password { get; set; }
    }
}