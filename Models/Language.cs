using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieLibraryAPI.Models
{
    /// <summary>
    /// Language Model class
    /// </summary>
    public class Language
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public IList<Movie> movies { get; set; }
    }
}
