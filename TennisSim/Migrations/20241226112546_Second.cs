using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TennisSim.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Backhand",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "Nationality",
                table: "Players");

            migrationBuilder.RenameColumn(
                name: "Speed",
                table: "Players",
                newName: "Ranking");

            migrationBuilder.RenameColumn(
                name: "Forehand",
                table: "Players",
                newName: "NationalityId");

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Players",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Coaches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Specialty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coaches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nationalities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationalities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlayerAttributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    AttributeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerAttributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerAttributes_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PlayerInjuryHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    InjuryType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InjuryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RecoveryTime = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerInjuryHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerInjuryHistory_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rankings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rank = table.Column<int>(type: "int", nullable: false),
                    Points = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rankings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rankings_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tournaments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Surface = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tournaments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlayerCoaches",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    CoachId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerCoaches", x => new { x.PlayerId, x.CoachId });
                    table.ForeignKey(
                        name: "FK_PlayerCoaches_Coaches_CoachId",
                        column: x => x.CoachId,
                        principalTable: "Coaches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PlayerCoaches_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TrainingSessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    CoachId = table.Column<int>(type: "int", nullable: false),
                    SessionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingSessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingSessions_Coaches_CoachId",
                        column: x => x.CoachId,
                        principalTable: "Coaches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingSessions_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Player1Id = table.Column<int>(type: "int", nullable: false),
                    Player2Id = table.Column<int>(type: "int", nullable: false),
                    TournamentId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WinnerId = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Round = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Matches_Players_Player1Id",
                        column: x => x.Player1Id,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Matches_Players_Player2Id",
                        column: x => x.Player2Id,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Matches_Players_WinnerId",
                        column: x => x.WinnerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Matches_Tournaments_TournamentId",
                        column: x => x.TournamentId,
                        principalTable: "Tournaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MatchStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MatchId = table.Column<int>(type: "int", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    Aces = table.Column<int>(type: "int", nullable: false),
                    DoubleFaults = table.Column<int>(type: "int", nullable: false),
                    Winners = table.Column<int>(type: "int", nullable: false),
                    UnforcedErrors = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchStats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MatchStats_Matches_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Matches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MatchStats_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Nationalities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Afghanistan" },
                    { 2, "Albania" },
                    { 3, "Algeria" },
                    { 4, "Andorra" },
                    { 5, "Angola" },
                    { 6, "Antigua and Barbuda" },
                    { 7, "Argentina" },
                    { 8, "Armenia" },
                    { 9, "Australia" },
                    { 10, "Austria" },
                    { 11, "Azerbaijan" },
                    { 12, "Bahamas" },
                    { 13, "Bahrain" },
                    { 14, "Bangladesh" },
                    { 15, "Barbados" },
                    { 16, "Belarus" },
                    { 17, "Belgium" },
                    { 18, "Belize" },
                    { 19, "Benin" },
                    { 20, "Bhutan" },
                    { 21, "Bolivia" },
                    { 22, "Bosnia and Herzegovina" },
                    { 23, "Botswana" },
                    { 24, "Brazil" },
                    { 25, "Brunei" },
                    { 26, "Bulgaria" },
                    { 27, "Burkina Faso" },
                    { 28, "Burundi" },
                    { 29, "Cabo Verde" },
                    { 30, "Cambodia" },
                    { 31, "Cameroon" },
                    { 32, "Canada" },
                    { 33, "Central African Republic" },
                    { 34, "Chad" },
                    { 35, "Chile" },
                    { 36, "China" },
                    { 37, "Colombia" },
                    { 38, "Comoros" },
                    { 39, "Congo (Congo-Brazzaville)" },
                    { 40, "Congo (Congo-Kinshasa)" },
                    { 41, "Costa Rica" },
                    { 42, "Croatia" },
                    { 43, "Cuba" },
                    { 44, "Cyprus" },
                    { 45, "Czech Republic" },
                    { 46, "Denmark" },
                    { 47, "Djibouti" },
                    { 48, "Dominica" },
                    { 49, "Dominican Republic" },
                    { 50, "Ecuador" },
                    { 51, "Egypt" },
                    { 52, "El Salvador" },
                    { 53, "Equatorial Guinea" },
                    { 54, "Eritrea" },
                    { 55, "Estonia" },
                    { 56, "Eswatini" },
                    { 57, "Ethiopia" },
                    { 58, "Fiji" },
                    { 59, "Finland" },
                    { 60, "France" },
                    { 61, "Gabon" },
                    { 62, "Gambia" },
                    { 63, "Georgia" },
                    { 64, "Germany" },
                    { 65, "Ghana" },
                    { 66, "Greece" },
                    { 67, "Grenada" },
                    { 68, "Guatemala" },
                    { 69, "Guinea" },
                    { 70, "Guinea-Bissau" },
                    { 71, "Guyana" },
                    { 72, "Haiti" },
                    { 73, "Honduras" },
                    { 74, "Hungary" },
                    { 75, "Iceland" },
                    { 76, "India" },
                    { 77, "Indonesia" },
                    { 78, "Iran" },
                    { 79, "Iraq" },
                    { 80, "Ireland" },
                    { 81, "Israel" },
                    { 82, "Italy" },
                    { 83, "Jamaica" },
                    { 84, "Japan" },
                    { 85, "Jordan" },
                    { 86, "Kazakhstan" },
                    { 87, "Kenya" },
                    { 88, "Kiribati" },
                    { 89, "Korea North" },
                    { 90, "Korea South" },
                    { 91, "Kuwait" },
                    { 92, "Kyrgyzstan" },
                    { 93, "Laos" },
                    { 94, "Latvia" },
                    { 95, "Lebanon" },
                    { 96, "Lesotho" },
                    { 97, "Liberia" },
                    { 98, "Libya" },
                    { 99, "Liechtenstein" },
                    { 100, "Lithuania" },
                    { 101, "Luxembourg" },
                    { 102, "Madagascar" },
                    { 103, "Malawi" },
                    { 104, "Malaysia" },
                    { 105, "Maldives" },
                    { 106, "Mali" },
                    { 107, "Malta" },
                    { 108, "Marshall Islands" },
                    { 109, "Mauritania" },
                    { 110, "Mauritius" },
                    { 111, "Mexico" },
                    { 112, "Micronesia" },
                    { 113, "Moldova" },
                    { 114, "Monaco" },
                    { 115, "Mongolia" },
                    { 116, "Montenegro" },
                    { 117, "Morocco" },
                    { 118, "Mozambique" },
                    { 119, "Myanmar (Burma)" },
                    { 120, "Namibia" },
                    { 121, "Nauru" },
                    { 122, "Nepal" },
                    { 123, "Netherlands" },
                    { 124, "New Zealand" },
                    { 125, "Nicaragua" },
                    { 126, "Niger" },
                    { 127, "Nigeria" },
                    { 128, "North Macedonia" },
                    { 129, "Norway" },
                    { 130, "Oman" },
                    { 131, "Pakistan" },
                    { 132, "Palau" },
                    { 133, "Panama" },
                    { 134, "Papua New Guinea" },
                    { 135, "Paraguay" },
                    { 136, "Peru" },
                    { 137, "Philippines" },
                    { 138, "Poland" },
                    { 139, "Portugal" },
                    { 140, "Qatar" },
                    { 141, "Romania" },
                    { 142, "Russia" },
                    { 143, "Rwanda" },
                    { 144, "Saint Kitts and Nevis" },
                    { 145, "Saint Lucia" },
                    { 146, "Saint Vincent and the Grenadines" },
                    { 147, "Samoa" },
                    { 148, "San Marino" },
                    { 149, "Sao Tome and Principe" },
                    { 150, "Saudi Arabia" },
                    { 151, "Senegal" },
                    { 152, "Serbia" },
                    { 153, "Seychelles" },
                    { 154, "Sierra Leone" },
                    { 155, "Singapore" },
                    { 156, "Slovakia" },
                    { 157, "Slovenia" },
                    { 158, "Solomon Islands" },
                    { 159, "Somalia" },
                    { 160, "South Africa" },
                    { 161, "South Sudan" },
                    { 162, "Spain" },
                    { 163, "Sri Lanka" },
                    { 164, "Sudan" },
                    { 165, "Suriname" },
                    { 166, "Sweden" },
                    { 167, "Switzerland" },
                    { 168, "Syria" },
                    { 169, "Taiwan" },
                    { 170, "Tajikistan" },
                    { 171, "Tanzania" },
                    { 172, "Thailand" },
                    { 173, "Timor-Leste" },
                    { 174, "Togo" },
                    { 175, "Tonga" },
                    { 176, "Trinidad and Tobago" },
                    { 177, "Tunisia" },
                    { 178, "Turkey" },
                    { 179, "Turkmenistan" },
                    { 180, "Tuvalu" },
                    { 181, "Uganda" },
                    { 182, "Ukraine" },
                    { 183, "United Arab Emirates" },
                    { 184, "United Kingdom" },
                    { 185, "United States" },
                    { 186, "Uruguay" },
                    { 187, "Uzbekistan" },
                    { 188, "Vanuatu" },
                    { 189, "Vatican City" },
                    { 190, "Venezuela" },
                    { 191, "Vietnam" },
                    { 192, "Yemen" },
                    { 193, "Zambia" },
                    { 194, "Zimbabwe" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Players_NationalityId",
                table: "Players",
                column: "NationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_Player1Id",
                table: "Matches",
                column: "Player1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_Player2Id",
                table: "Matches",
                column: "Player2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_TournamentId",
                table: "Matches",
                column: "TournamentId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_WinnerId",
                table: "Matches",
                column: "WinnerId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchStats_MatchId",
                table: "MatchStats",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchStats_PlayerId",
                table: "MatchStats",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerAttributes_PlayerId",
                table: "PlayerAttributes",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerCoaches_CoachId",
                table: "PlayerCoaches",
                column: "CoachId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerInjuryHistory_PlayerId",
                table: "PlayerInjuryHistory",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Rankings_PlayerId",
                table: "Rankings",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingSessions_CoachId",
                table: "TrainingSessions",
                column: "CoachId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingSessions_PlayerId",
                table: "TrainingSessions",
                column: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Nationalities_NationalityId",
                table: "Players",
                column: "NationalityId",
                principalTable: "Nationalities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Nationalities_NationalityId",
                table: "Players");

            migrationBuilder.DropTable(
                name: "MatchStats");

            migrationBuilder.DropTable(
                name: "Nationalities");

            migrationBuilder.DropTable(
                name: "PlayerAttributes");

            migrationBuilder.DropTable(
                name: "PlayerCoaches");

            migrationBuilder.DropTable(
                name: "PlayerInjuryHistory");

            migrationBuilder.DropTable(
                name: "Rankings");

            migrationBuilder.DropTable(
                name: "TrainingSessions");

            migrationBuilder.DropTable(
                name: "Matches");

            migrationBuilder.DropTable(
                name: "Coaches");

            migrationBuilder.DropTable(
                name: "Tournaments");

            migrationBuilder.DropIndex(
                name: "IX_Players_NationalityId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Players");

            migrationBuilder.RenameColumn(
                name: "Ranking",
                table: "Players",
                newName: "Speed");

            migrationBuilder.RenameColumn(
                name: "NationalityId",
                table: "Players",
                newName: "Forehand");

            migrationBuilder.AddColumn<int>(
                name: "Backhand",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Nationality",
                table: "Players",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
