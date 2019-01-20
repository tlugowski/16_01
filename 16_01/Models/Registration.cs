using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _16_01.Models
{
    public class Registration
    {
        [Display(Name = "Imię")]
        public string FirstName { get; set; }

        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }

        [Display(Name = "Adres")]
        public string Address { get; set; }

        [Display(Name = "Kod pocztowy")]
        public string PostCode { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Telefon")]
        public int Telephone { get; set; }
    }
}