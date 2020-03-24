using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MovieList.Models
{
    public class MovieCategory
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int MovieCategoryId { get; set; }
        public int CategoryId { get; set; }
        public int MovieId { get; set; }
        [ForeignKey(nameof(MovieId))]
        [InverseProperty(nameof(Models.Movie.MovieCategories))]
        public virtual Movie Movie { get; set; }
        [ForeignKey(nameof(CategoryId))]
        [InverseProperty(nameof(Models.Category.MovieCategories))]
        public virtual Category Category{ get; set; }

    }
}
