using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TennisSim.Migrations
{
    /// <inheritdoc />
    public partial class Check2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DrawMatches_UserNames_UserId",
                table: "DrawMatches");

            migrationBuilder.DropIndex(
                name: "IX_DrawMatches_UserId",
                table: "DrawMatches");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "DrawMatches");

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
                name: "FK_DrawMatches_UserNames_UserNameId",
                table: "DrawMatches");

            migrationBuilder.DropIndex(
                name: "IX_DrawMatches_UserNameId",
                table: "DrawMatches");

            migrationBuilder.DropColumn(
                name: "UserNameId",
                table: "DrawMatches");

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
                name: "FK_DrawMatches_UserNames_UserId",
                table: "DrawMatches",
                column: "UserId",
                principalTable: "UserNames",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
