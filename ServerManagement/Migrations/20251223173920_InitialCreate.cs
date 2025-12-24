using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServerManagement.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Servers",
                keyColumn: "ServerId",
                keyValue: 2,
                column: "IsOnline",
                value: true);

            migrationBuilder.UpdateData(
                table: "Servers",
                keyColumn: "ServerId",
                keyValue: 3,
                column: "IsOnline",
                value: false);

            migrationBuilder.UpdateData(
                table: "Servers",
                keyColumn: "ServerId",
                keyValue: 4,
                column: "IsOnline",
                value: true);

            migrationBuilder.UpdateData(
                table: "Servers",
                keyColumn: "ServerId",
                keyValue: 5,
                column: "IsOnline",
                value: true);

            migrationBuilder.UpdateData(
                table: "Servers",
                keyColumn: "ServerId",
                keyValue: 7,
                column: "IsOnline",
                value: true);

            migrationBuilder.UpdateData(
                table: "Servers",
                keyColumn: "ServerId",
                keyValue: 9,
                column: "IsOnline",
                value: true);

            migrationBuilder.UpdateData(
                table: "Servers",
                keyColumn: "ServerId",
                keyValue: 10,
                column: "IsOnline",
                value: false);

            migrationBuilder.UpdateData(
                table: "Servers",
                keyColumn: "ServerId",
                keyValue: 12,
                column: "IsOnline",
                value: false);

            migrationBuilder.UpdateData(
                table: "Servers",
                keyColumn: "ServerId",
                keyValue: 14,
                column: "IsOnline",
                value: false);

            migrationBuilder.UpdateData(
                table: "Servers",
                keyColumn: "ServerId",
                keyValue: 15,
                column: "IsOnline",
                value: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Servers",
                keyColumn: "ServerId",
                keyValue: 2,
                column: "IsOnline",
                value: false);

            migrationBuilder.UpdateData(
                table: "Servers",
                keyColumn: "ServerId",
                keyValue: 3,
                column: "IsOnline",
                value: true);

            migrationBuilder.UpdateData(
                table: "Servers",
                keyColumn: "ServerId",
                keyValue: 4,
                column: "IsOnline",
                value: false);

            migrationBuilder.UpdateData(
                table: "Servers",
                keyColumn: "ServerId",
                keyValue: 5,
                column: "IsOnline",
                value: false);

            migrationBuilder.UpdateData(
                table: "Servers",
                keyColumn: "ServerId",
                keyValue: 7,
                column: "IsOnline",
                value: false);

            migrationBuilder.UpdateData(
                table: "Servers",
                keyColumn: "ServerId",
                keyValue: 9,
                column: "IsOnline",
                value: false);

            migrationBuilder.UpdateData(
                table: "Servers",
                keyColumn: "ServerId",
                keyValue: 10,
                column: "IsOnline",
                value: true);

            migrationBuilder.UpdateData(
                table: "Servers",
                keyColumn: "ServerId",
                keyValue: 12,
                column: "IsOnline",
                value: true);

            migrationBuilder.UpdateData(
                table: "Servers",
                keyColumn: "ServerId",
                keyValue: 14,
                column: "IsOnline",
                value: true);

            migrationBuilder.UpdateData(
                table: "Servers",
                keyColumn: "ServerId",
                keyValue: 15,
                column: "IsOnline",
                value: false);
        }
    }
}
