using Microsoft.EntityFrameworkCore.Migrations;

namespace TasteRestaurant.Data.Migrations
{
    public partial class MenuItem_Added_Changed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "MenuItems");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "MenuItems",
                nullable: false,
                defaultValue: 0);
        }
    }
}
