using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using learnRazorPagesMovie.Data;
using learnRazorPagesMovie.Models;

namespace learnRazorPagesMovie
{
    public class IndexModel : PageModel
    {
        private readonly learnRazorPagesMovie.Data.learnRazorPagesMovieContext _context;

        public IndexModel(learnRazorPagesMovie.Data.learnRazorPagesMovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
