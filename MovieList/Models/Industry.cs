using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MovieList.Models
{
    public class Industry
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int IndustryId { get; set; }
        public string IndustryName { get; set; }
        public string Country { get; set; }
        [InverseProperty("Industry")]
        public virtual ICollection<Movie> Movies { get; set; }
        public Industry()
        {
            Movies = new HashSet<Movie>();
        }
    }
}
