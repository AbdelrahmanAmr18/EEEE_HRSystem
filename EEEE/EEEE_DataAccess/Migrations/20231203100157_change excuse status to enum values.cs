using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EEEE_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class changeexcusestatustoenumvalues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ExcuseStatus",
                table: "Excuses",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ExcuseStatus",
                table: "Excuses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
