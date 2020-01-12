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
    public class DetailsModel : PageModel
    {
        private readonly learnRazorPagesMovie.Data.learnRazorPagesMovieContext _context;

        public DetailsModel(learnRazorPagesMovie.Data.learnRazorPagesMovieContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
