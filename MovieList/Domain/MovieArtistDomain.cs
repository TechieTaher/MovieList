using MovieList.Context;
using MovieList.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieList.Domain
{
    public class MovieArtistDomain:BaseContext
    {
        public void AddMovieArtist(HashSet<MovieArtist> movieArtist)
        {
            MovieArtists.AddRange(movieArtist);
            SaveChanges();
        }
    }
}
