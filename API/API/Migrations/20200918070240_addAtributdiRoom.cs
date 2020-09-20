using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class addAtributdiRoom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isBook",
                table: "tb_room",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isBook",
                table: "tb_room");
        }
    }
}
