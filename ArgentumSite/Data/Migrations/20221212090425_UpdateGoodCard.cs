using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArgentumSite.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateGoodCard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "GoodCards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "GoodCards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IdNumber",
                table: "GoodCards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsFavorite",
                table: "GoodCards",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Sex",
                table: "GoodCards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "GoodCards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "GoodCards");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "GoodCards");

            migrationBuilder.DropColumn(
                name: "IdNumber",
                table: "GoodCards");

            migrationBuilder.DropColumn(
                name: "IsFavorite",
                table: "GoodCards");

            migrationBuilder.DropColumn(
                name: "Sex",
                table: "GoodCards");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "GoodCards");
        }
    }
}
