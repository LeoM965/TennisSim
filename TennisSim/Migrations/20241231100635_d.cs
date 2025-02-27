using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TennisSim.Migrations
{
    /// <inheritdoc />
    public partial class d : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Draws",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TournamentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Draws", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Draws_Tournaments_TournamentId",
                        column: x => x.TournamentId,
                        principalTable: "Tournaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DrawMatches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DrawId = table.Column<int>(type: "int", nullable: false),
                    Round = table.Column<int>(type: "int", nullable: false),
                    MatchNumber = table.Column<int>(type: "int", nullable: false),
                    Player1Id = table.Column<int>(type: "int", nullable: true),
                    Player2Id = table.Column<int>(type: "int", nullable: true),
                    IsBye = table.Column<bool>(type: "bit", nullable: false),
                    WinnerId = table.Column<int>(type: "int", nullable: true),
                    MatchId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrawMatches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DrawMatches_Draws_DrawId",
                        column: x => x.DrawId,
                        principalTable: "Draws",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DrawMatches_Matches_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Matches",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DrawMatches_Players_Player1Id",
                        column: x => x.Player1Id,
                        principalTable: "Players",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DrawMatches_Players_Player2Id",
                        column: x => x.Player2Id,
                        principalTable: "Players",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DrawMatches_Players_WinnerId",
                        column: x => x.WinnerId,
                        principalTable: "Players",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DrawMatches_DrawId",
                table: "DrawMatches",
                column: "DrawId");

            migrationBuilder.CreateIndex(
                name: "IX_DrawMatches_MatchId",
                table: "DrawMatches",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_DrawMatches_Player1Id",
                table: "DrawMatches",
                column: "Player1Id");

            migrationBuilder.CreateIndex(
                name: "IX_DrawMatches_Player2Id",
                table: "DrawMatches",
                column: "Player2Id");

            migrationBuilder.CreateIndex(
                name: "IX_DrawMatches_WinnerId",
                table: "DrawMatches",
                column: "WinnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Draws_TournamentId",
                table: "Draws",
                column: "TournamentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DrawMatches");

            migrationBuilder.DropTable(
                name: "Draws");
        }
    }
}
