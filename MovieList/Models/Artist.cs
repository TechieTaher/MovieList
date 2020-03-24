using System;
using System.Collections.Generic;
using System.Text;

namespace MovieList.Models
{
    public class Artist
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int ArtistId { get; set; }
        public string ArtistName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Country { get; set; }
        public virtual ICollection<Movie>  Movies  { get; set; }
        public Artist()
        {
            Movies = new HashSet<Movie>();
        }
    }
}
