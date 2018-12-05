using Microsoft.EntityFrameworkCore.Migrations;

namespace TasteRestaurant.Data.Migrations
{
    public partial class FoodType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "FoodTypes",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "FoodTypes",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
