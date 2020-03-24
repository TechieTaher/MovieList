using MovieList.Context;
using MovieList.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieList.Domain
{
    public class MovieCategoryDomain:BaseContext
    {
        public void AddMovieCategory(HashSet<MovieCategory> movieCategory)
        {
            MovieCategories.AddRange(movieCategory);
            SaveChanges();
        }
    }
}
