using System;
using System.ComponentModel.DataAnnotations;

namespace MoviesBlogRazor.WebApp.Models
{
    public class MovieReview
    {
        public int MovieReviewId { get; set; }
        public string Title { get; set; }
        public double? Rating { get; set; }
        public int? MyRating { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Genre { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ReleaseDate { get; set; }


        public string Review { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ReviewDateCreated { get; set; }
    }
}
