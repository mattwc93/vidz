using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using vidz.Models;

namespace vidz.DTOs
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]        
        public DateTime ReleaseDate { get; set; }

        [Required]        
        public DateTime DateAdded { get; set; }

        [Required]
        [Range(1, Int32.MaxValue)]
        public int Stock { get; set; }

        [Required]
        public int GenreId { get; set; }

        public GenreDto Genre { get; set; }
    }
}