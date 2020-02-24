using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesBlogRazor.WebApp.Migrations
{
    public partial class PluralizeTablesNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Quote",
                table: "Quote");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieReview",
                table: "MovieReview");

            migrationBuilder.RenameTable(
                name: "Quote",
                newName: "Quotes");

            migrationBuilder.RenameTable(
                name: "MovieReview",
                newName: "MovieReviews");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Quotes",
                table: "Quotes",
                column: "QuoteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieReviews",
                table: "MovieReviews",
                column: "MovieReviewId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Quotes",
                table: "Quotes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieReviews",
                table: "MovieReviews");

            migrationBuilder.RenameTable(
                name: "Quotes",
                newName: "Quote");

            migrationBuilder.RenameTable(
                name: "MovieReviews",
                newName: "MovieReview");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Quote",
                table: "Quote",
                column: "QuoteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieReview",
                table: "MovieReview",
                column: "MovieReviewId");
        }
    }
}
