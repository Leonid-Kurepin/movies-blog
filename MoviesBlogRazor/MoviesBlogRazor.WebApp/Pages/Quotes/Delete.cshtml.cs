﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MoviesBlogRazor.WebApp.Models;
using System.Threading.Tasks;

namespace MoviesBlogRazor.WebApp.Pages.Quotes
{
    public class DeleteModel : PageModel
    {
        private readonly MoviesBlogRazor.WebApp.Models.MoviesBlogRazorContext _context;

        public DeleteModel(MoviesBlogRazor.WebApp.Models.MoviesBlogRazorContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Quote Quote { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Quote = await _context.Quotes.FirstOrDefaultAsync(m => m.QuoteId == id);

            if (Quote == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Quote = await _context.Quotes.FindAsync(id);

            if (Quote != null)
            {
                _context.Quotes.Remove(Quote);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
