using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EEEE_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class somechangesindatabasev5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_branches_Companies_CompanyId",
                table: "branches");

            migrationBuilder.DropForeignKey(
                name: "FK_departments_branches_BranchId",
                table: "departments");

            migrationBuilder.DropForeignKey(
                name: "FK_departments_departments_ParentId",
                table: "departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Employees_ManagerId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_levels_LevelId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Excuses_Employees_EmployeeId",
                table: "Excuses");

            migrationBuilder.DropForeignKey(
                name: "FK_positions_departments_DepartmentId",
                table: "positions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_positions",
                table: "positions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_levels",
                table: "levels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_departments",
                table: "departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Companies",
                table: "Companies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_branches",
                table: "branches");

            migrationBuilder.RenameTable(
                name: "positions",
                newName: "Position");

            migrationBuilder.RenameTable(
                name: "levels",
                newName: "Level");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Employee");

            migrationBuilder.RenameTable(
                name: "departments",
                newName: "Department");

            migrationBuilder.RenameTable(
                name: "Companies",
                newName: "Company");

            migrationBuilder.RenameTable(
                name: "branches",
                newName: "Branch");

            migrationBuilder.RenameIndex(
                name: "IX_positions_DepartmentId",
                table: "Position",
                newName: "IX_Position_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_ManagerId",
                table: "Employee",
                newName: "IX_Employee_ManagerId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_LevelId",
                table: "Employee",
                newName: "IX_Employee_LevelId");

            migrationBuilder.RenameIndex(
                name: "IX_departments_ParentId",
                table: "Department",
                newName: "IX_Department_ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_departments_BranchId",
                table: "Department",
                newName: "IX_Department_BranchId");

            migrationBuilder.RenameIndex(
                name: "IX_branches_CompanyId",
                table: "Branch",
                newName: "IX_Branch_CompanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Position",
                table: "Position",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Level",
                table: "Level",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Department",
                table: "Department",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Company",
                table: "Company",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Branch",
                table: "Branch",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Branch_Company_CompanyId",
                table: "Branch",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Branch_BranchId",
                table: "Department",
                column: "BranchId",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Department_ParentId",
                table: "Department",
                column: "ParentId",
                principalTable: "Department",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Employee_ManagerId",
                table: "Employee",
                column: "ManagerId",
                principalTable: "Employee",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Level_LevelId",
                table: "Employee",
                column: "LevelId",
                principalTable: "Level",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Excuses_Employee_EmployeeId",
                table: "Excuses",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Position_Department_DepartmentId",
                table: "Position",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Branch_Company_CompanyId",
                table: "Branch");

            migrationBuilder.DropForeignKey(
                name: "FK_Department_Branch_BranchId",
                table: "Department");

            migrationBuilder.DropForeignKey(
                name: "FK_Department_Department_ParentId",
                table: "Department");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Employee_ManagerId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Level_LevelId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Excuses_Employee_EmployeeId",
                table: "Excuses");

            migrationBuilder.DropForeignKey(
                name: "FK_Position_Department_DepartmentId",
                table: "Position");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Position",
                table: "Position");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Level",
                table: "Level");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Department",
                table: "Department");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Company",
                table: "Company");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Branch",
                table: "Branch");

            migrationBuilder.RenameTable(
                name: "Position",
                newName: "positions");

            migrationBuilder.RenameTable(
                name: "Level",
                newName: "levels");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "Employees");

            migrationBuilder.RenameTable(
                name: "Department",
                newName: "departments");

            migrationBuilder.RenameTable(
                name: "Company",
                newName: "Companies");

            migrationBuilder.RenameTable(
                name: "Branch",
                newName: "branches");

            migrationBuilder.RenameIndex(
                name: "IX_Position_DepartmentId",
                table: "positions",
                newName: "IX_positions_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_ManagerId",
                table: "Employees",
                newName: "IX_Employees_ManagerId");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_LevelId",
                table: "Employees",
                newName: "IX_Employees_LevelId");

            migrationBuilder.RenameIndex(
                name: "IX_Department_ParentId",
                table: "departments",
                newName: "IX_departments_ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_Department_BranchId",
                table: "departments",
                newName: "IX_departments_BranchId");

            migrationBuilder.RenameIndex(
                name: "IX_Branch_CompanyId",
                table: "branches",
                newName: "IX_branches_CompanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_positions",
                table: "positions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_levels",
                table: "levels",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_departments",
                table: "departments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Companies",
                table: "Companies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_branches",
                table: "branches",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_branches_Companies_CompanyId",
                table: "branches",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_departments_branches_BranchId",
                table: "departments",
                column: "BranchId",
                principalTable: "branches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_departments_departments_ParentId",
                table: "departments",
                column: "ParentId",
                principalTable: "departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Employees_ManagerId",
                table: "Employees",
                column: "ManagerId",
                principalTable: "Employees",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_levels_LevelId",
                table: "Employees",
                column: "LevelId",
                principalTable: "levels",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Excuses_Employees_EmployeeId",
                table: "Excuses",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id");

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
