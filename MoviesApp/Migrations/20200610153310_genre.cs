using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesApp.Migrations
{
    public partial class genre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Genre",
                table: "Movie",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Genre",
                table: "Movie",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
