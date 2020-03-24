using System;
using System.Collections.Generic;
using System.Text;

namespace MovieList.Models
{
    public class Movie
    {

        [System.ComponentModel.DataAnnotations.Key]
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public float Ratings { get; set; }
        public int IndustryId { get; set; }
        public DateTime ReleaseDate { get; set; }
        public virtual Industry Industry { get; set; }        
        public virtual ICollection<Artist> Artists { get; set; }
        public virtual ICollection<Category> Categories{ get; set; }
        public Movie()
        {
            Artists = new HashSet<Artist>();
            Categories = new HashSet<Category>();
        }
    }
}
