using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArgentumSite.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sizes_GoodCards_GoodCardId",
                table: "Sizes");

            migrationBuilder.DropIndex(
                name: "IX_Sizes_GoodCardId",
                table: "Sizes");

            migrationBuilder.DropColumn(
                name: "GoodCardId",
                table: "Sizes");

            migrationBuilder.CreateTable(
                name: "GoodCardSize",
                columns: table => new
                {
                    GoodCardsId = table.Column<int>(type: "int", nullable: false),
                    SizeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodCardSize", x => new { x.GoodCardsId, x.SizeId });
                    table.ForeignKey(
                        name: "FK_GoodCardSize_GoodCards_GoodCardsId",
                        column: x => x.GoodCardsId,
                        principalTable: "GoodCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GoodCardSize_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GoodCardSize_SizeId",
                table: "GoodCardSize",
                column: "SizeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GoodCardSize");

            migrationBuilder.AddColumn<int>(
                name: "GoodCardId",
                table: "Sizes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sizes_GoodCardId",
                table: "Sizes",
                column: "GoodCardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sizes_GoodCards_GoodCardId",
                table: "Sizes",
                column: "GoodCardId",
                principalTable: "GoodCards",
                principalColumn: "Id");
        }
    }
}
