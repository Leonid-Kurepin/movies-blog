using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesBlogRazor.WebApp.Migrations
{
    public partial class SeedMovieReviews2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MovieReviews",
                keyColumn: "MovieReviewId",
                keyValue: 1,
                column: "ReviewDateCreated",
                value: new DateTime(2020, 1, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MovieReviews",
                keyColumn: "MovieReviewId",
                keyValue: 2,
                column: "ReviewDateCreated",
                value: new DateTime(2020, 2, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MovieReviews",
                keyColumn: "MovieReviewId",
                keyValue: 3,
                column: "ReviewDateCreated",
                value: new DateTime(2020, 2, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "MovieReviews",
                columns: new[] { "MovieReviewId", "Description", "Genre", "Image", "MyRating", "Rating", "ReleaseDate", "Review", "ReviewDateCreated", "Title" },
                values: new object[,]
                {
                    { 4, "Четырехпалый Френки должен был переправить краденый алмаз из Англии в США своему боссу Эви. Но вместо этого герой попадает в эпицентр больших неприятностей.Сделав ставку на подпольном боксерском поединке,Френки попадает в круговорот весьма нежелательных событий.", "Criminal", "https://www.kinopoisk.ru/images/film_big/526.jpg", 5, 9.0999999999999996, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "My review hereНе следует, однако забывать, что консультация с широким активом позволяет оценить значение позиций, занимаемых участниками в отношении поставленных задач. Значимость этих проблем настолько очевидна, что консультация с широким активом обеспечивает широкому кругу (специалистов) участие в формировании направлений прогрессивного развития. С другой стороны укрепление и развитие структуры требуют от нас анализа системы обучения кадров, соответствует насущным потребностям. Идейные соображения высшего порядка, а также постоянный количественный рост и сфера нашей активности требуют от нас анализа систем массового участия.", new DateTime(2020, 2, 29, 0, 0, 0, 0, DateTimeKind.Local), "Большой куш" },
                    { 5, "Дрю Деккер разговаривает по телефону с незнакомцем, будто бы попавшим не туда. Очень скоро она понимает, что её собеседник — маньяк, который хочет её убить. Дрю выбегает из дома, по пятам преследуемая маньяком. Девушке почти удаётся убежать, но её случайно сбивает машина отца…", "Comedy", "https://www.kinopoisk.ru/images/film_big/5932.jpg", 2, 4.2999999999999998, new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "My review hereНе следует, однако забывать, что консультация с широким активом позволяет оценить значение позиций, занимаемых участниками в отношении поставленных задач. Значимость этих проблем настолько очевидна, что консультация с широким активом обеспечивает широкому кругу (специалистов) участие в формировании направлений прогрессивного развития. С другой стороны укрепление и развитие структуры требуют от нас анализа системы обучения кадров, соответствует насущным потребностям. Идейные соображения высшего порядка, а также постоянный количественный рост и сфера нашей активности требуют от нас анализа систем массового участия.", new DateTime(2020, 2, 29, 0, 0, 0, 0, DateTimeKind.Local), "Очень страшное кино" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MovieReviews",
                keyColumn: "MovieReviewId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MovieReviews",
                keyColumn: "MovieReviewId",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "MovieReviews",
                keyColumn: "MovieReviewId",
                keyValue: 1,
                column: "ReviewDateCreated",
                value: new DateTime(2020, 1, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MovieReviews",
                keyColumn: "MovieReviewId",
                keyValue: 2,
                column: "ReviewDateCreated",
                value: new DateTime(2020, 2, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MovieReviews",
                keyColumn: "MovieReviewId",
                keyValue: 3,
                column: "ReviewDateCreated",
                value: new DateTime(2020, 2, 24, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
