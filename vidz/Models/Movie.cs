using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Razor;

namespace vidz.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the name of the movie.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the movies release date.")]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }

        [Required(ErrorMessage = "Amount in stock required.")]
        [Range(1, Int32.MaxValue, ErrorMessage = "Stock must be 1 or more.")]
        public int Stock { get; set; }

        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        [Required(ErrorMessage = "Please select a Genre.")]
        public int GenreId { get; set; }
    }
}