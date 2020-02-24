using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MoviesBlogRazor.WebApp.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MoviesBlogRazor.WebApp.Pages.Quotes
{
    public class AnotherRandomQuoteModel : PageModel
    {
        private readonly MoviesBlogRazorContext _context;

        public AnotherRandomQuoteModel(MoviesBlogRazorContext context)
        {
            _context = context;
        }

        private static int _currentQuoteId = 1;
        public Quote RandomQuote { get; private set; } 

        //public async Task OnGetAsync(int currentQuoteId)
        //{
        //    var anotherQuotesList = await _context.Quote.Where(q => q.QuoteId != currentQuoteId).ToListAsync();

        //    Random random = new Random();

        //    RandomQuote = anotherQuotesList[random.Next(anotherQuotesList.Count)];
        //}

        public async Task OnGetAsync()
        {
            var anotherQuotesList = await _context.Quotes.Where(q => q.QuoteId != _currentQuoteId).ToListAsync();

            Random random = new Random();

            RandomQuote = anotherQuotesList[random.Next(anotherQuotesList.Count)];
            _currentQuoteId = RandomQuote.QuoteId;
        }
    }
}