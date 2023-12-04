using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EEEE_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class somechangesindatabasev3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Excuses_departments_DepartmentId",
                table: "Excuses");

            migrationBuilder.DropIndex(
                name: "IX_Excuses_DepartmentId",
                table: "Excuses");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Excuses");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Excuses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Excuses_DepartmentId",
                table: "Excuses",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Excuses_departments_DepartmentId",
                table: "Excuses",
                column: "DepartmentId",
                principalTable: "departments",
                principalColumn: "Id");
        }
    }
}
