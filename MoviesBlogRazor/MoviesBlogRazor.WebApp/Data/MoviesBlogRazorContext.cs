using Microsoft.EntityFrameworkCore;
using MoviesBlogRazor.WebApp.Data.Configurations;

namespace MoviesBlogRazor.WebApp.Models
{
    public class MoviesBlogRazorContext : DbContext
    {
        public MoviesBlogRazorContext(DbContextOptions<MoviesBlogRazorContext> options)
            : base(options)
        {
        }

        public DbSet<MovieReview> MovieReview { get; set; }

        public DbSet<Quote> Quote { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MovieReviewConfiguration());
            modelBuilder.ApplyConfiguration(new QuoteConfiguration());

            modelBuilder.Entity<Quote>().HasData
            (
                new Quote
                {
                    QuoteId = 1,
                    MovieTitle = "Fight Club (1999)",
                    Text = "The first rule of Fight Club is: You do not talk about Fight Club. " +
                           "The second rule of Fight Club is: You do not talk about Fight Club."
                },

                new Quote
                {
                    QuoteId = 2,
                    MovieTitle = "Pride & Prejudice (2005)",
                    Text = "He is just what a young man ought to be."
                },

                new Quote
                {
                    QuoteId = 3,
                    MovieTitle = "The Green Mile (1999)",
                    Text = "Time takes it all, whether you want it to or not."
                }
            );
        }
    }
}
