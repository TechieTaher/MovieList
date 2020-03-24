using System;
using System.Collections.Generic;
using System.Text;

namespace MovieList.Models
{
    public class MovieCategory
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int MovieCategoryId { get; set; }
        public int CategoryId { get; set; }
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }
        public virtual Category Category{ get; set; }

    }
}
