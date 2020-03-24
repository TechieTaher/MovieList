using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MovieList.Models
{
    public class Movie
    {

        [System.ComponentModel.DataAnnotations.Key]
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public decimal Rating { get; set; }
        public int IndustryId { get; set; }
        public DateTime ReleaseDate { get; set; }
        [ForeignKey(nameof(IndustryId))]
        [InverseProperty(nameof(Models.Industry.Movies))]
        public virtual Industry Industry { get; set; }
        [InverseProperty("Movie")]
        public virtual ICollection<MovieArtist> MovieArtists{ get; set; }
        [InverseProperty("Movie")]
        public virtual ICollection<MovieCategory>MovieCategories { get; set; }
        public Movie()
        {
            MovieArtists = new HashSet<MovieArtist>();
            MovieCategories = new HashSet<MovieCategory>();
        }
    }
}
