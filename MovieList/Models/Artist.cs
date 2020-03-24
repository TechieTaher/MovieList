using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        [InverseProperty("Artist")]
        public virtual ICollection<MovieArtist>  MovieArtists{ get; set; }
        public Artist()
        {
            MovieArtists = new HashSet<MovieArtist>();
        }
        
    }
    class ArtistComparer : IEqualityComparer<Artist>
    {
        public bool Equals(Artist x, Artist y)
        {
            return x.ArtistId == y.ArtistId;
        }
        public int GetHashCode(Artist t)
        {
            return t.ArtistId.GetHashCode();
        }
    }
    
}
