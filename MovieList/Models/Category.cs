using System;
using System.Collections.Generic;
using System.Text;

namespace MovieList.Models
{
    public class Category
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }
        public Category()
        {
            Movies = new HashSet<Movie>();
        }
    }
}
