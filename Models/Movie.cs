using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieLibraryAPI.Models
{
    /// <summary>
    /// Movie Model class
    /// </summary>
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Summary { get; set; }
        [Required]
        public int LanguageId { get; set; }
        [Required]
        public string Genre { get; set; }

        public Language Language { get; set; }
    }
}
