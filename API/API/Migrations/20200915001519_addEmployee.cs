using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class addEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_department",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(nullable: false),
                    DeleteDate = table.Column<DateTimeOffset>(nullable: false),
                    UpdateDate = table.Column<DateTimeOffset>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_department", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_employee",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(nullable: false),
                    DeleteDate = table.Column<DateTimeOffset>(nullable: false),
                    UpdateDate = table.Column<DateTimeOffset>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    Username = table.Column<string>(nullable: true),
                    DepartmentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_employee_tb_department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "tb_department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tb_employee_tb_m_user_Id",
                        column: x => x.Id,
                        principalTable: "tb_m_user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_employee_DepartmentId",
                table: "tb_employee",
                column: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_employee");

            migrationBuilder.DropTable(
                name: "tb_department");
        }
    }
}
