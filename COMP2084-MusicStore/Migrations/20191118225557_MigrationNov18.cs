using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace COMP2084MusicStore.Migrations
{
    public partial class MigrationNov18 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Song",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "ShoppingCart",
                columns: table => new
                {
                    ShoppingCartId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCart", x => x.ShoppingCartId);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartLineItem",
                columns: table => new
                {
                    ShoppingCartLineItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ShoppingCartId = table.Column<string>(nullable: true),
                    SongId = table.Column<int>(nullable: false),
                    Count = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartLineItem", x => x.ShoppingCartLineItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartLineItem_Song_SongId",
                        column: x => x.SongId,
                        principalTable: "Song",
                        principalColumn: "SongId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartLineItem_SongId",
                table: "ShoppingCartLineItem",
                column: "SongId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCart");

            migrationBuilder.DropTable(
                name: "ShoppingCartLineItem");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Song");
        }
    }
}
