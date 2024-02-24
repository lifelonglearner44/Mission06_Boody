﻿using System.ComponentModel.DataAnnotations;

namespace Mission06_Boody.Models
{

    public class Movie
    {

        [Key]
        [Required]
        public int MovieID { get; set; }
        [Required]

        public string Category { get; set; }
        [Required]

        public string Title { get; set; }

        [Required]

        public int Year { get; set; }
        [Required]

        public string Director { get; set; }
        [Required]

        public string Rating { get; set; }

        public bool? Edited { get; set; }
        public string? LentTo { get; set; }

        public string? Notes { get; set; }
    }


}
