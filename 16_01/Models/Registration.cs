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
        [Required]
        [StringLength(32,MinimumLength =3)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(48)]
        [MinLength(3)]
        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }

        [Display(Name = "Adres")]
        public string Address { get; set; }

        [Display(Name = "Kod pocztowy")]
        [DataType(DataType.PostalCode)]
        public string PostCode { get; set; }

        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Telefon")]
        [DataType(DataType.PhoneNumber)]
        public int Telephone { get; set; }
    }
}