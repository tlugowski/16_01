using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _16_01.Models
{
    public class Book
    {
        [Display(Name = "Tytuł")]
        public string Title { get; set; }

        [Display(Name = "Cena")]
        public int Price { get; set; }
    }
}