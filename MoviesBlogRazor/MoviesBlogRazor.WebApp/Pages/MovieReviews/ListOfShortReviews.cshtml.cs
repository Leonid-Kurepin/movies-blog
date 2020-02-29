using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MoviesBlogRazor.WebApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesBlogRazor.WebApp.Pages.MovieReviews
{
    public class ListOfShortReviewsModel : PageModel
    {
        private readonly MoviesBlogRazorContext _context;

        public ListOfShortReviewsModel(MoviesBlogRazorContext context)
        {
            _context = context;
        }

        public IList<MovieReview> ShortMovieReviewsEntities { get; set; }

        public async Task OnGetAsync(string sortBy, string orderBy)
        {
            var movieReviewsQuery = from item in _context.MovieReviews select item;
            var sortedMovieReviewsQuery = movieReviewsQuery;

            if (orderBy.Equals("Asc"))
            {
                switch (sortBy)
                {
                    case "Title":
                        sortedMovieReviewsQuery = movieReviewsQuery.OrderBy(mr => mr.Title);
                        break;
                    case "Rating":
                        sortedMovieReviewsQuery = movieReviewsQuery.OrderBy(mr => mr.Rating);
                        break;
                    case "MyRating":
                        sortedMovieReviewsQuery = movieReviewsQuery.OrderBy(mr => mr.MyRating);
                        break;
                }
            }
            else if (orderBy.Equals("Desc"))
            {
                switch (sortBy)
                {
                    case "Title":
                        sortedMovieReviewsQuery = movieReviewsQuery.OrderByDescending(mr => mr.Title);
                        break;
                    case "Rating":
                        sortedMovieReviewsQuery = movieReviewsQuery.OrderByDescending(mr => mr.Rating);
                        break;
                    case "MyRating":
                        sortedMovieReviewsQuery = movieReviewsQuery.OrderByDescending(mr => mr.MyRating);
                        break;
                }
            }

            ShortMovieReviewsEntities = await sortedMovieReviewsQuery.ToListAsync();
        }
    }
}