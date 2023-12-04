using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EEEE_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addexcusecomment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ExcuseStatusComment",
                table: "Excuses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExcuseStatusComment",
                table: "Excuses");
        }
    }
}
