﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {        
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [Display(Name ="Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [Display(Name ="Entry Date")]
        public DateTime DateAdded { get; set; }

        [Required]
        [Range(1,20)]
        [Display(Name ="Number in Stock")]
        public int StockNumber { get; set; }
        
        public Genre Genre { get; set; }

        [Required(ErrorMessage ="You must select a Genre")]
        [Display(Name ="Genre")]
        public byte GenreId { get; set; }


    }
}