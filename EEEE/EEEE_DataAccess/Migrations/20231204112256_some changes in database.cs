using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EEEE_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class somechangesindatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_levels_positions_PositionId",
                table: "levels");

            migrationBuilder.DropForeignKey(
                name: "FK_positions_departments_DepartmentId",
                table: "positions");

            migrationBuilder.DropIndex(
                name: "IX_positions_DepartmentId",
                table: "positions");

            migrationBuilder.DropIndex(
                name: "IX_levels_PositionId",
                table: "levels");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "positions");

            migrationBuilder.DropColumn(
                name: "PositionId",
                table: "levels");

            migrationBuilder.DropColumn(
                name: "Appraisal",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CurrentAddress",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Deduction",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "GrossSalary",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "NetSalary",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Tax",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PerminentAddress",
                table: "branches");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Employees",
                newName: "MobileNumber");

            migrationBuilder.RenameColumn(
                name: "PostalCode",
                table: "Employees",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "PerminentAddress",
                table: "Employees",
                newName: "ArabicAddress");

            migrationBuilder.RenameColumn(
                name: "Gener",
                table: "Employees",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "WebsiteURL",
                table: "Companies",
                newName: "MobileNumber");

            migrationBuilder.RenameColumn(
                name: "WebsiteURL",
                table: "branches",
                newName: "MobileNumber");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "branches",
                newName: "ArabicAddress");

            migrationBuilder.RenameColumn(
                name: "CurrentAddress",
                table: "branches",
                newName: "Address");

            migrationBuilder.AddColumn<string>(
                name: "MobileNumber",
                table: "departments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "branches",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MobileNumber",
                table: "departments");

            migrationBuilder.RenameColumn(
                name: "MobileNumber",
                table: "Employees",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "Employees",
                newName: "Gener");

            migrationBuilder.RenameColumn(
                name: "ArabicAddress",
                table: "Employees",
                newName: "PerminentAddress");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Employees",
                newName: "PostalCode");

            migrationBuilder.RenameColumn(
                name: "MobileNumber",
                table: "Companies",
                newName: "WebsiteURL");

            migrationBuilder.RenameColumn(
                name: "MobileNumber",
                table: "branches",
                newName: "WebsiteURL");

            migrationBuilder.RenameColumn(
                name: "ArabicAddress",
                table: "branches",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "branches",
                newName: "CurrentAddress");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "positions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PositionId",
                table: "levels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Appraisal",
                table: "Employees",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CurrentAddress",
                table: "Employees",
                type: "nvarchar(350)",
                maxLength: 350,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Deduction",
                table: "Employees",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "GrossSalary",
                table: "Employees",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "NetSalary",
                table: "Employees",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Tax",
                table: "Employees",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "branches",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "PerminentAddress",
                table: "branches",
                type: "nvarchar(350)",
                maxLength: 350,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_positions_DepartmentId",
                table: "positions",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_levels_PositionId",
                table: "levels",
                column: "PositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_levels_positions_PositionId",
                table: "levels",
                column: "PositionId",
                principalTable: "positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_positions_departments_DepartmentId",
                table: "positions",
                column: "DepartmentId",
                principalTable: "departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
