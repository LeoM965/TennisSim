using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TennisSim.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ScheduleMatches_Matches_MatchId",
                table: "ScheduleMatches");

            migrationBuilder.DropIndex(
                name: "IX_ScheduleMatches_MatchId",
                table: "ScheduleMatches");

            migrationBuilder.RenameColumn(
                name: "MatchId",
                table: "ScheduleMatches",
                newName: "DrawMatchId");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "ScheduleMatches",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Round",
                table: "ScheduleMatches",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleMatches_DrawMatchId",
                table: "ScheduleMatches",
                column: "DrawMatchId");

            migrationBuilder.AddForeignKey(
                name: "FK_ScheduleMatches_DrawMatches_DrawMatchId",
                table: "ScheduleMatches",
                column: "DrawMatchId",
                principalTable: "DrawMatches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ScheduleMatches_DrawMatches_DrawMatchId",
                table: "ScheduleMatches");

            migrationBuilder.DropIndex(
                name: "IX_ScheduleMatches_DrawMatchId",
                table: "ScheduleMatches");

            migrationBuilder.DropColumn(
                name: "Round",
                table: "ScheduleMatches");

            migrationBuilder.RenameColumn(
                name: "DrawMatchId",
                table: "ScheduleMatches",
                newName: "MatchId");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "ScheduleMatches",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleMatches_MatchId",
                table: "ScheduleMatches",
                column: "MatchId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ScheduleMatches_Matches_MatchId",
                table: "ScheduleMatches",
                column: "MatchId",
                principalTable: "Matches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
