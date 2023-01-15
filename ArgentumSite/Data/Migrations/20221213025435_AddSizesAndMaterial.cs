using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArgentumSite.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSizesAndMaterial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Size",
                table: "GoodCards");

            migrationBuilder.AddColumn<string>(
                name: "Material",
                table: "GoodCards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GoodCardId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sizes_GoodCards_GoodCardId",
                        column: x => x.GoodCardId,
                        principalTable: "GoodCards",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sizes_GoodCardId",
                table: "Sizes",
                column: "GoodCardId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropColumn(
                name: "Material",
                table: "GoodCards");

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "GoodCards",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
