using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TennisSim.Migrations
{
    /// <inheritdoc />
    public partial class _5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PointDistribution",
                table: "PointDistribution");

            migrationBuilder.RenameTable(
                name: "PointDistribution",
                newName: "PointDistributions");

            migrationBuilder.AddColumn<int>(
                name: "TournamentId",
                table: "PointDistributions",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PointDistributions",
                table: "PointDistributions",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 1,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 2,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 3,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 4,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 5,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 6,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 7,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 8,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 9,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 10,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 11,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 12,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 13,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 14,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 15,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 16,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 17,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 18,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 19,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 20,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 21,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 22,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 23,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 24,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 25,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 26,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 27,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 28,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 29,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 30,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 31,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 32,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 33,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 34,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 35,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 36,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 37,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 38,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 39,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 40,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 41,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 42,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 43,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 44,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 45,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 46,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 47,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 48,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 49,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 50,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 51,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 52,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 53,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 54,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 55,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 56,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 57,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 58,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 59,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 60,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 61,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 62,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 63,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 64,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 65,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 66,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 67,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 68,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 69,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 70,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 71,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 72,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 73,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 74,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 75,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 76,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 77,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 78,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 79,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 80,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 81,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 82,
                column: "TournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PointDistributions",
                keyColumn: "Id",
                keyValue: 83,
                column: "TournamentId",
                value: null);

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

            migrationBuilder.CreateIndex(
                name: "IX_PointDistributions_TournamentId",
                table: "PointDistributions",
                column: "TournamentId");

            migrationBuilder.AddForeignKey(
                name: "FK_PointDistributions_Tournaments_TournamentId",
                table: "PointDistributions",
                column: "TournamentId",
                principalTable: "Tournaments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PointDistributions_Tournaments_TournamentId",
                table: "PointDistributions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PointDistributions",
                table: "PointDistributions");

            migrationBuilder.DropIndex(
                name: "IX_PointDistributions_TournamentId",
                table: "PointDistributions");

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

            migrationBuilder.DropColumn(
                name: "TournamentId",
                table: "PointDistributions");

            migrationBuilder.RenameTable(
                name: "PointDistributions",
                newName: "PointDistribution");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PointDistribution",
                table: "PointDistribution",
                column: "Id");
        }
    }
}
