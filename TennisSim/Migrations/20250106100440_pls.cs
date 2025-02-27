using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TennisSim.Migrations
{
    /// <inheritdoc />
    public partial class pls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_DrawMatches_MatchId",
                table: "DrawMatches");

            migrationBuilder.CreateIndex(
                name: "IX_DrawMatches_MatchId",
                table: "DrawMatches",
                column: "MatchId",
                unique: true,
                filter: "[MatchId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_DrawMatches_MatchId",
                table: "DrawMatches");

            migrationBuilder.CreateIndex(
                name: "IX_DrawMatches_MatchId",
                table: "DrawMatches",
                column: "MatchId");
        }
    }
}
