using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TennisSim.Migrations
{
    /// <inheritdoc />
    public partial class e : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DrawSize",
                table: "UserEntryLists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SeedCount",
                table: "UserEntryLists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Player1SeedNumber",
                table: "Matches",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Player2SeedNumber",
                table: "Matches",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasBye",
                table: "EntryLists",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSeeded",
                table: "EntryLists",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SeedNumber",
                table: "EntryLists",
                type: "int",
                nullable: true);

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

            migrationBuilder.AddColumn<DateTime>(
                name: "GeneratedDate",
                table: "Draws",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "SeedCount",
                table: "Draws",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Player1SeedNumber",
                table: "DrawMatches",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Player2SeedNumber",
                table: "DrawMatches",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DrawSize",
                table: "UserEntryLists");

            migrationBuilder.DropColumn(
                name: "SeedCount",
                table: "UserEntryLists");

            migrationBuilder.DropColumn(
                name: "Player1SeedNumber",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "Player2SeedNumber",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "HasBye",
                table: "EntryLists");

            migrationBuilder.DropColumn(
                name: "IsSeeded",
                table: "EntryLists");

            migrationBuilder.DropColumn(
                name: "SeedNumber",
                table: "EntryLists");

            migrationBuilder.DropColumn(
                name: "ByeCount",
                table: "Draws");

            migrationBuilder.DropColumn(
                name: "DrawSize",
                table: "Draws");

            migrationBuilder.DropColumn(
                name: "GeneratedDate",
                table: "Draws");

            migrationBuilder.DropColumn(
                name: "SeedCount",
                table: "Draws");

            migrationBuilder.DropColumn(
                name: "Player1SeedNumber",
                table: "DrawMatches");

            migrationBuilder.DropColumn(
                name: "Player2SeedNumber",
                table: "DrawMatches");
        }
    }
}
