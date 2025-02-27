using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TennisSim.Migrations
{
    /// <inheritdoc />
    public partial class b : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EntryLists_Players_PlayerId",
                table: "EntryLists");

            migrationBuilder.DropForeignKey(
                name: "FK_EntryLists_Tournaments_TournamentId",
                table: "EntryLists");

            migrationBuilder.DropIndex(
                name: "IX_EntryLists_PlayerId",
                table: "EntryLists");

            migrationBuilder.DropColumn(
                name: "AllocationDate",
                table: "EntryLists");

            migrationBuilder.DropColumn(
                name: "PlayerId",
                table: "EntryLists");

            migrationBuilder.DropColumn(
                name: "TournamentCategory",
                table: "EntryLists");

            migrationBuilder.DropColumn(
                name: "TournamentName",
                table: "EntryLists");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "EntryLists");

            migrationBuilder.RenameColumn(
                name: "TournamentId",
                table: "EntryLists",
                newName: "UserEntryListId");

            migrationBuilder.RenameIndex(
                name: "IX_EntryLists_TournamentId",
                table: "EntryLists",
                newName: "IX_EntryLists_UserEntryListId");

            migrationBuilder.CreateTable(
                name: "UserEntryLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserNameId = table.Column<int>(type: "int", nullable: false),
                    TournamentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEntryLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserEntryLists_Tournaments_TournamentId",
                        column: x => x.TournamentId,
                        principalTable: "Tournaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserEntryLists_UserNames_UserNameId",
                        column: x => x.UserNameId,
                        principalTable: "UserNames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserEntryLists_TournamentId",
                table: "UserEntryLists",
                column: "TournamentId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEntryLists_UserNameId",
                table: "UserEntryLists",
                column: "UserNameId");

            migrationBuilder.AddForeignKey(
                name: "FK_EntryLists_UserEntryLists_UserEntryListId",
                table: "EntryLists",
                column: "UserEntryListId",
                principalTable: "UserEntryLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EntryLists_UserEntryLists_UserEntryListId",
                table: "EntryLists");

            migrationBuilder.DropTable(
                name: "UserEntryLists");

            migrationBuilder.RenameColumn(
                name: "UserEntryListId",
                table: "EntryLists",
                newName: "TournamentId");

            migrationBuilder.RenameIndex(
                name: "IX_EntryLists_UserEntryListId",
                table: "EntryLists",
                newName: "IX_EntryLists_TournamentId");

            migrationBuilder.AddColumn<DateTime>(
                name: "AllocationDate",
                table: "EntryLists",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "PlayerId",
                table: "EntryLists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TournamentCategory",
                table: "EntryLists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TournamentName",
                table: "EntryLists",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "EntryLists",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_EntryLists_PlayerId",
                table: "EntryLists",
                column: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_EntryLists_Players_PlayerId",
                table: "EntryLists",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EntryLists_Tournaments_TournamentId",
                table: "EntryLists",
                column: "TournamentId",
                principalTable: "Tournaments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
