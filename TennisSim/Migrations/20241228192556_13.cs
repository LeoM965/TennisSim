using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TennisSim.Migrations
{
    /// <inheritdoc />
    public partial class _13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 151,
                column: "Surface",
                value: "Hard Indoor");

            migrationBuilder.UpdateData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 164,
                column: "Surface",
                value: "Hard Indoor");

            migrationBuilder.UpdateData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 168,
                column: "Surface",
                value: "Hard Indoor");

            migrationBuilder.UpdateData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 181,
                column: "Surface",
                value: "Hard Indoor");

            migrationBuilder.UpdateData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 201,
                column: "Surface",
                value: "Hard Indoor");

            migrationBuilder.UpdateData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 207,
                column: "Surface",
                value: "Hard Indoor");

            migrationBuilder.UpdateData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 213,
                column: "Surface",
                value: "Hard Indoor");

            migrationBuilder.UpdateData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 214,
                column: "Surface",
                value: "Hard Indoor");

            migrationBuilder.UpdateData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 218,
                column: "Surface",
                value: "Hard Indoor");

            migrationBuilder.UpdateData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 219,
                column: "Surface",
                value: "Hard Indoor");

            migrationBuilder.UpdateData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 225,
                column: "Surface",
                value: "Hard Indoor");

            migrationBuilder.UpdateData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 226,
                column: "Surface",
                value: "Hard Indoor");

            migrationBuilder.UpdateData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 233,
                column: "Surface",
                value: "Hard Indoor");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 151,
                column: "Surface",
                value: "Indoor Hard");

            migrationBuilder.UpdateData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 164,
                column: "Surface",
                value: "Grass");

            migrationBuilder.UpdateData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 168,
                column: "Surface",
                value: "Grass");

            migrationBuilder.UpdateData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 181,
                column: "Surface",
                value: "Grass");

            migrationBuilder.UpdateData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 201,
                column: "Surface",
                value: "Indoor Hard");

            migrationBuilder.UpdateData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 207,
                column: "Surface",
                value: "Indoor Hard");

            migrationBuilder.UpdateData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 213,
                column: "Surface",
                value: "Indoor Hard");

            migrationBuilder.UpdateData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 214,
                column: "Surface",
                value: "Indoor Hard");

            migrationBuilder.UpdateData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 218,
                column: "Surface",
                value: "Indoor Hard");

            migrationBuilder.UpdateData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 219,
                column: "Surface",
                value: "Indoor Hard");

            migrationBuilder.UpdateData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 225,
                column: "Surface",
                value: "Indoor Hard");

            migrationBuilder.UpdateData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 226,
                column: "Surface",
                value: "Indoor Hard");

            migrationBuilder.UpdateData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 233,
                column: "Surface",
                value: "Indoor Hard");
        }
    }
}
