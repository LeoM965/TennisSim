using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TennisSim.Migrations
{
    /// <inheritdoc />
    public partial class Terog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DrawMatches_Matches_MatchId",
                table: "DrawMatches");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Draws_DrawId",
                table: "Matches");

            migrationBuilder.DropIndex(
                name: "IX_DrawMatches_MatchId",
                table: "DrawMatches");

            migrationBuilder.DropColumn(
                name: "GeneratedDate",
                table: "Draws");

            migrationBuilder.RenameTable(
                name: "PlayerAttribuztes",
                newName: "PlayerAttributes");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
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
                name: "IX_Draws_UserId",
                table: "Draws",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DrawMatches_MatchId",
                table: "DrawMatches",
                column: "MatchId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Draws_UserNames_UserId",
                table: "Draws",
                column: "UserId",
                principalTable: "UserNames",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);


            migrationBuilder.AddForeignKey(
                name: "FK_PlayerAttributes_Players_PlayerId",
                table: "PlayerAttributes",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rankings_Players_PlayerId",
                table: "Rankings",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DrawMatches_Matches_MatchId",
                table: "DrawMatches");

            migrationBuilder.DropForeignKey(
                name: "FK_DrawMatches_UserNames_UserId",
                table: "DrawMatches");

            migrationBuilder.DropForeignKey(
                name: "FK_Draws_UserNames_UserId",
                table: "Draws");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Draws_DrawId",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerAttributes_Players_PlayerId",
                table: "PlayerAttributes");

            migrationBuilder.DropForeignKey(
                name: "FK_Rankings_Players_PlayerId",
                table: "Rankings");

            migrationBuilder.DropIndex(
                name: "IX_Draws_UserId",
                table: "Draws");

            migrationBuilder.DropIndex(
                name: "IX_DrawMatches_MatchId",
                table: "DrawMatches");

            migrationBuilder.DropIndex(
                name: "IX_DrawMatches_UserId",
                table: "DrawMatches");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlayerAttributes",
                table: "PlayerAttributes");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Draws");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "DrawMatches");

            migrationBuilder.RenameTable(
                name: "PlayerAttributes",
                newName: "PlayerAttribuztes");

            migrationBuilder.RenameIndex(
                name: "IX_PlayerAttributes_PlayerId",
                table: "PlayerAttribuztes",
                newName: "IX_PlayerAttribuztes_PlayerId");

            migrationBuilder.AddColumn<DateTime>(
                name: "GeneratedDate",
                table: "Draws",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<int>(
                name: "MatchId",
                table: "DrawMatches",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlayerAttribuztes",
                table: "PlayerAttribuztes",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_DrawMatches_MatchId",
                table: "DrawMatches",
                column: "MatchId",
                unique: true,
                filter: "[MatchId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_DrawMatches_Matches_MatchId",
                table: "DrawMatches",
                column: "MatchId",
                principalTable: "Matches",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Draws_DrawId",
                table: "Matches",
                column: "DrawId",
                principalTable: "Draws",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerAttribuztes_Players_PlayerId",
                table: "PlayerAttribuztes",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rankings_Players_PlayerId",
                table: "Rankings",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
