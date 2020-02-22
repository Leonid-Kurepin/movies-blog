using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoviesBlogRazor.WebApp.Models;

namespace MoviesBlogRazor.WebApp.Data.Configurations
{
    internal class MovieReviewConfiguration : IEntityTypeConfiguration<MovieReview>
    {
        public void Configure(EntityTypeBuilder<MovieReview> builder)
        {
            //----------Properties------------
            //Title
            builder
                .Property(mr => mr.Title)
                .IsRequired(false)
                .HasMaxLength(255);

            //Rating
            builder
                .Property(mr => mr.Rating)
                .IsRequired(false);

            //MyRating
            builder
                .Property(mr => mr.MyRating)
                .IsRequired(false);

            //Description
            builder
                .Property(mr => mr.Description)
                .IsRequired(false);

            //Image
            builder
                .Property(mr => mr.Image)
                .IsRequired(false);

            //Genre
            builder
                .Property(mr => mr.Genre)
                .IsRequired(false)
                .HasMaxLength(255);

            //ReleaseDate
            builder
                .Property(mr => mr.ReleaseDate)
                .IsRequired(false);

            //Review
            builder
                .Property(mr => mr.Review)
                .IsRequired(false);

            //ReviewDateCreated
            builder
                .Property(mr => mr.ReviewDateCreated)
                .IsRequired(false);
        }
    }
}


