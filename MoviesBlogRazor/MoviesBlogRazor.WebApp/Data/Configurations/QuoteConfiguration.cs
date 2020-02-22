using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoviesBlogRazor.WebApp.Models;

namespace MoviesBlogRazor.WebApp.Data.Configurations
{
    internal class QuoteConfiguration : IEntityTypeConfiguration<Quote>
    {
        public void Configure(EntityTypeBuilder<Quote> builder)
        {
            //----------Properties------------
            //MovieTitle
            builder
                .Property(q => q.MovieTitle)
                .IsRequired(false)
                .HasMaxLength(255);

            //Text
            builder
                .Property(q => q.Text)
                .IsRequired(false);
        }
    }
}