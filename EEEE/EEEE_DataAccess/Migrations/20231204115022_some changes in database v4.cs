using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EEEE_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class somechangesindatabasev4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ArabicName",
                table: "positions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "positions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ArabicName",
                table: "levels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "LevelId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ArabicName",
                table: "departments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ArabicName",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ArabicName",
                table: "branches",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_positions_DepartmentId",
                table: "positions",
                column: "DepartmentId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_positions_departments_DepartmentId",
                table: "positions",
                column: "DepartmentId",
                principalTable: "departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_levels_LevelId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_positions_departments_DepartmentId",
                table: "positions");

            migrationBuilder.DropIndex(
                name: "IX_positions_DepartmentId",
                table: "positions");

            migrationBuilder.DropIndex(
                name: "IX_Employees_LevelId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ArabicName",
                table: "positions");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "positions");

            migrationBuilder.DropColumn(
                name: "ArabicName",
                table: "levels");

            migrationBuilder.DropColumn(
                name: "LevelId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ArabicName",
                table: "departments");

            migrationBuilder.DropColumn(
                name: "ArabicName",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "ArabicName",
                table: "branches");
        }
    }
}
