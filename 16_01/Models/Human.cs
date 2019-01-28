using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _16_01.Models
{
    public class Human
    {
        [Required]
        [Display(Name = "Płeć")]
        [StringLength(64,MinimumLength = 4)]
        public string Type { get; set; }

        [Required]
        [Display(Name = "Imię")]
        [StringLength(64, MinimumLength = 4)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Wzrost")]
        public int Tall { get; set; }

        [Required]
        [Display(Name = "Waga")]
        [StringLength(64, MinimumLength = 4)]
        public int Weight { get; set; }

        [Required]
        [Display(Name = "Kolor oczu")]
        [StringLength(64, MinimumLength = 4)]
        public string EyeColor { get; set; }

        [Required]
        [Display(Name="Kolor włosów")]
        [StringLength(64, MinimumLength = 4)]
        public string HairColor { get; set; }
    }
}