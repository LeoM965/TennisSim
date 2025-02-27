using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TennisSim.Migrations
{
    /// <inheritdoc />
    public partial class Fourth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PointDistribution",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<int>(type: "int", nullable: false),
                    Round = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Points = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PointDistribution", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "PointDistribution",
                columns: new[] { "Id", "Category", "Points", "Round" },
                values: new object[,]
                {
                    { 1, 0, 2000, "W" },
                    { 2, 0, 1300, "F" },
                    { 3, 0, 780, "SF" },
                    { 4, 0, 430, "QF" },
                    { 5, 0, 240, "R16" },
                    { 6, 0, 130, "R32" },
                    { 7, 0, 70, "R64" },
                    { 8, 0, 10, "R128" },
                    { 9, 0, 40, "Q" },
                    { 10, 0, 10, "Q1" },
                    { 11, 0, 20, "Q2" },
                    { 12, 0, 30, "Q3" },
                    { 13, 1, 1000, "W" },
                    { 14, 1, 650, "F" },
                    { 15, 1, 390, "SF" },
                    { 16, 1, 215, "QF" },
                    { 17, 1, 120, "R16" },
                    { 18, 1, 65, "R32" },
                    { 19, 1, 35, "R64" },
                    { 20, 1, 10, "R128" },
                    { 21, 1, 30, "Q" },
                    { 22, 1, 10, "Q1" },
                    { 23, 1, 20, "Q2" },
                    { 24, 1, 30, "Q3" },
                    { 25, 2, 500, "W" },
                    { 26, 2, 325, "F" },
                    { 27, 2, 195, "SF" },
                    { 28, 2, 108, "QF" },
                    { 29, 2, 60, "R16" },
                    { 30, 2, 32, "R32" },
                    { 31, 2, 1, "R64" },
                    { 32, 2, 25, "Q" },
                    { 33, 2, 13, "Q1" },
                    { 34, 2, 18, "Q2" },
                    { 35, 3, 250, "W" },
                    { 36, 3, 163, "F" },
                    { 37, 3, 98, "SF" },
                    { 38, 3, 54, "QF" },
                    { 39, 3, 30, "R16" },
                    { 40, 3, 1, "R32" },
                    { 41, 3, 18, "Q" },
                    { 42, 3, 12, "Q1" },
                    { 43, 3, 1, "Q2" },
                    { 44, 4, 100, "W" },
                    { 45, 4, 65, "F" },
                    { 46, 4, 39, "SF" },
                    { 47, 4, 21, "QF" },
                    { 48, 4, 12, "R16" },
                    { 49, 4, 7, "R32" },
                    { 50, 4, 5, "Q" },
                    { 51, 4, 3, "Q1" },
                    { 52, 4, 5, "Q2" },
                    { 53, 4, 7, "Q3" },
                    { 54, 5, 50, "W" },
                    { 55, 5, 33, "F" },
                    { 56, 5, 20, "SF" },
                    { 57, 5, 11, "QF" },
                    { 58, 5, 6, "R16" },
                    { 59, 5, 3, "R32" },
                    { 60, 5, 2, "Q" },
                    { 61, 5, 1, "Q1" },
                    { 62, 5, 2, "Q2" },
                    { 63, 5, 3, "Q3" },
                    { 64, 6, 25, "W" },
                    { 65, 6, 16, "F" },
                    { 66, 6, 9, "SF" },
                    { 67, 6, 5, "QF" },
                    { 68, 6, 3, "R16" },
                    { 69, 6, 2, "R32" },
                    { 70, 6, 1, "Q" },
                    { 71, 6, 1, "Q1" },
                    { 72, 6, 2, "Q2" },
                    { 73, 6, 3, "Q3" },
                    { 74, 7, 10, "W" },
                    { 75, 7, 6, "F" },
                    { 76, 7, 4, "SF" },
                    { 77, 7, 2, "QF" },
                    { 78, 7, 1, "R16" },
                    { 79, 7, 1, "R32" },
                    { 80, 7, 1, "Q" },
                    { 81, 7, 1, "Q1" },
                    { 82, 7, 1, "Q2" },
                    { 83, 7, 1, "Q3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PointDistribution");
        }
    }
}
