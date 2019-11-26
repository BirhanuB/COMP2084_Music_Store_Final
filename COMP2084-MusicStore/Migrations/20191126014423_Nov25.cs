using Microsoft.EntityFrameworkCore.Migrations;

namespace COMP2084MusicStore.Migrations
{
    public partial class Nov25 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArtistName",
                table: "Song");

            migrationBuilder.DropColumn(
                name: "RunTimeSeconds",
                table: "Song");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ArtistName",
                table: "Song",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RunTimeSeconds",
                table: "Song",
                nullable: false,
                defaultValue: 0);
        }
    }
}
