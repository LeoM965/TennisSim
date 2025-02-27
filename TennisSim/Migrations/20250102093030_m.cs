using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TennisSim.Migrations
{
    /// <inheritdoc />
    public partial class m : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TournamentViews");

            migrationBuilder.CreateTable(
                name: "UserDraws",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserNameId = table.Column<int>(type: "int", nullable: false),
                    TournamentId = table.Column<int>(type: "int", nullable: false),
                    ViewedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDraws", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserDraws_Tournaments_TournamentId",
                        column: x => x.TournamentId,
                        principalTable: "Tournaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDraws_UserNames_UserNameId",
                        column: x => x.UserNameId,
                        principalTable: "UserNames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserDraws_TournamentId",
                table: "UserDraws",
                column: "TournamentId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDraws_UserNameId",
                table: "UserDraws",
                column: "UserNameId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserDraws");

            migrationBuilder.CreateTable(
                name: "TournamentViews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HasViewedDraw = table.Column<bool>(type: "bit", nullable: false),
                    HasViewedEntryList = table.Column<bool>(type: "bit", nullable: false),
                    TournamentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TournamentViews", x => x.Id);
                });
        }
    }
}
