using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_LagaltBackend.Migrations
{
    /// <inheritdoc />
    public partial class InitUpdatedgoogleId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GoogleId",
                table: "Users",
                type: "nvarchar(max)",
                maxLength: 2147483647,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "ChatMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Timestamp",
                value: "2023-05-05 14:24:05");

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Timestamp",
                value: "2023-05-05 14:24:05");

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "Timestamp",
                value: "2023-05-05 14:24:05");

            migrationBuilder.UpdateData(
                table: "UserHistories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Timestamp",
                value: "2023-05-05 14:24:05");

            migrationBuilder.UpdateData(
                table: "UserHistories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Timestamp",
                value: "2023-05-05 14:24:05");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "GoogleId",
                value: "goggle1");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "GoogleId",
                value: "google2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "GoogleId",
                value: "google3");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GoogleId",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "ChatMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Timestamp",
                value: "2023-04-12 13:14:25");

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Timestamp",
                value: "2023-04-12 13:14:25");

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "Timestamp",
                value: "2023-04-12 13:14:25");

            migrationBuilder.UpdateData(
                table: "UserHistories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Timestamp",
                value: "2023-04-12 13:14:25");

            migrationBuilder.UpdateData(
                table: "UserHistories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Timestamp",
                value: "2023-04-12 13:14:25");
        }
    }
}
