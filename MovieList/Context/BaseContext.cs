using Microsoft.EntityFrameworkCore;
using MovieList.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieList.Context
{
    public abstract class BaseContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=MSI\\SQLEXPRESS;initial catalog=MovieListDb;Integrated Security=True;MultipleActiveResultSets=True;App=EntityFramework");
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Industry> Industries{ get; set; }
        public DbSet<MovieArtist> MovieArtists{ get; set; }
        public DbSet<MovieCategory> MovieCategories { get; set; }
    }
}
