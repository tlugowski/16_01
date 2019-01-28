using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _16_01.Models
{
    public class CarRegistration
    {
        [Required]
        [Display(Name = "Rodzaj pojazdu")]
        public string KindOf { get; set; }

        [Required]
        [Display(Name = "Typ")]
        public string Type { get; set; }

        [Required]
        [Display(Name = "Marka")]
        public string Mark { get; set; }

        [Required]
        [Display(Name = "Nazwa")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Data produkcji")]
        [DataType(DataType.Date)]
        public string ProductionDate { get; set; }

        [Required]
        [Display(Name = "Rodzaj paliwa")]
        public string FuelType { get; set; }

        [Required]
        [Display(Name = "Kolor nadwozia")]
        public string Color { get; set; }
    }
}