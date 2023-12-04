using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EEEE_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class somechangesindatabasev2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_levels_LevelId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_LevelId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "LevelId",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Excuses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "departments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Excuses_DepartmentId",
                table: "Excuses",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_departments_ParentId",
                table: "departments",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_departments_departments_ParentId",
                table: "departments",
                column: "ParentId",
                principalTable: "departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Excuses_departments_DepartmentId",
                table: "Excuses",
                column: "DepartmentId",
                principalTable: "departments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_departments_departments_ParentId",
                table: "departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Excuses_departments_DepartmentId",
                table: "Excuses");

            migrationBuilder.DropIndex(
                name: "IX_Excuses_DepartmentId",
                table: "Excuses");

            migrationBuilder.DropIndex(
                name: "IX_departments_ParentId",
                table: "departments");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Excuses");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "departments");

            migrationBuilder.AddColumn<int>(
                name: "LevelId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_LevelId",
                table: "Employees",
                column: "LevelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_levels_LevelId",
                table: "Employees",
                column: "LevelId",
                principalTable: "levels",
                principalColumn: "Id");
        }
    }
}
