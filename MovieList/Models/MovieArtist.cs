using System;
using System.Collections.Generic;
using System.Text;

namespace MovieList.Models
{
    public class MovieArtist
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int MovieArtistId { get; set; }
        public int ArtistId { get; set; }
        public int MovieId { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual Movie Movie { get; set; }

    }
}
