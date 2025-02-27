using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TennisSim.Migrations
{
    /// <inheritdoc />
    public partial class Check : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DrawMatches_Matches_MatchId",
                table: "DrawMatches");

            migrationBuilder.DropForeignKey(
                name: "FK_DrawMatches_UserNames_UserId",
                table: "DrawMatches");

            migrationBuilder.DropIndex(
                name: "IX_DrawMatches_UserId",
                table: "DrawMatches");

            migrationBuilder.DropColumn(
                name: "ByeCount",
                table: "Draws");

            migrationBuilder.DropColumn(
                name: "DrawSize",
                table: "Draws");

            migrationBuilder.DropColumn(
                name: "SeedCount",
                table: "Draws");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "DrawMatches");

            migrationBuilder.AlterColumn<int>(
                name: "MatchId",
                table: "DrawMatches",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "UserNameId",
                table: "DrawMatches",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DrawMatches_UserNameId",
                table: "DrawMatches",
                column: "UserNameId");

            migrationBuilder.AddForeignKey(
                name: "FK_DrawMatches_Matches_MatchId",
                table: "DrawMatches",
                column: "MatchId",
                principalTable: "Matches",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DrawMatches_UserNames_UserNameId",
                table: "DrawMatches",
                column: "UserNameId",
                principalTable: "UserNames",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DrawMatches_Matches_MatchId",
                table: "DrawMatches");

            migrationBuilder.DropForeignKey(
                name: "FK_DrawMatches_UserNames_UserNameId",
                table: "DrawMatches");

            migrationBuilder.DropIndex(
                name: "IX_DrawMatches_UserNameId",
                table: "DrawMatches");

            migrationBuilder.DropColumn(
                name: "UserNameId",
                table: "DrawMatches");

            migrationBuilder.AddColumn<int>(
                name: "ByeCount",
                table: "Draws",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DrawSize",
                table: "Draws",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SeedCount",
                table: "Draws",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "MatchId",
                table: "DrawMatches",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "DrawMatches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DrawMatches_UserId",
                table: "DrawMatches",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_DrawMatches_Matches_MatchId",
                table: "DrawMatches",
                column: "MatchId",
                principalTable: "Matches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DrawMatches_UserNames_UserId",
                table: "DrawMatches",
                column: "UserId",
                principalTable: "UserNames",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
