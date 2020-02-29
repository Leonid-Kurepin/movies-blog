using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MoviesBlogRazor.WebApp.Models;
using System;
using System.Threading.Tasks;

namespace MoviesBlogRazor.WebApp.Pages.MovieReviews
{
    public class CreateModel : PageModel
    {
        private readonly MoviesBlogRazor.WebApp.Models.MoviesBlogRazorContext _context;

        public CreateModel(MoviesBlogRazor.WebApp.Models.MoviesBlogRazorContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public MovieReview MovieReview { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            MovieReview.ReviewDateCreated = DateTime.Now;
            
            _context.MovieReviews.Add(MovieReview);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Reviews");
        }
    }
}