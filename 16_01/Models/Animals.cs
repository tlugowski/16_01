using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _16_01.Models
{
    public class Animals
    {
        [Display(Name = "Rodzaj zwierzęcia")]
        public string GeneralType { get; set; }

        [Display(Name = "Rasa")]
        public string Kind { get; set; }
    }
}