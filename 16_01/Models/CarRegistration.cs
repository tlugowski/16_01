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
        [StringLength(64, MinimumLength = 4)]
        public string KindOf { get; set; }

        [Required]
        [Display(Name = "Typ")]
        [StringLength(64, MinimumLength = 4)]
        public string Type { get; set; }

        [Required]
        [Display(Name = "Marka")]
        [StringLength(64, MinimumLength = 4)]
        public string Mark { get; set; }

        [Required]
        [Display(Name = "Nazwa")]
        [StringLength(64, MinimumLength = 4)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Data produkcji")]
        [DataType(DataType.Date)]
        public string ProductionDate { get; set; }

        [Display(Name = "Rodzaj paliwa")]
        public string FuelType { get; set; }


        [Required]
        [StringLength(64, MinimumLength = 4)]
        [Display(Name = "Kolor nadwozia")]
        public string Color { get; set; }

        [Required]
        [StringLength(64, MinimumLength = 4)]
        [Display(Name = "Imie i nazwisko nabywcy")]
        public string Owner { get; set; }

        [Required]
        [Display(Name = "RODO nakłada na administratora obowiązek aby podczas zbierania danych osobowych administrator spełniał obowiązek informacyjny (art. 13 RODO). Zalecamy aby obowiązek informacyjny zrealizować umieszczając stosowne klauzule (patrz. poniżej artykułu) w treści Polityki Prywatności. Rekomendujemy zamieszczenie pod checkboxem o akceptacji regulaminu linku do Polityki Prywatności zatytułowany: „Zasady ochrony danych osobowych.”, w którym spełnione będą obowiązki informacyjne wynikające z RODO.")]
       // [DataType(DataType.]
        public bool ChkBox { get; set; }
    }

    public enum FuelType
    {
        LPG,
        GAS,
        DIESEL
    }
}