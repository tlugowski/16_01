using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _16_01.Models
{
    public class CD
    {   
        [Required]
        [StringLength(64,MinimumLength = 4)]
        public string Title { get; set; }

        [Required]
        [Display(Name ="Artysta")]
        [StringLength(64,MinimumLength = 4)]
        public string Artist { get; set; }


        public int SongCount { get; set; }

        [Range(0,1000)]
        public int Cena { get; set; }

        [Range(0, 1000)]
        public int Zaliczka { get; set; }
    }
}