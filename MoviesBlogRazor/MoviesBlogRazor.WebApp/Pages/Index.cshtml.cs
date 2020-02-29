using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MoviesBlogRazor.WebApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MoviesBlogRazor.WebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly MoviesBlogRazorContext _context;

        public IndexModel(MoviesBlogRazorContext context)
        {
            _context = context;
        }

        public IList<Quote> QuoteList { get; set; }
        public Quote RandomQuote { get; set; }

        public async Task OnGetAsync()
        {
            QuoteList = await _context.Quotes.ToListAsync();

            Random random = new Random();

            RandomQuote = QuoteList[random.Next(QuoteList.Count)];
        }
    }
}
