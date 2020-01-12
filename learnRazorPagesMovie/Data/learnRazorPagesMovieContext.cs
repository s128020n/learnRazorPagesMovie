using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using learnRazorPagesMovie.Models;

namespace learnRazorPagesMovie.Data
{
    public class learnRazorPagesMovieContext : DbContext
    {
        public learnRazorPagesMovieContext (DbContextOptions<learnRazorPagesMovieContext> options)
            : base(options)
        {
        }

        public DbSet<learnRazorPagesMovie.Models.Movie> Movie { get; set; }
    }
}
