﻿using Microsoft.EntityFrameworkCore;

namespace Mission06_Boody.Models
{
    public class MovieContext : DbContext    
    {
        // Constructor
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
        }
        public DbSet<Movie> Movie { get; set; }
    }

}
