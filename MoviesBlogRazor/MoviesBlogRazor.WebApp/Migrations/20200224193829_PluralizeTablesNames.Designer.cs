﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoviesBlogRazor.WebApp.Models;

namespace MoviesBlogRazor.WebApp.Migrations
{
    [DbContext(typeof(MoviesBlogRazorContext))]
    [Migration("20200224193829_PluralizeTablesNames")]
    partial class PluralizeTablesNames
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MoviesBlogRazor.WebApp.Models.MovieReview", b =>
                {
                    b.Property<int>("MovieReviewId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Genre")
                        .HasMaxLength(255);

                    b.Property<string>("Image");

                    b.Property<int?>("MyRating");

                    b.Property<double?>("Rating");

                    b.Property<DateTime?>("ReleaseDate");

                    b.Property<string>("Review");

                    b.Property<DateTime?>("ReviewDateCreated");

                    b.Property<string>("Title")
                        .HasMaxLength(255);

                    b.HasKey("MovieReviewId");

                    b.ToTable("MovieReviews");

                    b.HasData(
                        new
                        {
                            MovieReviewId = 1,
                            Description = "Капитан Джон Миллер получает тяжелое задание. Вместе с отрядом из восьми человек Миллер должен отправиться в тыл врага на поиски рядового Джеймса Райана, три родных брата которого почти одновременно погибли на полях сражений",
                            Genre = "Action",
                            Image = "https://www.kinopoisk.ru/images/film_big/371.jpg",
                            MyRating = 5,
                            Rating = 8.8000000000000007,
                            ReleaseDate = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Review = "My review hereНе следует, однако забывать, что консультация с широким активом позволяет оценить значение позиций, занимаемых участниками в отношении поставленных задач. Значимость этих проблем настолько очевидна, что консультация с широким активом обеспечивает широкому кругу (специалистов) участие в формировании направлений прогрессивного развития. С другой стороны укрепление и развитие структуры требуют от нас анализа системы обучения кадров, соответствует насущным потребностям. Идейные соображения высшего порядка, а также постоянный количественный рост и сфера нашей активности требуют от нас анализа систем массового участия.",
                            ReviewDateCreated = new DateTime(2020, 1, 24, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Спасти рядового Райана"
                        },
                        new
                        {
                            MovieReviewId = 2,
                            Description = "Семнадцатилетняя девушка Белла переезжает к отцу в небольшой городок Форкс. Она влюбляется в загадочного одноклассника, который, как оказалось, происходит из семьи вампиров, отказавшихся от нападений на людей. Влюбиться в вампира. Это страшно? Это романтично, это прекрасно и мучительно, но это не может кончиться добром, особенно в вечном противостоянии вампирских кланов, где малейшее отличие от окружающих уже превращает вас во врага.",
                            Genre = "Drama",
                            Image = "https://www.kinopoisk.ru/images/film_big/401177.jpg",
                            MyRating = 3,
                            Rating = 6.7000000000000002,
                            ReleaseDate = new DateTime(2006, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Review = "My review hereНе следует, однако забывать, что консультация с широким активом позволяет оценить значение позиций, занимаемых участниками в отношении поставленных задач. Значимость этих проблем настолько очевидна, что консультация с широким активом обеспечивает широкому кругу (специалистов) участие в формировании направлений прогрессивного развития. С другой стороны укрепление и развитие структуры требуют от нас анализа системы обучения кадров, соответствует насущным потребностям. Идейные соображения высшего порядка, а также постоянный количественный рост и сфера нашей активности требуют от нас анализа систем массового участия.",
                            ReviewDateCreated = new DateTime(2020, 2, 23, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Сумерки"
                        },
                        new
                        {
                            MovieReviewId = 3,
                            Description = "Миллиардер-изобретатель Тони Старк попадает в плен к Афганским террористам, которые пытаются заставить его создать оружие массового поражения. В тайне от своих захватчиков Старк конструирует высокотехнологичную киберброню, которая помогает ему сбежать. Однако по возвращении в США он узнаёт, что в совете директоров его фирмы плетётся заговор, чреватый страшными последствиями. Используя своё последнее изобретение, Старк пытается решить проблемы своей компании радикально…",
                            Genre = "Action",
                            Image = "https://www.kinopoisk.ru/images/film_big/61237.jpg",
                            MyRating = 4,
                            Rating = 7.9000000000000004,
                            ReleaseDate = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Review = "My review hereНе следует, однако забывать, что консультация с широким активом позволяет оценить значение позиций, занимаемых участниками в отношении поставленных задач. Значимость этих проблем настолько очевидна, что консультация с широким активом обеспечивает широкому кругу (специалистов) участие в формировании направлений прогрессивного развития. С другой стороны укрепление и развитие структуры требуют от нас анализа системы обучения кадров, соответствует насущным потребностям. Идейные соображения высшего порядка, а также постоянный количественный рост и сфера нашей активности требуют от нас анализа систем массового участия.",
                            ReviewDateCreated = new DateTime(2020, 2, 24, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Железный Человек"
                        });
                });

            modelBuilder.Entity("MoviesBlogRazor.WebApp.Models.Quote", b =>
                {
                    b.Property<int>("QuoteId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MovieTitle")
                        .HasMaxLength(255);

                    b.Property<string>("Text");

                    b.HasKey("QuoteId");

                    b.ToTable("Quotes");

                    b.HasData(
                        new
                        {
                            QuoteId = 1,
                            MovieTitle = "Fight Club (1999)",
                            Text = "The first rule of Fight Club is: You do not talk about Fight Club. The second rule of Fight Club is: You do not talk about Fight Club."
                        },
                        new
                        {
                            QuoteId = 2,
                            MovieTitle = "Pride & Prejudice (2005)",
                            Text = "He is just what a young man ought to be."
                        },
                        new
                        {
                            QuoteId = 3,
                            MovieTitle = "The Green Mile (1999)",
                            Text = "Time takes it all, whether you want it to or not."
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
