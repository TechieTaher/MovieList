using MovieList.Context;
using MovieList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieList.Domain
{
    public class IndustryDomain:BaseContext
    {
        public List<Industry> GetIndustries()
        {
            return Industries.ToList();
        }
        public void AddIndustry(Industry industry)
        {
            Industries.Add(industry);
            SaveChanges();
        }
    }
}
