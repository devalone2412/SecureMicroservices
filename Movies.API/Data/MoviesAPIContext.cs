using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Movies.API.Models;

namespace Movies.API.Data
{
    public class MoviesAPIContext(DbContextOptions<MoviesAPIContext> options) : DbContext(options)
    {
        public DbSet<Movie> Movies { get; set; } = default!;
    }
}
