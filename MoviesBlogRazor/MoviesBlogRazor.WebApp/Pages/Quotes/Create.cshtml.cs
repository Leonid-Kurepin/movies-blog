﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MoviesBlogRazor.WebApp.Models;

namespace MoviesBlogRazor.WebApp.Pages.Quotes
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
        public Quote Quote { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Quotes.Add(Quote);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}