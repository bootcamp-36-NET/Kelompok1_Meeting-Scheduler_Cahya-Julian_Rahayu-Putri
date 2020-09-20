using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class addAttributArrayBooking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isDelete",
                table: "arraybooking",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isDelete",
                table: "arraybooking");
        }
    }
}
