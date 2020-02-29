using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesBlogRazor.WebApp.Migrations
{
    public partial class SeedMovieReviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Rating",
                table: "MovieReview",
                nullable: true,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "MovieReview",
                columns: new[] { "MovieReviewId", "Description", "Genre", "Image", "MyRating", "Rating", "ReleaseDate", "Review", "ReviewDateCreated", "Title" },
                values: new object[] { 1, "Капитан Джон Миллер получает тяжелое задание. Вместе с отрядом из восьми человек Миллер должен отправиться в тыл врага на поиски рядового Джеймса Райана, три родных брата которого почти одновременно погибли на полях сражений", "Action", "https://www.kinopoisk.ru/images/film_big/371.jpg", 5, 8.8000000000000007, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "My review hereНе следует, однако забывать, что консультация с широким активом позволяет оценить значение позиций, занимаемых участниками в отношении поставленных задач. Значимость этих проблем настолько очевидна, что консультация с широким активом обеспечивает широкому кругу (специалистов) участие в формировании направлений прогрессивного развития. С другой стороны укрепление и развитие структуры требуют от нас анализа системы обучения кадров, соответствует насущным потребностям. Идейные соображения высшего порядка, а также постоянный количественный рост и сфера нашей активности требуют от нас анализа систем массового участия.", new DateTime(2020, 1, 24, 0, 0, 0, 0, DateTimeKind.Local), "Спасти рядового Райана" });

            migrationBuilder.InsertData(
                table: "MovieReview",
                columns: new[] { "MovieReviewId", "Description", "Genre", "Image", "MyRating", "Rating", "ReleaseDate", "Review", "ReviewDateCreated", "Title" },
                values: new object[] { 2, "Семнадцатилетняя девушка Белла переезжает к отцу в небольшой городок Форкс. Она влюбляется в загадочного одноклассника, который, как оказалось, происходит из семьи вампиров, отказавшихся от нападений на людей. Влюбиться в вампира. Это страшно? Это романтично, это прекрасно и мучительно, но это не может кончиться добром, особенно в вечном противостоянии вампирских кланов, где малейшее отличие от окружающих уже превращает вас во врага.", "Drama", "https://www.kinopoisk.ru/images/film_big/401177.jpg", 3, 6.7000000000000002, new DateTime(2006, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "My review hereНе следует, однако забывать, что консультация с широким активом позволяет оценить значение позиций, занимаемых участниками в отношении поставленных задач. Значимость этих проблем настолько очевидна, что консультация с широким активом обеспечивает широкому кругу (специалистов) участие в формировании направлений прогрессивного развития. С другой стороны укрепление и развитие структуры требуют от нас анализа системы обучения кадров, соответствует насущным потребностям. Идейные соображения высшего порядка, а также постоянный количественный рост и сфера нашей активности требуют от нас анализа систем массового участия.", new DateTime(2020, 2, 23, 0, 0, 0, 0, DateTimeKind.Local), "Сумерки" });

            migrationBuilder.InsertData(
                table: "MovieReview",
                columns: new[] { "MovieReviewId", "Description", "Genre", "Image", "MyRating", "Rating", "ReleaseDate", "Review", "ReviewDateCreated", "Title" },
                values: new object[] { 3, "Миллиардер-изобретатель Тони Старк попадает в плен к Афганским террористам, которые пытаются заставить его создать оружие массового поражения. В тайне от своих захватчиков Старк конструирует высокотехнологичную киберброню, которая помогает ему сбежать. Однако по возвращении в США он узнаёт, что в совете директоров его фирмы плетётся заговор, чреватый страшными последствиями. Используя своё последнее изобретение, Старк пытается решить проблемы своей компании радикально…", "Action", "https://www.kinopoisk.ru/images/film_big/61237.jpg", 4, 7.9000000000000004, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "My review hereНе следует, однако забывать, что консультация с широким активом позволяет оценить значение позиций, занимаемых участниками в отношении поставленных задач. Значимость этих проблем настолько очевидна, что консультация с широким активом обеспечивает широкому кругу (специалистов) участие в формировании направлений прогрессивного развития. С другой стороны укрепление и развитие структуры требуют от нас анализа системы обучения кадров, соответствует насущным потребностям. Идейные соображения высшего порядка, а также постоянный количественный рост и сфера нашей активности требуют от нас анализа систем массового участия.", new DateTime(2020, 2, 24, 0, 0, 0, 0, DateTimeKind.Local), "Железный Человек" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MovieReview",
                keyColumn: "MovieReviewId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MovieReview",
                keyColumn: "MovieReviewId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MovieReview",
                keyColumn: "MovieReviewId",
                keyValue: 3);

            migrationBuilder.AlterColumn<decimal>(
                name: "Rating",
                table: "MovieReview",
                nullable: true,
                oldClrType: typeof(double),
                oldNullable: true);
        }
    }
}
