﻿using System;
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

            #region SeedQuotes

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

            #endregion SeedQuotes

            #region SeedMovieReviews

            modelBuilder.Entity<MovieReview>().HasData
            (
                new MovieReview()
                {
                    MovieReviewId = 1,
                    Title = "Спасти рядового Райана",
                    Image = "https://www.kinopoisk.ru/images/film_big/371.jpg",
                    MyRating = 5,
                    Rating = 8.8,
                    Genre = "Action",
                    Description =
                        "Капитан Джон Миллер получает тяжелое задание. Вместе с отрядом из восьми человек Миллер " +
                        "должен отправиться в тыл врага на поиски рядового Джеймса Райана, три родных брата которого" +
                        " почти одновременно погибли на полях сражений",
                    ReleaseDate = Convert.ToDateTime("01.01.1999"),
                    Review = "My review here" +
                             "Не следует, однако забывать, что консультация с широким активом позволяет оценить значение позиций," +
                             " занимаемых участниками в отношении поставленных задач. Значимость этих проблем настолько очевидна," +
                             " что консультация с широким активом обеспечивает широкому кругу (специалистов) участие в формировании" +
                             " направлений прогрессивного развития. С другой стороны укрепление и развитие структуры требуют от нас" +
                             " анализа системы обучения кадров, соответствует насущным потребностям. Идейные соображения высшего " +
                             "порядка, а также постоянный количественный рост и сфера нашей активности требуют от нас анализа систем" +
                             " массового участия.",

                    ReviewDateCreated = DateTime.Today.AddMonths(-1)
                },

                new MovieReview()
                {
                    MovieReviewId = 2,
                    Title = "Сумерки",
                    Image = "https://www.kinopoisk.ru/images/film_big/401177.jpg",
                    MyRating = 3,
                    Rating = 6.7,
                    Genre = "Drama",
                    Description =
                        "Семнадцатилетняя девушка Белла переезжает к отцу в небольшой городок Форкс. Она влюбляется" +
                        " в загадочного одноклассника, который, как оказалось, происходит из семьи вампиров, отказавшихся" +
                        " от нападений на людей. Влюбиться в вампира. Это страшно? Это романтично, это прекрасно и " +
                        "мучительно, но это не может кончиться добром, особенно в вечном противостоянии вампирских " +
                        "кланов, где малейшее отличие от окружающих уже превращает вас во врага.",
                    ReleaseDate = Convert.ToDateTime("08.10.2006"),
                    Review = "My review here" +
                             "Не следует, однако забывать, что консультация с широким активом позволяет оценить значение позиций," +
                             " занимаемых участниками в отношении поставленных задач. Значимость этих проблем настолько очевидна," +
                             " что консультация с широким активом обеспечивает широкому кругу (специалистов) участие в формировании" +
                             " направлений прогрессивного развития. С другой стороны укрепление и развитие структуры требуют от нас" +
                             " анализа системы обучения кадров, соответствует насущным потребностям. Идейные соображения высшего " +
                             "порядка, а также постоянный количественный рост и сфера нашей активности требуют от нас анализа систем" +
                             " массового участия.",

                    ReviewDateCreated = DateTime.Today.AddDays(-1),
                },

                new MovieReview()
                {
                    MovieReviewId = 3,
                    Title = "Железный Человек",
                    Image = "https://www.kinopoisk.ru/images/film_big/61237.jpg",
                    MyRating = 4,
                    Rating = 7.9,
                    Genre = "Action",
                    Description =
                        "Миллиардер-изобретатель Тони Старк попадает в плен к Афганским террористам, которые " +
                        "пытаются заставить его создать оружие массового поражения. В тайне от своих захватчиков " +
                        "Старк конструирует высокотехнологичную киберброню, которая помогает ему сбежать. " +
                        "Однако по возвращении в США он узнаёт, что в совете директоров его фирмы плетётся " +
                        "заговор, чреватый страшными последствиями. Используя своё последнее изобретение, " +
                        "Старк пытается решить проблемы своей компании радикально…",
                    ReleaseDate = Convert.ToDateTime("01.01.1999"),
                    Review = "My review here" +
                             "Не следует, однако забывать, что консультация с широким активом позволяет оценить значение позиций," +
                             " занимаемых участниками в отношении поставленных задач. Значимость этих проблем настолько очевидна," +
                             " что консультация с широким активом обеспечивает широкому кругу (специалистов) участие в формировании" +
                             " направлений прогрессивного развития. С другой стороны укрепление и развитие структуры требуют от нас" +
                             " анализа системы обучения кадров, соответствует насущным потребностям. Идейные соображения высшего " +
                             "порядка, а также постоянный количественный рост и сфера нашей активности требуют от нас анализа систем" +
                             " массового участия.",

                    ReviewDateCreated = DateTime.Today
                }
            );

            #endregion SeedMovieReviews
        }
    }
}
