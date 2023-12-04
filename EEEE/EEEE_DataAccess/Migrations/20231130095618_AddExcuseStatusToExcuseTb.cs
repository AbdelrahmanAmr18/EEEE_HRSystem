using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EEEE_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddExcuseStatusToExcuseTb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Excuses_Employees_EmployeeId",
                table: "Excuses");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "Excuses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "ExcuseStatus",
                table: "Excuses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Excuses_Employees_EmployeeId",
                table: "Excuses",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Excuses_Employees_EmployeeId",
                table: "Excuses");

            migrationBuilder.DropColumn(
                name: "ExcuseStatus",
                table: "Excuses");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "Excuses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Excuses_Employees_EmployeeId",
                table: "Excuses",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
