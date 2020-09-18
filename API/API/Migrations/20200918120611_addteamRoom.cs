using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class addteamRoom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "arraybooking",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Team = table.Column<string>(nullable: true),
                    Room = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_arraybooking", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "arraybooking");
        }
    }
}
