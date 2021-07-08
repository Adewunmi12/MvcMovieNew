
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {

public Movie()
        {
            ReleaseDate = new DateTime();
        }
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }

        [Display(Name = "Release Date"), DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(30)]
        public string Genre { get; set; }

        [Range(1, 100), DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$"), StringLength(5)]
        public string Rating { get; set; }

        public string Login { get; set; }

        public string Registration { get; set; }

        [NotMapped]
        public List<SelectListItem> Ratings { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "G", Text ="General Audiences" },
            new SelectListItem { Value = "PG", Text ="Parental Guidance Suggested" },
            new SelectListItem { Value = "PG-13", Text = "Parents Strongly Cautioned" },
            new SelectListItem { Value = "R", Text = "Restricted"  },
            new SelectListItem { Value = "NC-17", Text = "Adults Only"  }
        };
    }
}