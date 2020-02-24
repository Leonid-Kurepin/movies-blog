using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MoviesBlogRazor.WebApp.Models;

namespace MoviesBlogRazor.WebApp.Pages.MovieReviews
{
    public class EditModel : PageModel
    {
        private readonly MoviesBlogRazor.WebApp.Models.MoviesBlogRazorContext _context;

        public EditModel(MoviesBlogRazor.WebApp.Models.MoviesBlogRazorContext context)
        {
            _context = context;
        }

        [BindProperty]
        public MovieReview MovieReview { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MovieReview = await _context.MovieReviews.FirstOrDefaultAsync(m => m.MovieReviewId == id);

            if (MovieReview == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(MovieReview).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieReviewExists(MovieReview.MovieReviewId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MovieReviewExists(int id)
        {
            return _context.MovieReviews.Any(e => e.MovieReviewId == id);
        }
    }
}
