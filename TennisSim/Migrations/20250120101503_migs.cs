using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TennisSim.Migrations
{
    /// <inheritdoc />
    public partial class migs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Draws_TournamentId",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Tournaments_TournamentId1",
                table: "Matches");

            migrationBuilder.RenameColumn(
                name: "TournamentId1",
                table: "Matches",
                newName: "DrawId");

            migrationBuilder.RenameIndex(
                name: "IX_Matches_TournamentId1",
                table: "Matches",
                newName: "IX_Matches_DrawId");

            migrationBuilder.AlterColumn<int>(
                name: "TournamentId",
                table: "Matches",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Draws_DrawId",
                table: "Matches",
                column: "DrawId",
                principalTable: "Draws",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Tournaments_TournamentId",
                table: "Matches",
                column: "TournamentId",
                principalTable: "Tournaments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Draws_DrawId",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Tournaments_TournamentId",
                table: "Matches");

            migrationBuilder.RenameColumn(
                name: "DrawId",
                table: "Matches",
                newName: "TournamentId1");

            migrationBuilder.RenameIndex(
                name: "IX_Matches_DrawId",
                table: "Matches",
                newName: "IX_Matches_TournamentId1");

            migrationBuilder.AlterColumn<int>(
                name: "TournamentId",
                table: "Matches",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Draws_TournamentId",
                table: "Matches",
                column: "TournamentId",
                principalTable: "Draws",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Tournaments_TournamentId1",
                table: "Matches",
                column: "TournamentId1",
                principalTable: "Tournaments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
