using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TennisSim.Migrations
{
    /// <inheritdoc />
    public partial class FinallyClean : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Tournaments_TournamentId",
                table: "Schedules");

            migrationBuilder.AlterColumn<int>(
                name: "TournamentId",
                table: "Schedules",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "DrawId",
                table: "Schedules",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_DrawId",
                table: "Schedules",
                column: "DrawId");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Draws_DrawId",
                table: "Schedules",
                column: "DrawId",
                principalTable: "Draws",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Tournaments_TournamentId",
                table: "Schedules",
                column: "TournamentId",
                principalTable: "Tournaments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Draws_DrawId",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Tournaments_TournamentId",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_DrawId",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "DrawId",
                table: "Schedules");

            migrationBuilder.AlterColumn<int>(
                name: "TournamentId",
                table: "Schedules",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Tournaments_TournamentId",
                table: "Schedules",
                column: "TournamentId",
                principalTable: "Tournaments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
