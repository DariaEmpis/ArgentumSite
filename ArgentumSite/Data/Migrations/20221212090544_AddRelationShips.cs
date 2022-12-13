using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArgentumSite.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddRelationShips : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_GoodCards_CategoryId",
                table: "GoodCards",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_GoodCards_Categories_CategoryId",
                table: "GoodCards",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GoodCards_Categories_CategoryId",
                table: "GoodCards");

            migrationBuilder.DropIndex(
                name: "IX_GoodCards_CategoryId",
                table: "GoodCards");
        }
    }
}
