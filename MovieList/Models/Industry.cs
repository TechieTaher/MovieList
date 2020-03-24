using System;
using System.Collections.Generic;
using System.Text;

namespace MovieList.Models
{
    public class Industry
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int IndustryId { get; set; }
        public string IndustryName { get; set; }
        public string Country { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }
        public Industry()
        {
            Movies = new HashSet<Movie>();
        }
    }
}
