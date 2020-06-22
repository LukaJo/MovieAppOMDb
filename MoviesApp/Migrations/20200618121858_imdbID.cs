using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesApp.Migrations
{
    public partial class imdbID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImdbID",
                table: "Movie",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImdbID",
                table: "Movie");
        }
    }
}
