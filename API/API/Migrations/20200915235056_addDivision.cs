using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class addDivision : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Division_tb_department_DepartmentId",
                table: "Division");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Division",
                table: "Division");

            migrationBuilder.RenameTable(
                name: "Division",
                newName: "tb_division");

            migrationBuilder.RenameIndex(
                name: "IX_Division_DepartmentId",
                table: "tb_division",
                newName: "IX_tb_division_DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_division",
                table: "tb_division",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_division_tb_department_DepartmentId",
                table: "tb_division",
                column: "DepartmentId",
                principalTable: "tb_department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_division_tb_department_DepartmentId",
                table: "tb_division");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_division",
                table: "tb_division");

            migrationBuilder.RenameTable(
                name: "tb_division",
                newName: "Division");

            migrationBuilder.RenameIndex(
                name: "IX_tb_division_DepartmentId",
                table: "Division",
                newName: "IX_Division_DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Division",
                table: "Division",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Division_tb_department_DepartmentId",
                table: "Division",
                column: "DepartmentId",
                principalTable: "tb_department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
