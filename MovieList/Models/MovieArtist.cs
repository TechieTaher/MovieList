using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MovieList.Models
{
    [Table("MovieArtists")]
    public class MovieArtist
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int MovieArtistId { get; set; }
        
        public int ArtistId { get; set; }
        
        public int MovieId { get; set; }
        
        [ForeignKey(nameof(MovieId))]
        [InverseProperty(nameof(Models.Movie.MovieArtists))]
        public virtual Movie Movie { get; set; }

        [ForeignKey(nameof(ArtistId))]
        [InverseProperty(nameof(Models.Artist.MovieArtists))]
        public virtual Artist Artist { get; set; }




    }
}
