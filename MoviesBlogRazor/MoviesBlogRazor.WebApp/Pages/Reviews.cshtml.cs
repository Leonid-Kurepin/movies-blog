using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MoviesBlogRazor.WebApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MoviesBlogRazor.WebApp.Pages
{
    public class ReviewsModel : PageModel
    {
        private readonly MoviesBlogRazorContext _context;

        public ReviewsModel(MoviesBlogRazorContext context)
        {
            _context = context;
        }

        public IList<MovieReview> MovieReview { get; set; }

        public async Task OnGetAsync()
        {
            MovieReview = await _context.MovieReviews.ToListAsync();
        }
    }
}
