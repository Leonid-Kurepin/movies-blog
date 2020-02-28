using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MoviesBlogRazor.WebApp.Models;
using System.Threading.Tasks;

namespace MoviesBlogRazor.WebApp.Pages.MovieReviews
{
    public class FullMovieReviewEntityModel : PageModel
    {
        private readonly MoviesBlogRazorContext _context;

        public FullMovieReviewEntityModel(MoviesBlogRazorContext context)
        {
            _context = context;
        }

        public MovieReview MovieReviewEntity { get; private set; }

        public async Task OnGetAsync(int id)
        {
            MovieReviewEntity = await _context.MovieReviews.FirstOrDefaultAsync(mr => mr.MovieReviewId.Equals(id));
        }
    }
}