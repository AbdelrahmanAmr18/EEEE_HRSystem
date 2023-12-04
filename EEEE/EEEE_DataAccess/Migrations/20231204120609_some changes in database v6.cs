using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EEEE_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class somechangesindatabasev6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Level",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Level_DepartmentId",
                table: "Level",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Level_Department_DepartmentId",
                table: "Level",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Level_Department_DepartmentId",
                table: "Level");

            migrationBuilder.DropIndex(
                name: "IX_Level_DepartmentId",
                table: "Level");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Level");
        }
    }
}
