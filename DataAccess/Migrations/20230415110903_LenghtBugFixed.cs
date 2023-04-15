using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class LenghtBugFixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Contents",
                table: "Notifications",
                type: "VARCHAR(8000)",
                maxLength: 8000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(2147483647)",
                oldMaxLength: 2147483647);

            migrationBuilder.AlterColumn<string>(
                name: "Pass",
                table: "Employees",
                type: "VARCHAR(8000)",
                maxLength: 8000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(2147483647)",
                oldMaxLength: 2147483647);

            migrationBuilder.AlterColumn<string>(
                name: "Contents",
                table: "Activities",
                type: "VARCHAR(8000)",
                maxLength: 8000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(2147483647)",
                oldMaxLength: 2147483647);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Contents",
                table: "Notifications",
                type: "VARCHAR(2147483647)",
                maxLength: 2147483647,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(8000)",
                oldMaxLength: 8000);

            migrationBuilder.AlterColumn<string>(
                name: "Pass",
                table: "Employees",
                type: "VARCHAR(2147483647)",
                maxLength: 2147483647,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(8000)",
                oldMaxLength: 8000);

            migrationBuilder.AlterColumn<string>(
                name: "Contents",
                table: "Activities",
                type: "VARCHAR(2147483647)",
                maxLength: 2147483647,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(8000)",
                oldMaxLength: 8000);
        }
    }
}
