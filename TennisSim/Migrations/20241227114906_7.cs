using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TennisSim.Migrations
{
    /// <inheritdoc />
    public partial class _7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tournaments",
                columns: new[] { "Id", "Category", "EndDate", "Location", "Name", "QualifyingEndDate", "QualifyingRounds", "QualifyingStartDate", "StartDate", "Surface" },
                values: new object[,]
                {
                    { 1, "Masters500", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Australia", "Brisbane Masters500", new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 2, "Masters250", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "New Zealand", "Auckland Masters250", new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 3, "ITF100K", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Australia", "Canberra ITF100K", new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 4, "ITF50K", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thailand", "Nonthaburi1 ITF50K", new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 5, "ITF25K", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "USA", "Arcadia ITF25K", new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 6, "ITF10K", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tunisia", "Monastir1 ITF10K", new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 7, "Masters500", new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Australia", "Adelaide Masters500", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 8, "Masters250", new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Australia", "Hobart Masters250", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 9, "ITF50K", new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thailand", "Nonthaburi2 ITF50K", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 10, "ITF25K", new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "USA", "Naples1 ITF25K", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 11, "ITF10K", new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tunisia", "Monastir2 ITF10K", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 12, "GrandSlam", new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Australia", "Australian Open", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 13, "ITF50K", new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "India", "Bengaluru ITF50K", new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 14, "ITF25K", new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "USA", "Naples2 ITF25K", new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 15, "ITF25K", new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tunisia", "Monastir3 ITF25K", new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 16, "ITF50K", new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "USA", "Vero Beach ITF50K", new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 17, "ITF50K", new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "India", "Pune ITF50K", new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 18, "ITF25K", new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tunisia", "Monastir4 ITF25K", new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 19, "ITF10K", new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Turkey", "Antalya1 ITF10K", new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 20, "Masters500", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Austria", "Linz Masters500", new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard Indoor" },
                    { 21, "Masters250", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thailand", "Hua Hin Masters250", new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 22, "ITF100K", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Australia", "Burnie ITF100K", new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 23, "ITF50K", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "India", "Indore ITF50K", new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 24, "ITF10K", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tunisia", "Monastir5 ITF10K", new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 25, "ITF10K", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Turkey", "Antalya2 ITF10K", new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 26, "Masters500", new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "UAE", "Abu Dhabi Masters500", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 27, "Masters250", new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Romania", "Transylvania Masters250", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard Indoor" },
                    { 28, "ITF100K", new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "India", "Mumbai ITF100K", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 29, "ITF50K", new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "France", "Grenoble ITF50K", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard Indoor" },
                    { 30, "ITF10K", new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tunisia", "Monastir6 ITF10K", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 31, "ITF10K", new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Turkey", "Antalya3 ITF10K", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 32, "Masters1000", new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Qatar", "Qatar Open Masters1000", new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 33, "ITF50K", new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Germany", "Altenkirchen ITF50K", new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carpet" },
                    { 34, "ITF50K", new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mexico", "Morelia ITF50K", new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 35, "ITF10K", new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spain", "Monacor1 ITF10K", new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 36, "ITF10K", new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Turkey", "Antalya4 ITF10K", new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 37, "Masters1000", new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "UAE", "Dubai Open Masters1000", new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 38, "ITF100K", new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mexico", "Puerta Vallarta ITF100K", new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 39, "ITF25K", new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mexico", "Mexico City ITF25K", new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 40, "ITF10K", new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spain", "Monacor2 ITF15K", new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 41, "Masters500", new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "USA", "San Diego Masters500", new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 42, "Masters250", new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "USA", "Austin Masters250", new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 43, "ITF50K", new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "South Africa", "Pretoria1 ITF50K", new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 44, "ITF25K", new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Slovakia", "Trnava1 ITF25K", new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard Indoor" },
                    { 45, "ITF10K", new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spain", "Monacor3 ITF15K", new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 46, "Masters1000", new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "USA", "Indian Wells Masters1000", new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 47, "ITF50K", new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "South Africa", "Pretoria2 ITF50K", new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 48, "ITF50K", new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Slovakia", "Trnava2 ITF50K", new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard Indoor" },
                    { 49, "ITF10K", new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Greece", "Heraklion1 ITF10K", new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 50, "ITF100K", new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "USA", "Indian Wells", new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 51, "ITF100K", new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "USA", "Charleston.ITF ITF100K", new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 52, "ITF50K", new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Czechia", "Ricany ITF50K", new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard Indoor" },
                    { 53, "ITF25K", new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cyprus", "Alaminos-Larnaca1 ITF25K", new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 54, "ITF10K", new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Greece", "Heraklion2 ITF10K", new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 55, "Masters1000", new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "USA", "Miami Masters1000", new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 56, "ITF50K", new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Slovenia", "Maribor ITF50K", new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard Indoor" },
                    { 57, "ITF25K", new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cyprus", "Alaminos-Larnaca2 ITF25K", new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 58, "ITF100K", new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mexico", "San Luis ITF100K", new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 59, "ITF100K", new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Turkey", "Megasaray Antalya ITF100K", new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 60, "ITF50K", new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Slovenia", "Murska Sobota ITF50K", new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard Indoor" },
                    { 61, "ITF10K", new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Italy", "Santa Margherita Di Pula1 ITF10K", new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 62, "Masters500", new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "USA", "Charleston Masters500", new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 63, "Masters250", new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Colombia", "Bogota Masters250", new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 64, "ITF100K", new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spain", "La Bisbal d'Emporda ITF100K", new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 65, "ITF50K", new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Croatia", "Split ITF50K", new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 66, "ITF10K", new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Italy", "Santa Margherita Di Pula2 ITF10K", new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 67, "ITF100K", new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spain", "Zaragoza ITF100K", new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 68, "ITF25K", new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Switzerland", "Bellinzona ITF25K", new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 69, "ITF25K", new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Burundi", "Bujumbura1 ITF25K", new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 70, "ITF10K", new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Italy", "Santa Margherita Di Pula3 ITF10K", new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 71, "Masters500", new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Germany", "Stuttgart Masters500", new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 72, "Masters250", new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "France", "Rouen Masters250", new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 73, "ITF100K", new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Portugal", "Oeiras1 ITF100K", new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 74, "ITF50K", new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Switzerland", "Chiasso ITF50K", new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 75, "ITF25K", new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Burundi", "Bujumbura2 ITF25K", new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 76, "ITF10K", new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Italy", "Santa Margherita Di Pula4 ITF10K", new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 77, "Masters1000", new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spain", "Madrid Masters1000", new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 78, "ITF50K", new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Portugal", "Oeiras2 ITF50K", new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 79, "ITF25K", new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Georgia", "Lopota1 ITF25K", new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 80, "ITF25K", new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Great Britain", "Nottingham ITF25K", new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 81, "ITF10K", new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kazakhstan", "Shymkent ITF10K", new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 82, "Challenger", new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spain", "Madrid Masters125", new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 83, "ITF100K", new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "France", "Saint-Malo ITF100K", new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 84, "ITF100K", new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spain", "Lleida ITF100K", new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 85, "ITF50K", new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "USA", "Bonita Springs ITF50K", new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 86, "ITF25K", new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Georgia", "Lopota2 ITF25K", new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 87, "ITF10K", new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sweden", "Varberg ITF10K", new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 88, "Masters1000", new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Italy", "Rome Masters1000", new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 89, "ITF50K", new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "USA", "Zephyrhills ITF50K", new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 90, "ITF50K", new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sweden", "Bastad ITF50K", new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 91, "ITF10K", new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Serbia", "Kursumlijska Banja1 ITF10K", new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 92, "Challenger", new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Italy", "Rome Masters125", new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 93, "ITF100K", new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "France", "Clarins ITF100K", new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 94, "ITF100K", new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Italy", "Parma ITF100K", new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 95, "ITF50K", new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Austria", "Villach ITF50K", new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 96, "ITF50K", new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "USA", "Bethany Beach ITF50K", new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 97, "ITF25K", new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Serbia", "Kursumlijska Banja2 ITF25K", new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 98, "Masters500", new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "France", "Strasbourg Masters500", new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 99, "ITF50K", new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Italy", "Grado ITF50K", new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 100, "ITF50K", new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "South Korea", "Goyang ITF50K", new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 101, "ITF25K", new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Austria", "Annenheim ITF25K", new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 102, "ITF25K", new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Serbia", "Kursumlijska Banja3 ITF25K", new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 103, "GrandSlam", new DateTime(2024, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "France", "French Open GrandSlam", new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 104, "ITF50K", new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Germany", "Troisdorf ITF50K", new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 105, "ITF25K", new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "South Korea", "Changwon ITF25K", new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 106, "ITF10K", new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Romania", "Galati ITF10K", new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 107, "ITF10K", new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tunisia", "Monastir7 ITF10K", new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 108, "Challenger", new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "France", "French Open Challenger", new DateTime(2024, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 109, "ITF100K", new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Croatia", "Makarska ITF100K", new DateTime(2024, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 110, "ITF100K", new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Italy", "Bari ITF100K", new DateTime(2024, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 111, "ITF50K", new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Great Britain", "Surbiton ITF50K", new DateTime(2024, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grass" },
                    { 112, "ITF25K", new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "USA", "Sumter ITF25K", new DateTime(2024, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 113, "ITF10K", new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tunisia", "Monastir8 ITF10K", new DateTime(2024, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 114, "Masters250", new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Netherlands", "Libema Open Masters250", new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grass" },
                    { 115, "Masters250", new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Great Britain", "Nottingham Open Masters250", new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grass" },
                    { 116, "ITF100K", new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spain", "Valencia ITF100K", new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 117, "ITF25K", new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Poland", "Gdansk ITF25K", new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 118, "ITF25K", new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "USA", "San Diego ITF25K", new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 119, "ITF10K", new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tunisia", "Monastir9 ITF10K", new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 120, "Masters500", new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Germany", "Berlin Masters500", new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grass" },
                    { 121, "Masters250", new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Great Britain", "Birmingham Masters250", new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grass" },
                    { 122, "ITF100K", new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Great Britain", "Ikley ITF100K", new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grass" },
                    { 123, "ITF100K", new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Italy", "Gaiba ITF100K", new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grass" },
                    { 125, "ITF10K", new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tunisia", "Monastir10 ITF10K", new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 126, "Masters500", new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Germany", "Bad Homburg Masters500", new DateTime(2024, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grass" },
                    { 127, "Masters500", new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Great Britain", "Eastbourne Masters500", new DateTime(2024, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grass" },
                    { 128, "ITF50K", new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Czechia", "Stare Splavy ITF50K", new DateTime(2024, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 129, "ITF25K", new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Taipei", "Taipei ITF25K", new DateTime(2024, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 130, "ITF10K", new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "China", "Tianjin ITF10K", new DateTime(2024, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 131, "GrandSlam", new DateTime(2024, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Great Britain", "Wimbledon GrandSlam", new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2024, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grass" },
                    { 132, "ITF50K", new DateTime(2024, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Germany", "Stuttgart-Vaihingen ITF50K", new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 133, "ITF25K", new DateTime(2024, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hong Kong", "Hong Kong ITF25K", new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 134, "ITF10K", new DateTime(2024, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Netherlands", "Amstelveen ITF10K", new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 135, "ITF10K", new DateTime(2024, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hungary", "Mogyorod ITF10K", new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 136, "Challenger", new DateTime(2024, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Great Britain", "Wimbledon 125k", new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grass" },
                    { 137, "ITF100K", new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sweden", "Bastad ITF100K", new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 138, "ITF100K", new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "France", "Contrexeville ITF100K", new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 139, "ITF50K", new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Netherlands", "The Hague ITF50K", new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 140, "ITF25K", new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thailand", "Nakhon Si Thammarat ITF25K", new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 141, "ITF10K", new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Poland", "Grodzisk Mazowiecki ITF10K", new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 142, "Masters250", new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Italy", "Palermo Masters250", new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 143, "Masters250", new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hungary", "Budapest Masters250", new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 144, "ITF50K", new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Canada", "Granby ITF50K", new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 145, "ITF50K", new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Great Britain", "Nottingham ITF50K", new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grass" },
                    { 146, "ITF10K", new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Morocco", "Casablanca1 ITF10K", new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 147, "ITF10K", new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Romania", "Timisoara ITF10K", new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 148, "Masters250", new DateTime(2024, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Romania", "Iasi Masters250", new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 149, "Masters250", new DateTime(2024, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Czechia", "Prague Masters250", new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 150, "ITF100K", new DateTime(2024, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Poland", "Warsaw ITF100K", new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 151, "ITF50K", new DateTime(2024, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "USA", "Dallas ITF50K", new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Indoor Hard" },
                    { 152, "ITF25K", new DateTime(2024, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Morocco", "Casablanca2 ITF25K", new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 153, "ITF10K", new DateTime(2024, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kazakhstan", "Astana ITF10K", new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 154, "Masters500", new DateTime(2024, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "USA", "Washington Masters500", new DateTime(2024, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 155, "ITF50K", new DateTime(2024, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "USA", "Lexington ITF50K", new DateTime(2024, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 156, "ITF25K", new DateTime(2024, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Morocco", "Mohammedia ITF25K", new DateTime(2024, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 157, "ITF25K", new DateTime(2024, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Denmark", "Koge ITF25K", new DateTime(2024, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 158, "ITF10K", new DateTime(2024, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kazakhstan", "Ust-Kamenogorsk ITF10K", new DateTime(2024, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 159, "ITF10K", new DateTime(2024, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Romania", "Brasov ITF10K", new DateTime(2024, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 160, "Masters1000", new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Canada", "Canadian Open Masters1000", new DateTime(2024, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 161, "ITF100K", new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Germany", "Hamburg ITF100K", new DateTime(2024, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 162, "ITF50K", new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "USA", "Landisville ITF50K", new DateTime(2024, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 163, "ITF25K", new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Belgium", "Koksijde ITF25K", new DateTime(2024, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 164, "ITF25K", new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Great Britain", "Roehampton ITF25K", new DateTime(2024, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grass" },
                    { 165, "ITF10K", new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ireland", "Dublin ITF10K", new DateTime(2024, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carpet" },
                    { 166, "Masters1000", new DateTime(2024, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "USA", "Cincinnati Masters1000", new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 167, "ITF100K", new DateTime(2024, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "South Korea", "Seoul ITF100K", new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 168, "ITF50K", new DateTime(2024, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "USA", "Newport ITF50K", new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grass" },
                    { 169, "ITF25K", new DateTime(2024, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Russia", "Moscow ITF25K", new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 170, "ITF25K", new DateTime(2024, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Puerto Rico", "San Juan ITF25K", new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 171, "ITF10K", new DateTime(2024, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tunisia", "Tunis ITF10K", new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 172, "GrandSlam", new DateTime(2024, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "USA", "US Open Grand Slam", new DateTime(2024, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 173, "ITF100K", new DateTime(2024, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "USA", "Los Angeles ITF100K", new DateTime(2024, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 174, "ITF50K", new DateTime(2024, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Switzerland", "Gstaad ITF50K", new DateTime(2024, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 175, "ITF25K", new DateTime(2024, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "USA", "Indian Wells ITF25K", new DateTime(2024, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 176, "ITF25K", new DateTime(2024, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sweden", "Stockholm ITF25K", new DateTime(2024, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 177, "ITF10K", new DateTime(2024, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Georgia", "Tbilisi ITF10K", new DateTime(2024, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 178, "ITF100K", new DateTime(2024, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Czech Republic", "Czech Open ITF100K", new DateTime(2024, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 179, "ITF50K", new DateTime(2024, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Japan", "Tokyo ITF50K", new DateTime(2024, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 180, "ITF25K", new DateTime(2024, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Austria", "Vienna ITF25K", new DateTime(2024, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 181, "ITF25K", new DateTime(2024, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "United Kingdom", "London ITF25K", new DateTime(2024, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grass" },
                    { 182, "ITF10K", new DateTime(2024, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Uzbekistan", "Tashkent ITF10K", new DateTime(2024, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 183, "ITF10K", new DateTime(2024, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "China", "Wuhan ITF10K", new DateTime(2024, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 184, "Challenger", new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "USA", "US Open 125k", new DateTime(2024, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 185, "ITF100K", new DateTime(2024, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mexico", "Guadalajara Open ITF100K", new DateTime(2024, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 186, "ITF100K", new DateTime(2024, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Switzerland", "Montreux ITF100K", new DateTime(2024, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 187, "ITF25K", new DateTime(2024, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dominican Republic", "Punta Cana ITF25K", new DateTime(2024, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 188, "ITF10K", new DateTime(2024, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brazil", "Piracicaba ITF10K", new DateTime(2024, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 189, "Masters500", new DateTime(2024, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mexico", "Guadalajara Open Masters500", new DateTime(2024, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 190, "Masters250", new DateTime(2024, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tunisia", "Monastir Masters250", new DateTime(2024, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 191, "ITF100K", new DateTime(2024, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Romania", "Tiriac Open ITF100K", new DateTime(2024, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 192, "ITF100K", new DateTime(2024, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Slovenia", "Zavarovalnica Open ITF100K", new DateTime(2024, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 193, "ITF25K", new DateTime(2024, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dominican Republic", "Punta Cana2 ITF25K", new DateTime(2024, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 194, "ITF25K", new DateTime(2024, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "China", "Guiyang ITF25K", new DateTime(2024, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 195, "Masters500", new DateTime(2024, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "South Korea", "Korea Open Masters500", new DateTime(2024, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 196, "Masters250", new DateTime(2024, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thailand", "Hua Hin2 Masters250", new DateTime(2024, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 197, "ITF50K", new DateTime(2024, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bulgaria", "Pazardzhik ITF50K", new DateTime(2024, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 198, "ITF50K", new DateTime(2024, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "China", "Fuzhou ITF50K", new DateTime(2024, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 199, "ITF10K", new DateTime(2024, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Japan", "Kyoto ITF10K", new DateTime(2024, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 200, "Masters1000", new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "China", "China Open Masters1000", new DateTime(2024, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 201, "ITF100K", new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Japan", "Nanao ITF100K", new DateTime(2024, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Indoor Hard" },
                    { 202, "ITF50K", new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "USA", "Berkley ITF50K", new DateTime(2024, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 203, "ITF25K", new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "South Korea", "Yeongwol1 ITF25K", new DateTime(2024, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 204, "ITF10K", new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bulgaria", "Varna ITF10K", new DateTime(2024, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 205, "Challenger", new DateTime(2024, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "China", "China Open 125k", new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 206, "ITF100K", new DateTime(2024, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "China", "Hong Kong ITF100K", new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 207, "ITF100K", new DateTime(2024, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "USA", "Rancho Santa ITF100K", new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Indoor Hard" },
                    { 208, "ITF50K", new DateTime(2024, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "USA", "Redding ITF50K", new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 209, "ITF25K", new DateTime(2024, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "South Korea", "Yeongwol2 ITF25K", new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 210, "ITF10K", new DateTime(2024, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Egypt", "Sharm ElSheikh1 ITF10K", new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 211, "Masters1000", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "China", "Wuhan Masters1000", new DateTime(2024, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 212, "ITF100K", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spain", "Cornella de Llobregat ITF100K", new DateTime(2024, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 213, "ITF50K", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Slovakia", "Bratislava ITF50K", new DateTime(2024, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Indoor Hard" },
                    { 214, "ITF25K", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Canada", "Edmonton ITF25K", new DateTime(2024, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Indoor Hard" },
                    { 215, "ITF10K", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Egypt", "Sharm ElSheikh2 ITF10K", new DateTime(2024, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 216, "Masters500", new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "China", "Ningbo Open Masters500", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 217, "Masters250", new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Japan", "Japan Open Masters250", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 218, "ITF100K", new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Great Britain", "Shrewsbury ITF100K", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Indoor Hard" },
                    { 219, "ITF50K", new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Turkey", "Kayseri1 ITF50K", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Indoor Hard" },
                    { 220, "ITF25K", new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "China", "Huzhou ITF25K", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 221, "ITF10K", new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Egypt", "Sharm ElSheikh3 ITF10K", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 222, "Masters500", new DateTime(2024, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Japan", "Pan Pacific Open Masters500", new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 223, "Masters250", new DateTime(2024, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "China", "Guangzhou Open Masters250", new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 224, "ITF100K", new DateTime(2024, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mexico", "Abierto Tampico ITF100K", new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 225, "ITF100K", new DateTime(2024, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Great Britain", "Glasgow ITF100K", new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Indoor Hard" },
                    { 226, "ITF50K", new DateTime(2024, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Turkey", "Kayseri2 ITF50K", new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Indoor Hard" },
                    { 227, "ITF25K", new DateTime(2024, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "China", "Qian Daohu ITF25K", new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 228, "ITF10K", new DateTime(2024, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Egypt", "Sharm ElSheikh4 ITF10K", new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 229, "Masters250", new DateTime(2024, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "China", "Jiangxi Open Masters250", new DateTime(2024, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 230, "Masters250", new DateTime(2024, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mexico", "Merida Open Masters250", new DateTime(2024, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 231, "Masters250", new DateTime(2024, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "China", "Hong Kong Open Masters250", new DateTime(2024, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard" },
                    { 232, "ITF100K", new DateTime(2024, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bolivia", "Bolivia Open ITF100K", new DateTime(2024, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay" },
                    { 233, "ITF50K", new DateTime(2024, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "France", "Nantes ITF50K", new DateTime(2024, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Indoor Hard" },
                    { 234, "ITF10K", new DateTime(2024, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Japan", "Makinohara ITF10K", new DateTime(2024, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carpet" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 234);
        }
    }
}
