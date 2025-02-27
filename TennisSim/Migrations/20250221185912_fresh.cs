using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TennisSim.Migrations
{
    /// <inheritdoc />
    public partial class fresh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MatchStats");

            migrationBuilder.DropTable(
                name: "PlayerCoaches");

            migrationBuilder.DropTable(
                name: "PlayerInjuryHistory");

            migrationBuilder.DropTable(
                name: "TrainingSessions");

            migrationBuilder.DropTable(
                name: "Coaches");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coaches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Specialty = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coaches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MatchStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MatchId = table.Column<int>(type: "int", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    Aces = table.Column<int>(type: "int", nullable: false),
                    BreakPointOpportunities = table.Column<int>(type: "int", nullable: false),
                    BreakPointsConverted = table.Column<int>(type: "int", nullable: false),
                    DoubleFaults = table.Column<int>(type: "int", nullable: false),
                    FirstServePercentage = table.Column<int>(type: "int", nullable: false),
                    FirstServePointsWon = table.Column<int>(type: "int", nullable: false),
                    GamesWon = table.Column<int>(type: "int", nullable: false),
                    ServiceGamesWon = table.Column<int>(type: "int", nullable: false),
                    SetsWon = table.Column<int>(type: "int", nullable: false),
                    TotalPointsWon = table.Column<int>(type: "int", nullable: false),
                    UnforcedErrors = table.Column<int>(type: "int", nullable: false),
                    Winners = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchStats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MatchStats_Matches_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Matches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MatchStats_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayerInjuryHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    InjuryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InjuryType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecoveryTime = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerInjuryHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerInjuryHistory_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PlayerCoaches",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    CoachId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Id = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerCoaches", x => new { x.PlayerId, x.CoachId });
                    table.ForeignKey(
                        name: "FK_PlayerCoaches_Coaches_CoachId",
                        column: x => x.CoachId,
                        principalTable: "Coaches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PlayerCoaches_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TrainingSessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoachId = table.Column<int>(type: "int", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    SessionType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingSessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingSessions_Coaches_CoachId",
                        column: x => x.CoachId,
                        principalTable: "Coaches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingSessions_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MatchStats_MatchId",
                table: "MatchStats",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchStats_PlayerId",
                table: "MatchStats",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerCoaches_CoachId",
                table: "PlayerCoaches",
                column: "CoachId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerInjuryHistory_PlayerId",
                table: "PlayerInjuryHistory",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingSessions_CoachId",
                table: "TrainingSessions",
                column: "CoachId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingSessions_PlayerId",
                table: "TrainingSessions",
                column: "PlayerId");
        }
    }
}
