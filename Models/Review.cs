using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RazorPagesMovie.Models
{
    public class Review
    {
        public int ReviewId {get; set;}

        [Range(1,5)]
        public int Score {get; set;}

        [Display(Name = "Movie")]
        public int MovieId {get; set;} //FK
        public Movie Movie {get; set;} //Navigation

    }
}