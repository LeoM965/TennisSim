using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TennisSim.Migrations
{
    /// <inheritdoc />
    public partial class _9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Rankings",
                columns: new[] { "Id", "Date", "PlayerId", "Points", "Rank" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 9295, 1 },
                    { 2, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 9050, 2 },
                    { 3, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 6580, 3 },
                    { 4, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 6365, 4 },
                    { 5, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 5975, 5 },
                    { 6, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 4195, 6 },
                    { 7, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 4046, 7 },
                    { 8, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 3650, 8 },
                    { 9, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 3620, 9 },
                    { 10, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 2880, 10 },
                    { 11, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 2855, 11 },
                    { 12, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 2816, 12 },
                    { 13, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 2720, 13 },
                    { 14, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 2660, 14 },
                    { 15, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 2660, 15 },
                    { 16, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 2650, 16 },
                    { 17, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 2571, 17 },
                    { 18, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 2550, 18 },
                    { 19, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 2520, 19 },
                    { 20, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 2095, 20 },
                    { 21, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 2035, 21 },
                    { 22, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 1905, 22 },
                    { 23, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, 1865, 23 },
                    { 24, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 1861, 24 },
                    { 25, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 1809, 25 },
                    { 26, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 1765, 26 },
                    { 27, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, 1588, 27 },
                    { 28, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 1570, 28 },
                    { 29, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, 1495, 29 },
                    { 30, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, 1435, 30 },
                    { 31, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, 1432, 31 },
                    { 32, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, 1355, 32 },
                    { 33, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 1332, 33 },
                    { 34, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, 1325, 34 },
                    { 35, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 1325, 35 },
                    { 36, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 1320, 36 },
                    { 37, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, 1292, 37 },
                    { 38, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, 1285, 38 },
                    { 39, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, 1260, 39 },
                    { 40, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, 1253, 40 },
                    { 41, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, 1247, 41 },
                    { 42, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 42, 1187, 42 },
                    { 43, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 43, 1186, 43 },
                    { 44, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 44, 1163, 44 },
                    { 45, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, 1160, 45 },
                    { 46, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 46, 1140, 46 },
                    { 47, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 47, 1135, 47 },
                    { 48, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, 1126, 48 },
                    { 49, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 49, 1119, 49 },
                    { 50, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, 1110, 50 },
                    { 51, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 51, 1094, 51 },
                    { 52, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 52, 1088, 52 },
                    { 53, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 53, 1087, 53 },
                    { 54, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 54, 1080, 54 },
                    { 55, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 55, 1079, 55 },
                    { 56, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 56, 1073, 56 },
                    { 57, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 57, 1060, 57 },
                    { 58, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 58, 1044, 58 },
                    { 59, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 59, 1005, 59 },
                    { 60, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, 984, 60 },
                    { 61, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 61, 983, 61 },
                    { 62, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 62, 968, 62 },
                    { 63, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 63, 962, 63 },
                    { 64, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 64, 947, 64 },
                    { 65, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 65, 941, 65 },
                    { 66, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 66, 937, 66 },
                    { 67, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 67, 936, 67 },
                    { 68, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 68, 933, 68 },
                    { 69, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 69, 928, 69 },
                    { 70, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 70, 926, 70 },
                    { 71, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 71, 917, 71 },
                    { 72, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 72, 916, 72 },
                    { 73, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 73, 915, 73 },
                    { 74, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 74, 897, 74 },
                    { 75, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 75, 888, 75 },
                    { 76, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 76, 885, 76 },
                    { 77, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 77, 882, 77 },
                    { 78, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 78, 874, 78 },
                    { 79, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 79, 874, 79 },
                    { 80, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 80, 873, 80 },
                    { 81, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 81, 868, 81 },
                    { 82, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 82, 863, 82 },
                    { 83, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 834, 83 },
                    { 84, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 84, 833, 84 },
                    { 85, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 818, 85 },
                    { 86, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 86, 814, 86 },
                    { 87, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 87, 807, 87 },
                    { 88, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 88, 807, 88 },
                    { 89, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 89, 805, 89 },
                    { 90, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 90, 803, 90 },
                    { 91, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 91, 802, 91 },
                    { 92, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 92, 800, 92 },
                    { 93, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 93, 783, 93 },
                    { 94, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 94, 774, 94 },
                    { 95, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 95, 764, 95 },
                    { 96, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 96, 763, 96 },
                    { 97, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 97, 762, 97 },
                    { 98, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 98, 759, 98 },
                    { 99, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 99, 758, 99 },
                    { 100, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, 755, 100 },
                    { 101, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 101, 744, 101 },
                    { 102, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 102, 734, 102 },
                    { 103, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 103, 725, 103 },
                    { 104, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 104, 720, 104 },
                    { 105, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 105, 713, 105 },
                    { 106, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 106, 705, 106 },
                    { 107, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 107, 699, 107 },
                    { 108, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 108, 673, 108 },
                    { 109, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 109, 664, 109 },
                    { 110, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 110, 662, 110 },
                    { 111, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 111, 657, 111 },
                    { 112, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 112, 656, 112 },
                    { 113, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 113, 648, 113 },
                    { 114, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 114, 647, 114 },
                    { 115, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 115, 641, 115 },
                    { 116, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 116, 635, 116 },
                    { 117, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 117, 631, 117 },
                    { 118, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 118, 630, 118 },
                    { 119, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 119, 626, 119 },
                    { 120, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 120, 626, 120 },
                    { 121, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 121, 602, 121 },
                    { 122, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, 595, 122 },
                    { 123, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 123, 591, 123 },
                    { 124, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 124, 590, 124 },
                    { 125, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 125, 585, 125 },
                    { 126, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 126, 585, 126 },
                    { 127, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 127, 582, 127 },
                    { 128, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 128, 573, 128 },
                    { 129, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 129, 573, 129 },
                    { 130, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 130, 571, 130 },
                    { 131, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 131, 567, 131 },
                    { 132, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 132, 566, 132 },
                    { 133, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 133, 560, 133 },
                    { 134, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 134, 559, 134 },
                    { 135, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 135, 557, 135 },
                    { 136, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 136, 555, 136 },
                    { 137, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 137, 551, 137 },
                    { 138, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 138, 549, 138 },
                    { 139, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 139, 546, 139 },
                    { 140, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 140, 535, 140 },
                    { 141, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 141, 533, 141 },
                    { 142, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 142, 532, 142 },
                    { 143, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 143, 531, 143 },
                    { 144, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 144, 523, 144 },
                    { 145, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 145, 520, 145 },
                    { 146, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 146, 517, 146 },
                    { 147, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 147, 517, 147 },
                    { 148, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 148, 517, 148 },
                    { 149, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 149, 514, 149 },
                    { 150, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 150, 501, 150 },
                    { 151, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 151, 497, 151 },
                    { 152, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 152, 496, 152 },
                    { 153, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 153, 495, 153 },
                    { 154, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 154, 493, 154 },
                    { 155, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 155, 491, 155 },
                    { 156, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 156, 490, 156 },
                    { 157, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 157, 488, 157 },
                    { 158, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 158, 482, 158 },
                    { 159, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 159, 480, 159 },
                    { 160, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 160, 475, 160 },
                    { 161, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 161, 474, 161 },
                    { 162, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 162, 468, 162 },
                    { 163, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 163, 465, 163 },
                    { 164, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 164, 462, 164 },
                    { 165, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 165, 458, 165 },
                    { 166, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 166, 458, 166 },
                    { 167, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 167, 455, 167 },
                    { 168, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 168, 449, 168 },
                    { 169, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 169, 444, 169 },
                    { 170, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 170, 441, 170 },
                    { 171, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 171, 440, 171 },
                    { 172, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 172, 438, 172 },
                    { 173, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 173, 427, 173 },
                    { 174, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 174, 427, 174 },
                    { 175, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 175, 424, 175 },
                    { 176, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 176, 422, 176 },
                    { 177, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 177, 419, 177 },
                    { 178, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 178, 417, 178 },
                    { 179, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 179, 417, 179 },
                    { 180, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 180, 414, 180 },
                    { 181, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 181, 412, 181 },
                    { 182, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 182, 410, 182 },
                    { 183, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 183, 410, 183 },
                    { 184, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 184, 409, 184 },
                    { 185, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 185, 407, 185 },
                    { 186, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 186, 402, 186 },
                    { 187, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 187, 402, 187 },
                    { 188, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 188, 402, 188 },
                    { 189, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 189, 401, 189 },
                    { 190, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 190, 399, 190 },
                    { 191, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 191, 396, 191 },
                    { 192, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 192, 395, 192 },
                    { 193, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 193, 392, 193 },
                    { 194, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 194, 390, 194 },
                    { 195, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 195, 386, 195 },
                    { 196, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 196, 385, 196 },
                    { 197, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 197, 385, 197 },
                    { 198, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 198, 380, 198 },
                    { 199, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 199, 376, 199 },
                    { 200, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 200, 369, 200 },
                    { 201, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 201, 368, 201 },
                    { 202, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 202, 367, 202 },
                    { 203, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 203, 367, 203 },
                    { 204, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 204, 366, 204 },
                    { 205, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 205, 366, 205 },
                    { 206, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 206, 363, 206 },
                    { 207, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 207, 361, 207 },
                    { 208, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 208, 361, 208 },
                    { 209, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 209, 359, 209 },
                    { 210, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 210, 359, 210 },
                    { 211, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 211, 358, 211 },
                    { 212, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 212, 357, 212 },
                    { 213, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 213, 357, 213 },
                    { 214, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 214, 356, 214 },
                    { 215, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 215, 353, 215 },
                    { 216, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 216, 352, 216 },
                    { 217, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 217, 351, 217 },
                    { 218, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 218, 351, 218 },
                    { 219, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 219, 347, 219 },
                    { 220, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 220, 346, 220 },
                    { 221, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 221, 345, 221 },
                    { 222, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 222, 344, 222 },
                    { 223, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 223, 342, 223 },
                    { 224, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 224, 340, 224 },
                    { 225, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 225, 339, 225 },
                    { 226, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 226, 339, 226 },
                    { 227, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 227, 337, 227 },
                    { 228, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 228, 337, 228 },
                    { 229, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 229, 336, 229 },
                    { 230, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 230, 330, 230 },
                    { 231, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 231, 327, 231 },
                    { 232, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 232, 327, 232 },
                    { 233, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 233, 324, 233 },
                    { 234, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 234, 322, 234 },
                    { 235, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 235, 322, 235 },
                    { 236, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 236, 321, 236 },
                    { 237, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 237, 321, 237 },
                    { 238, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 238, 319, 238 },
                    { 239, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 239, 316, 239 },
                    { 240, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 240, 315, 240 },
                    { 241, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 241, 314, 241 },
                    { 242, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 242, 312, 242 },
                    { 243, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 243, 309, 243 },
                    { 244, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 244, 309, 244 },
                    { 245, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 245, 308, 245 },
                    { 246, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 246, 305, 246 },
                    { 247, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 247, 304, 247 },
                    { 248, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 248, 303, 248 },
                    { 249, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 249, 301, 249 },
                    { 250, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 250, 301, 250 },
                    { 251, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 251, 300, 251 },
                    { 252, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 252, 297, 252 },
                    { 253, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 253, 296, 253 },
                    { 254, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 254, 295, 254 },
                    { 255, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 255, 295, 255 },
                    { 256, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 256, 295, 256 },
                    { 257, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 257, 295, 257 },
                    { 258, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 258, 292, 258 },
                    { 259, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 259, 288, 259 },
                    { 260, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 260, 287, 260 },
                    { 261, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 261, 286, 261 },
                    { 262, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 262, 286, 262 },
                    { 263, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 263, 286, 263 },
                    { 264, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 264, 285, 264 },
                    { 265, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 265, 284, 265 },
                    { 266, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 266, 281, 266 },
                    { 267, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 267, 277, 267 },
                    { 268, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 268, 277, 268 },
                    { 269, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 269, 276, 269 },
                    { 270, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 270, 276, 270 },
                    { 271, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 271, 275, 271 },
                    { 272, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 272, 273, 272 },
                    { 273, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 273, 270, 273 },
                    { 274, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 274, 270, 274 },
                    { 275, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 275, 269, 275 },
                    { 276, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 276, 268, 276 },
                    { 277, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 277, 265, 277 },
                    { 278, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 278, 264, 278 },
                    { 279, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 279, 262, 279 },
                    { 280, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 280, 261, 280 },
                    { 281, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 281, 258, 281 },
                    { 282, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 282, 255, 282 },
                    { 283, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 283, 255, 283 },
                    { 284, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 284, 254, 284 },
                    { 285, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 285, 252, 285 },
                    { 286, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 286, 250, 286 },
                    { 287, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 287, 249, 287 },
                    { 288, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 288, 248, 288 },
                    { 289, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 289, 247, 289 },
                    { 290, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 290, 246, 290 },
                    { 291, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 291, 245, 291 },
                    { 292, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 292, 241, 292 },
                    { 293, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 293, 239, 293 },
                    { 294, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 294, 239, 294 },
                    { 295, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 295, 236, 295 },
                    { 296, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 296, 235, 296 },
                    { 297, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 297, 232, 297 },
                    { 298, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 298, 231, 298 },
                    { 299, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 299, 230, 299 },
                    { 300, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 300, 230, 300 },
                    { 301, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 301, 229, 301 },
                    { 302, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 302, 226, 302 },
                    { 303, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 303, 226, 303 },
                    { 304, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 304, 224, 304 },
                    { 305, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 305, 224, 305 },
                    { 306, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 306, 223, 306 },
                    { 307, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 307, 222, 307 },
                    { 308, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 308, 222, 308 },
                    { 309, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 309, 219, 309 },
                    { 310, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 310, 218, 310 },
                    { 311, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 311, 217, 311 },
                    { 312, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 312, 214, 312 },
                    { 313, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 313, 213, 313 },
                    { 314, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 314, 210, 314 },
                    { 315, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 315, 210, 315 },
                    { 316, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 316, 210, 316 },
                    { 317, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 317, 209, 317 },
                    { 318, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 318, 209, 318 },
                    { 319, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 319, 208, 319 },
                    { 320, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 320, 208, 320 },
                    { 321, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 321, 207, 321 },
                    { 322, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 322, 207, 322 },
                    { 323, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 323, 206, 323 },
                    { 324, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 324, 206, 324 },
                    { 325, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 325, 205, 325 },
                    { 326, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 326, 204, 326 },
                    { 327, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 327, 204, 327 },
                    { 328, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 328, 202, 328 },
                    { 329, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 329, 201, 329 },
                    { 330, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 330, 201, 330 },
                    { 331, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 331, 200, 331 },
                    { 332, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 332, 199, 332 },
                    { 333, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 333, 199, 333 },
                    { 334, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 334, 198, 334 },
                    { 335, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 335, 198, 335 },
                    { 336, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 336, 195, 336 },
                    { 337, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 337, 194, 337 },
                    { 338, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 338, 194, 338 },
                    { 339, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 339, 191, 339 },
                    { 340, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 340, 190, 340 },
                    { 341, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 341, 188, 341 },
                    { 342, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 342, 188, 342 },
                    { 343, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 343, 187, 343 },
                    { 344, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 344, 186, 344 },
                    { 345, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 345, 184, 345 },
                    { 346, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 346, 184, 346 },
                    { 347, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 347, 182, 347 },
                    { 348, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 348, 182, 348 },
                    { 349, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 349, 182, 349 },
                    { 350, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 350, 182, 350 },
                    { 351, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 351, 180, 351 },
                    { 352, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 352, 180, 352 },
                    { 353, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 353, 179, 353 },
                    { 354, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 354, 179, 354 },
                    { 355, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 355, 178, 355 },
                    { 356, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 356, 178, 356 },
                    { 357, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 357, 177, 357 },
                    { 358, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 358, 177, 358 },
                    { 359, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 359, 176, 359 },
                    { 360, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 360, 176, 360 },
                    { 361, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 361, 176, 361 },
                    { 362, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 362, 175, 362 },
                    { 363, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 363, 173, 363 },
                    { 364, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 364, 173, 364 },
                    { 365, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 365, 171, 365 },
                    { 366, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 366, 171, 366 },
                    { 367, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 367, 171, 367 },
                    { 368, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 368, 170, 368 },
                    { 369, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 369, 169, 369 },
                    { 370, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 370, 169, 370 },
                    { 371, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 371, 169, 371 },
                    { 372, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 372, 167, 372 },
                    { 373, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 373, 167, 373 },
                    { 374, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 374, 167, 374 },
                    { 375, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 375, 167, 375 },
                    { 376, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 376, 165, 376 },
                    { 377, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 377, 165, 377 },
                    { 378, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 378, 164, 378 },
                    { 379, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 379, 163, 379 },
                    { 380, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 380, 163, 380 },
                    { 381, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 381, 161, 381 },
                    { 382, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 382, 160, 382 },
                    { 383, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 383, 160, 383 },
                    { 384, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 384, 159, 384 },
                    { 385, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 385, 158, 385 },
                    { 386, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 386, 158, 386 },
                    { 387, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 387, 157, 387 },
                    { 388, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 388, 156, 388 },
                    { 389, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 389, 156, 389 },
                    { 390, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 390, 155, 390 },
                    { 391, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 391, 154, 391 },
                    { 392, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 392, 154, 392 },
                    { 393, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 393, 153, 393 },
                    { 394, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 394, 152, 394 },
                    { 395, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 395, 151, 395 },
                    { 396, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 396, 151, 396 },
                    { 397, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 397, 150, 397 },
                    { 398, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 398, 149, 398 },
                    { 399, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 399, 149, 399 },
                    { 400, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 400, 148, 400 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Rankings",
                keyColumn: "Id",
                keyValue: 400);
        }
    }
}
