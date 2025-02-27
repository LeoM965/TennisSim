using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TennisSim.Migrations
{
    /// <inheritdoc />
    public partial class _6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.AddColumn<DateTime>(
                name: "QualifyingEndDate",
                table: "Tournaments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QualifyingRounds",
                table: "Tournaments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "QualifyingStartDate",
                table: "Tournaments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Category", "Points", "Round" },
                values: new object[] { 2, 500, "W" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Points", "Round" },
                values: new object[] { 325, "F" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Points", "Round" },
                values: new object[] { 195, "SF" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Points", "Round" },
                values: new object[] { 108, "QF" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Points", "Round" },
                values: new object[] { 60, "R16" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Points", "Round" },
                values: new object[] { 32, "R32" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Points", "Round" },
                values: new object[] { 1, "R64" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Points", "Round" },
                values: new object[] { 25, "Q" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Points", "Round" },
                values: new object[] { 13, "Q1" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Points", "Round" },
                values: new object[] { 18, "Q2" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Category", "Points", "Round" },
                values: new object[] { 3, 250, "W" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Points", "Round" },
                values: new object[] { 163, "F" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Points", "Round" },
                values: new object[] { 98, "SF" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Points", "Round" },
                values: new object[] { 54, "QF" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Points", "Round" },
                values: new object[] { 30, "R16" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Points", "Round" },
                values: new object[] { 1, "R32" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Points", "Round" },
                values: new object[] { 18, "Q" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Points", "Round" },
                values: new object[] { 12, "Q1" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Points", "Round" },
                values: new object[] { 1, "Q2" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Category", "Points", "Round" },
                values: new object[] { 4, 100, "W" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Points", "Round" },
                values: new object[] { 65, "F" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Points", "Round" },
                values: new object[] { 39, "SF" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Points", "Round" },
                values: new object[] { 21, "QF" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Points", "Round" },
                values: new object[] { 12, "R16" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Points", "Round" },
                values: new object[] { 7, "R32" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Points", "Round" },
                values: new object[] { 5, "Q" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Points", "Round" },
                values: new object[] { 3, "Q1" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Points", "Round" },
                values: new object[] { 5, "Q2" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Category", "Points", "Round" },
                values: new object[] { 5, 50, "W" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Category", "Points", "Round" },
                values: new object[] { 5, 33, "F" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Points", "Round" },
                values: new object[] { 20, "SF" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Points", "Round" },
                values: new object[] { 11, "QF" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Points", "Round" },
                values: new object[] { 6, "R16" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Points", "Round" },
                values: new object[] { 3, "R32" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Points", "Round" },
                values: new object[] { 2, "Q" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Points", "Round" },
                values: new object[] { 1, "Q1" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 60,
                column: "Round",
                value: "Q2");

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Category", "Points", "Round" },
                values: new object[] { 6, 25, "W" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Category", "Points", "Round" },
                values: new object[] { 6, 16, "F" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Category", "Points", "Round" },
                values: new object[] { 6, 9, "SF" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Points", "Round" },
                values: new object[] { 5, "QF" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Points", "Round" },
                values: new object[] { 3, "R16" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Points", "Round" },
                values: new object[] { 2, "R32" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Points", "Round" },
                values: new object[] { 1, "Q" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Points", "Round" },
                values: new object[] { 1, "Q1" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 69,
                column: "Round",
                value: "Q2");

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Category", "Points", "Round" },
                values: new object[] { 7, 10, "W" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Category", "Points", "Round" },
                values: new object[] { 7, 6, "F" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Category", "Points", "Round" },
                values: new object[] { 7, 4, "SF" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Category", "Points", "Round" },
                values: new object[] { 7, 2, "QF" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Points", "Round" },
                values: new object[] { 1, "R16" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Points", "Round" },
                values: new object[] { 1, "R32" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Points", "Round" },
                values: new object[] { 1, "Q" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Points", "Round" },
                values: new object[] { 1, "Q1" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 78,
                column: "Round",
                value: "Q2");

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Category", "Points", "Round" },
                values: new object[] { 8, 150, "W" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Category", "Points", "Round" },
                values: new object[] { 8, 90, "F" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Category", "Points", "Round" },
                values: new object[] { 8, 55, "SF" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Category", "Points", "Round" },
                values: new object[] { 8, 30, "QF" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Category", "Points", "Round" },
                values: new object[] { 8, 15, "R16" });

            migrationBuilder.InsertData(
                table: "PointDistributions",
                columns: new[] { "Id", "Category", "Points", "Round", "TournamentId" },
                values: new object[,]
                {
                    { 84, 8, 7, "R32", null },
                    { 85, 8, 4, "Q", null },
                    { 86, 8, 2, "Q1", null },
                    { 87, 8, 3, "Q2", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DropColumn(
                name: "QualifyingEndDate",
                table: "Tournaments");

            migrationBuilder.DropColumn(
                name: "QualifyingRounds",
                table: "Tournaments");

            migrationBuilder.DropColumn(
                name: "QualifyingStartDate",
                table: "Tournaments");

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Category", "Points", "Round" },
                values: new object[] { 1, 30, "Q3" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Points", "Round" },
                values: new object[] { 500, "W" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Points", "Round" },
                values: new object[] { 325, "F" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Points", "Round" },
                values: new object[] { 195, "SF" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Points", "Round" },
                values: new object[] { 108, "QF" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Points", "Round" },
                values: new object[] { 60, "R16" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Points", "Round" },
                values: new object[] { 32, "R32" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Points", "Round" },
                values: new object[] { 1, "R64" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Points", "Round" },
                values: new object[] { 25, "Q" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Points", "Round" },
                values: new object[] { 13, "Q1" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Category", "Points", "Round" },
                values: new object[] { 2, 18, "Q2" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Points", "Round" },
                values: new object[] { 250, "W" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Points", "Round" },
                values: new object[] { 163, "F" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Points", "Round" },
                values: new object[] { 98, "SF" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Points", "Round" },
                values: new object[] { 54, "QF" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Points", "Round" },
                values: new object[] { 30, "R16" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Points", "Round" },
                values: new object[] { 1, "R32" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Points", "Round" },
                values: new object[] { 18, "Q" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Points", "Round" },
                values: new object[] { 12, "Q1" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Category", "Points", "Round" },
                values: new object[] { 3, 1, "Q2" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Points", "Round" },
                values: new object[] { 100, "W" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Points", "Round" },
                values: new object[] { 65, "F" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Points", "Round" },
                values: new object[] { 39, "SF" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Points", "Round" },
                values: new object[] { 21, "QF" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Points", "Round" },
                values: new object[] { 12, "R16" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Points", "Round" },
                values: new object[] { 7, "R32" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Points", "Round" },
                values: new object[] { 5, "Q" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Points", "Round" },
                values: new object[] { 3, "Q1" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Category", "Points", "Round" },
                values: new object[] { 4, 5, "Q2" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Category", "Points", "Round" },
                values: new object[] { 4, 7, "Q3" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Points", "Round" },
                values: new object[] { 50, "W" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Points", "Round" },
                values: new object[] { 33, "F" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Points", "Round" },
                values: new object[] { 20, "SF" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Points", "Round" },
                values: new object[] { 11, "QF" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Points", "Round" },
                values: new object[] { 6, "R16" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Points", "Round" },
                values: new object[] { 3, "R32" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 60,
                column: "Round",
                value: "Q");

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Category", "Points", "Round" },
                values: new object[] { 5, 1, "Q1" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Category", "Points", "Round" },
                values: new object[] { 5, 2, "Q2" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Category", "Points", "Round" },
                values: new object[] { 5, 3, "Q3" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Points", "Round" },
                values: new object[] { 25, "W" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Points", "Round" },
                values: new object[] { 16, "F" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Points", "Round" },
                values: new object[] { 9, "SF" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Points", "Round" },
                values: new object[] { 5, "QF" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Points", "Round" },
                values: new object[] { 3, "R16" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 69,
                column: "Round",
                value: "R32");

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Category", "Points", "Round" },
                values: new object[] { 6, 1, "Q" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Category", "Points", "Round" },
                values: new object[] { 6, 1, "Q1" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Category", "Points", "Round" },
                values: new object[] { 6, 2, "Q2" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Category", "Points", "Round" },
                values: new object[] { 6, 3, "Q3" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Points", "Round" },
                values: new object[] { 10, "W" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Points", "Round" },
                values: new object[] { 6, "F" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Points", "Round" },
                values: new object[] { 4, "SF" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Points", "Round" },
                values: new object[] { 2, "QF" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 78,
                column: "Round",
                value: "R16");

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Category", "Points", "Round" },
                values: new object[] { 7, 1, "R32" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Category", "Points", "Round" },
                values: new object[] { 7, 1, "Q" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Category", "Points", "Round" },
                values: new object[] { 7, 1, "Q1" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Category", "Points", "Round" },
                values: new object[] { 7, 1, "Q2" });

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Category", "Points", "Round" },
                values: new object[] { 7, 1, "Q3" });

            migrationBuilder.InsertData(
                table: "PointDistributions",
                columns: new[] { "Id", "Category", "Points", "Round", "TournamentId" },
                values: new object[,]
                {
                    { 92, 8, 150, "W", null },
                    { 93, 8, 90, "F", null },
                    { 94, 8, 55, "SF", null },
                    { 95, 8, 30, "QF", null },
                    { 96, 8, 15, "R16", null },
                    { 97, 8, 7, "R32", null },
                    { 98, 8, 4, "Q", null },
                    { 99, 8, 2, "Q1", null }
                });
        }
    }
}
