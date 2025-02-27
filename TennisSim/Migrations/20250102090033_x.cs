using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TennisSim.Migrations
{
    /// <inheritdoc />
    public partial class x : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DrawMatches_Players_Player1Id",
                table: "DrawMatches");

            migrationBuilder.DropForeignKey(
                name: "FK_DrawMatches_Players_Player2Id",
                table: "DrawMatches");

            migrationBuilder.DropForeignKey(
                name: "FK_DrawMatches_Players_WinnerId",
                table: "DrawMatches");

            migrationBuilder.DropForeignKey(
                name: "FK_Draws_Tournaments_TournamentId",
                table: "Draws");

            migrationBuilder.DropColumn(
                name: "DrawSize",
                table: "UserEntryLists");

            migrationBuilder.DropColumn(
                name: "SeedCount",
                table: "UserEntryLists");

            migrationBuilder.AddColumn<bool>(
                name: "HasViewedDraw",
                table: "UserEntryLists",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "TournamentViews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TournamentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HasViewedEntryList = table.Column<bool>(type: "bit", nullable: false),
                    HasViewedDraw = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TournamentViews", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_DrawMatches_Players_Player1Id",
                table: "DrawMatches",
                column: "Player1Id",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DrawMatches_Players_Player2Id",
                table: "DrawMatches",
                column: "Player2Id",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DrawMatches_Players_WinnerId",
                table: "DrawMatches",
                column: "WinnerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Draws_Tournaments_TournamentId",
                table: "Draws",
                column: "TournamentId",
                principalTable: "Tournaments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DrawMatches_Players_Player1Id",
                table: "DrawMatches");

            migrationBuilder.DropForeignKey(
                name: "FK_DrawMatches_Players_Player2Id",
                table: "DrawMatches");

            migrationBuilder.DropForeignKey(
                name: "FK_DrawMatches_Players_WinnerId",
                table: "DrawMatches");

            migrationBuilder.DropForeignKey(
                name: "FK_Draws_Tournaments_TournamentId",
                table: "Draws");

            migrationBuilder.DropTable(
                name: "TournamentViews");

            migrationBuilder.DropColumn(
                name: "HasViewedDraw",
                table: "UserEntryLists");

            migrationBuilder.AddColumn<int>(
                name: "DrawSize",
                table: "UserEntryLists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SeedCount",
                table: "UserEntryLists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_DrawMatches_Players_Player1Id",
                table: "DrawMatches",
                column: "Player1Id",
                principalTable: "Players",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DrawMatches_Players_Player2Id",
                table: "DrawMatches",
                column: "Player2Id",
                principalTable: "Players",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DrawMatches_Players_WinnerId",
                table: "DrawMatches",
                column: "WinnerId",
                principalTable: "Players",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Draws_Tournaments_TournamentId",
                table: "Draws",
                column: "TournamentId",
                principalTable: "Tournaments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
