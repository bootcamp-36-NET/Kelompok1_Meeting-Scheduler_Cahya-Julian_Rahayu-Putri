using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class addTeamRoomFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "tb_m_teamRoom",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Room = table.Column<string>(nullable: true),
                    isDelete = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(nullable: false),
                    DeleteDate = table.Column<DateTimeOffset>(nullable: false),
                    UpdateDate = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_m_teamRoom", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_m_teamRoom");

            migrationBuilder.CreateTable(
                name: "arraybooking",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Room = table.Column<string>(nullable: true),
                    Team = table.Column<string>(nullable: true),
                    isDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_arraybooking", x => x.Id);
                });
        }
    }
}
