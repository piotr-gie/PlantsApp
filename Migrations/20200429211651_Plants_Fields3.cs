using Microsoft.EntityFrameworkCore.Migrations;

namespace PlantsApp.Migrations
{
    public partial class Plants_Fields3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Colour",
                table: "Plant",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Colour",
                table: "Plant",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
