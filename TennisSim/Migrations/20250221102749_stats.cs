using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TennisSim.Migrations
{
    /// <inheritdoc />
    public partial class stats : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BreakPointOpportunities",
                table: "MatchStats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BreakPointsConverted",
                table: "MatchStats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FirstServePercentage",
                table: "MatchStats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FirstServePointsWon",
                table: "MatchStats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GamesWon",
                table: "MatchStats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ServiceGamesWon",
                table: "MatchStats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SetsWon",
                table: "MatchStats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalPointsWon",
                table: "MatchStats",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BreakPointOpportunities",
                table: "MatchStats");

            migrationBuilder.DropColumn(
                name: "BreakPointsConverted",
                table: "MatchStats");

            migrationBuilder.DropColumn(
                name: "FirstServePercentage",
                table: "MatchStats");

            migrationBuilder.DropColumn(
                name: "FirstServePointsWon",
                table: "MatchStats");

            migrationBuilder.DropColumn(
                name: "GamesWon",
                table: "MatchStats");

            migrationBuilder.DropColumn(
                name: "ServiceGamesWon",
                table: "MatchStats");

            migrationBuilder.DropColumn(
                name: "SetsWon",
                table: "MatchStats");

            migrationBuilder.DropColumn(
                name: "TotalPointsWon",
                table: "MatchStats");
        }
    }
}
