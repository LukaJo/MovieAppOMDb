using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesApp.Migrations
{
    public partial class DbChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Rating",
                table: "Movie",
                nullable: false,
                oldClrType: typeof(decimal));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Rating",
                table: "Movie",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
