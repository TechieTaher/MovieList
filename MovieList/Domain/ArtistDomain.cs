﻿using MovieList.Context;
using MovieList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieList.Domain
{
    public class ArtistDomain : BaseContext
    {
        public void AddArtist(Artist artist)
        {
            Artists.Add(artist);
            SaveChanges();
        }
        public List<Artist> GetArtists()
        {
            return Artists.ToList();
        }
    }
}
