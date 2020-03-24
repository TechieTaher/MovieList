using Microsoft.EntityFrameworkCore;
using MovieList.Context;
using MovieList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieList.Domain
{
    public class MovieDomain:BaseContext
    {
        public void AddMovie(Movie movie)
        {
            Movies.Add(movie);
            SaveChanges();
        }
        public List<Movie> GetMovies()
        {
            return Movies
                .Include(t=>t.Industry)
                .Include(t=>t.MovieArtists)
                .ThenInclude(t=>t.Artist)
                .Include(t => t.MovieCategories)
                .ThenInclude(t=>t.Category)
                .ToList();
        }
    }
}
