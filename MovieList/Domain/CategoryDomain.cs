using MovieList.Context;
using MovieList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieList.Domain
{
    public class CategoryDomain : BaseContext
    {
        public void AddCategory(Category category)
        {
            Categories.Add(category);
            SaveChanges();
        }
        public List<Category> GetCategories()
        {
            return Categories.ToList();
        }
    }
}
