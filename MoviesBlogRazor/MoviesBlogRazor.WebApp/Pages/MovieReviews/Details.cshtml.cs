using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MoviesBlogRazor.WebApp.Models;
using System.Threading.Tasks;

namespace MoviesBlogRazor.WebApp.Pages.MovieReviews
{
    public class DetailsModel : PageModel
    {
        private readonly MoviesBlogRazor.WebApp.Models.MoviesBlogRazorContext _context;

        public DetailsModel(MoviesBlogRazor.WebApp.Models.MoviesBlogRazorContext context)
        {
            _context = context;
        }

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
    }
}
