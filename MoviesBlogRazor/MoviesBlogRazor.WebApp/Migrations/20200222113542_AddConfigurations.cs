using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesBlogRazor.WebApp.Migrations
{
    public partial class AddConfigurations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MovieTitle",
                table: "Quote",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "MovieReview",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReviewDateCreated",
                table: "MovieReview",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "MovieReview",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<decimal>(
                name: "Rating",
                table: "MovieReview",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "MyRating",
                table: "MovieReview",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Genre",
                table: "MovieReview",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Quote",
                columns: new[] { "QuoteId", "MovieTitle", "Text" },
                values: new object[] { 1, "Fight Club (1999)", "The first rule of Fight Club is: You do not talk about Fight Club. The second rule of Fight Club is: You do not talk about Fight Club." });

            migrationBuilder.InsertData(
                table: "Quote",
                columns: new[] { "QuoteId", "MovieTitle", "Text" },
                values: new object[] { 2, "Pride & Prejudice (2005)", "He is just what a young man ought to be." });

            migrationBuilder.InsertData(
                table: "Quote",
                columns: new[] { "QuoteId", "MovieTitle", "Text" },
                values: new object[] { 3, "The Green Mile (1999)", "Time takes it all, whether you want it to or not." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Quote",
                keyColumn: "QuoteId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Quote",
                keyColumn: "QuoteId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Quote",
                keyColumn: "QuoteId",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "MovieTitle",
                table: "Quote");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "MovieReview",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReviewDateCreated",
                table: "MovieReview",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "MovieReview",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Rating",
                table: "MovieReview",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MyRating",
                table: "MovieReview",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Genre",
                table: "MovieReview",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);
        }
    }
}
