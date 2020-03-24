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
        public virtual ICollection<MovieCategory> MovieCategories { get; set; }
        public Category()
        {
            MovieCategories= new HashSet<MovieCategory>();
        }
    }
    public class CategoryComparer : IEqualityComparer<Category>
    {
        public bool Equals(Category x, Category y)
        {
            return x.CategoryId == y.CategoryId;
        }

        public int GetHashCode(Category obj)
        {
            return obj.CategoryId.GetHashCode();
        }
    }
}
