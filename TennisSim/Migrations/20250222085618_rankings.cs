using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TennisSim.Migrations
{
    /// <inheritdoc />
    public partial class rankings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerAttributes_Players_PlayerId",
                table: "PlayerAttributes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlayerAttributes",
                table: "PlayerAttributes");

            migrationBuilder.RenameTable(
                name: "PlayerAttributes",
                newName: "PlayerAttribuztes");

            migrationBuilder.RenameIndex(
                name: "IX_PlayerAttributes_PlayerId",
                table: "PlayerAttribuztes",
                newName: "IX_PlayerAttribuztes_PlayerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlayerAttribuztes",
                table: "PlayerAttribuztes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerAttribuztes_Players_PlayerId",
                table: "PlayerAttribuztes",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerAttribuztes_Players_PlayerId",
                table: "PlayerAttribuztes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlayerAttribuztes",
                table: "PlayerAttribuztes");

            migrationBuilder.RenameTable(
                name: "PlayerAttribuztes",
                newName: "PlayerAttributes");

            migrationBuilder.RenameIndex(
                name: "IX_PlayerAttribuztes_PlayerId",
                table: "PlayerAttributes",
                newName: "IX_PlayerAttributes_PlayerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlayerAttributes",
                table: "PlayerAttributes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerAttributes_Players_PlayerId",
                table: "PlayerAttributes",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
