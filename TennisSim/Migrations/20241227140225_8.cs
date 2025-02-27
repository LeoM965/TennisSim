using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TennisSim.Migrations
{
    /// <inheritdoc />
    public partial class _8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Active", "Name", "NationalityId", "Ranking", "YearOfBirth" },
                values: new object[,]
                {
                    { 1, true, "Iga Swiatek", 138, 1, 2001 },
                    { 2, true, "Aryna Sabalenka", 16, 2, 1998 },
                    { 3, true, "Cori Gauff", 185, 3, 2004 },
                    { 4, true, "Elena Rybakina", 86, 4, 1999 },
                    { 5, true, "Jessica Pegula", 185, 5, 1994 },
                    { 6, true, "Ons Jabeur", 177, 6, 1994 },
                    { 7, true, "Marketa Vondrousova", 45, 7, 1999 },
                    { 8, true, "Karolina Muchova", 45, 8, 1996 },
                    { 9, true, "Maria Sakkari", 66, 9, 1995 },
                    { 10, true, "Barbora Krejcikova", 45, 10, 1995 },
                    { 11, true, "Beatriz Haddad Maia", 24, 11, 1996 },
                    { 12, true, "Madison Keys", 185, 12, 1995 },
                    { 13, true, "Jelena Ostapenko", 94, 13, 1997 },
                    { 14, true, "Petra Kvitova", 45, 14, 1990 },
                    { 15, true, "Qinwen Zheng", 36, 15, 2002 },
                    { 16, true, "Liudmila Samsonova", 142, 16, 1998 },
                    { 17, true, "Belinda Bencic", 167, 17, 1997 },
                    { 18, true, "Daria Kasatkina", 142, 18, 1997 },
                    { 19, true, "Veronika Kudermetova", 142, 19, 1997 },
                    { 20, true, "Caroline Garcia", 60, 20, 1993 },
                    { 21, true, "Ekaterina Alexandrova", 142, 21, 1994 },
                    { 22, true, "Victoria Azarenka", 16, 22, 1989 },
                    { 23, true, "Donna Vekic", 42, 23, 1996 },
                    { 24, true, "Magda Linette", 138, 24, 1992 },
                    { 25, true, "Elina Svitolina", 182, 25, 1994 },
                    { 26, true, "Sorana Cirstea", 141, 26, 1990 },
                    { 27, true, "Anastasia Potapova", 142, 27, 2001 },
                    { 28, true, "Anhelina Kalinina", 182, 28, 1997 },
                    { 29, true, "Elise Mertens", 17, 29, 1995 },
                    { 30, true, "Jasmine Paolini", 82, 30, 1996 },
                    { 31, true, "Lesya Tsurenko", 182, 31, 1989 },
                    { 32, true, "Emma Navarro", 185, 32, 2001 },
                    { 33, true, "Sofia Kenin", 185, 33, 1998 },
                    { 34, true, "Marie Bouzkova", 45, 34, 1998 },
                    { 35, true, "Leylah Annie Fernandez", 32, 35, 2002 },
                    { 36, true, "Xinyu Wang", 36, 36, 2001 },
                    { 37, true, "Lin Zhu", 36, 37, 1994 },
                    { 38, true, "Karolina Pliskova", 45, 38, 1992 },
                    { 39, true, "Marta Kostyuk", 182, 39, 2002 },
                    { 40, true, "Petra Martic", 42, 40, 1991 },
                    { 41, true, "Linda Noskova", 45, 41, 2004 },
                    { 42, true, "Martina Trevisan", 82, 42, 1993 },
                    { 43, true, "Varvara Gracheva", 60, 43, 2000 },
                    { 44, true, "Caroline Dolehide", 185, 44, 1998 },
                    { 45, true, "Katerina Siniakova", 45, 45, 1996 },
                    { 46, true, "Elisabetta Cocciaretto", 82, 46, 2001 },
                    { 47, true, "Sloane Stephens", 185, 47, 1993 },
                    { 48, true, "Sara Sorribes Tormo", 162, 48, 1996 },
                    { 49, true, "Peyton Stearns", 185, 49, 2001 },
                    { 50, true, "Anna Blinkova", 142, 50, 1998 },
                    { 51, true, "Arantxa Rus", 123, 51, 1990 },
                    { 52, true, "Danielle Collins", 185, 52, 1993 },
                    { 53, true, "Camila Giorgi", 82, 53, 1991 },
                    { 54, true, "Tatjana Maria", 64, 54, 1987 },
                    { 55, true, "Clara Burel", 60, 55, 2001 },
                    { 56, true, "Katie Boulter", 184, 56, 1996 },
                    { 57, true, "Mirra Andreeva", 142, 57, 2007 },
                    { 58, true, "Anastasia Pavlyuchenkova", 142, 58, 1991 },
                    { 59, true, "Mayar Sherif", 51, 59, 1996 },
                    { 60, true, "Greetje Minnen", 17, 60, 1997 },
                    { 61, true, "Cristina Bucsa", 162, 61, 1998 },
                    { 62, true, "Lucia Bronzetti", 82, 62, 1998 },
                    { 63, true, "Rebeka Masarova", 167, 63, 1999 },
                    { 64, true, "Paula Badosa", 162, 64, 1997 },
                    { 65, true, "Bernarda Pera", 185, 65, 1994 },
                    { 66, true, "Yulia Putintseva", 86, 66, 1995 },
                    { 67, true, "Nadia Podoroska", 7, 67, 1997 },
                    { 68, true, "Lauren Davis", 185, 68, 1993 },
                    { 69, true, "Ana Bogdan", 141, 69, 1992 },
                    { 70, true, "Xiyu Wang", 36, 70, 2001 },
                    { 71, true, "Yanina Wickmayer", 17, 71, 1989 },
                    { 72, true, "Anna Schmiedlova", 156, 72, 1994 },
                    { 73, true, "Elina Avanesyan", 8, 73, 2002 },
                    { 74, true, "Magdalena Frech", 138, 74, 1997 },
                    { 75, true, "Irina-Camelia Begu", 141, 75, 1990 },
                    { 76, true, "Anna Kalinskaya", 142, 76, 1998 },
                    { 77, true, "Yue Yuan", 36, 77, 1998 },
                    { 78, true, "Maria Camila Osorio Serrano", 37, 78, 2001 },
                    { 79, true, "Diane Parry", 60, 79, 2002 },
                    { 80, true, "Viktoriya Tomova", 26, 80, 1995 },
                    { 81, true, "Taylor Townsend", 185, 81, 1996 },
                    { 82, true, "Ashlyn Krueger", 185, 82, 2004 },
                    { 83, true, "Viktorija Golubic", 167, 83, 1992 },
                    { 84, true, "Tamara Korpatsch", 64, 84, 1995 },
                    { 85, true, "Alycia Parks", 185, 85, 2001 },
                    { 86, true, "Laura Siegemund", 64, 86, 1988 },
                    { 87, true, "Kayla Day", 185, 87, 1999 },
                    { 88, true, "Zhuoxuan Bai", 36, 88, 2002 },
                    { 89, true, "Jaqueline Cristian", 141, 89, 1998 },
                    { 90, true, "Aliaksandra Sasnovich", 16, 90, 1994 },
                    { 91, true, "Emina Bektas", 185, 91, 1993 },
                    { 92, true, "Linda Fruhvirtova", 45, 92, 2005 },
                    { 93, true, "Diana Shnaider", 142, 93, 2004 },
                    { 94, true, "Nao Hibino", 84, 94, 1994 },
                    { 95, true, "Bianca Andreescu", 32, 95, 2000 },
                    { 96, true, "Oceane Dodin", 60, 96, 1996 },
                    { 97, true, "Jodie Burrage", 184, 97, 1999 },
                    { 98, true, "Claire Liu", 185, 98, 2000 },
                    { 99, true, "Kamilla Rakhimova", 142, 99, 2001 },
                    { 100, true, "Yafan Wang", 36, 100, 1994 },
                    { 101, true, "Julia Grabher", 10, 101, 1996 },
                    { 102, true, "Dayana Yastremska", 182, 102, 2000 },
                    { 103, true, "Tamara Zidansek", 157, 103, 1997 },
                    { 104, true, "Renata Zarazua", 111, 104, 1997 },
                    { 105, true, "Sara Errani", 82, 105, 1987 },
                    { 106, true, "Kaja Juvan", 157, 106, 2000 },
                    { 107, true, "Clara Tauson", 46, 107, 2002 },
                    { 108, true, "Katie Volynets", 185, 108, 2002 },
                    { 109, true, "Marina Bassols Ribera", 162, 109, 1999 },
                    { 110, true, "Laura Pigossi", 24, 110, 1994 },
                    { 111, true, "Brenda Fruhvirtova", 45, 111, 2007 },
                    { 112, true, "Erika Andreeva", 142, 112, 2004 },
                    { 113, true, "Elizabeth Mandlik", 185, 113, 2001 },
                    { 114, true, "Arina Rodionova", 9, 114, 1989 },
                    { 115, true, "Kimberly Birrell", 9, 115, 1998 },
                    { 116, true, "Emiliana Arango", 37, 116, 2000 },
                    { 117, true, "Alize Cornet", 60, 117, 1990 },
                    { 118, true, "Anna Bondar", 74, 118, 1997 },
                    { 119, true, "Olga Danilovic", 152, 119, 2001 },
                    { 120, true, "Mai Hontama", 84, 120, 1999 },
                    { 121, true, "Harriet Dart", 184, 121, 1996 },
                    { 122, true, "Maria Lourdes Carle", 7, 122, 2000 },
                    { 123, true, "Lucrezia Stefanini", 82, 123, 1998 },
                    { 124, true, "Astra Sharma", 9, 124, 1995 },
                    { 125, true, "Nuria Parrizas-Diaz", 162, 125, 1991 },
                    { 126, true, "Olivia Gadecki", 9, 126, 2002 },
                    { 127, true, "Rebecca Peterson", 166, 127, 1995 },
                    { 128, true, "Elena Gabriela Ruse", 141, 128, 1997 },
                    { 129, true, "Sara Bejlek", 45, 129, 2006 },
                    { 130, true, "Rebecca Sramkova", 156, 130, 1996 },
                    { 131, true, "Hailey Baptiste", 185, 131, 2001 },
                    { 132, true, "Kateryna Baindl", 182, 132, 1994 },
                    { 133, true, "Jessika Ponchet", 60, 133, 1996 },
                    { 134, true, "Daria Snigur", 182, 134, 2002 },
                    { 135, true, "Anna-Lena Friedsam", 64, 135, 1994 },
                    { 136, true, "Eva Lys", 64, 136, 2002 },
                    { 137, true, "Heather Watson", 184, 137, 1992 },
                    { 138, true, "Viktoria Hruncakova", 156, 138, 1998 },
                    { 139, true, "Julia Riera", 7, 139, 2002 },
                    { 140, true, "Darja Semenistaja", 94, 140, 2002 },
                    { 141, true, "Celine Naef", 167, 141, 2005 },
                    { 142, true, "Dalma Galfi", 74, 142, 1998 },
                    { 143, true, "Maria Timofeeva", 142, 143, 2003 },
                    { 144, true, "Valeria Savinykh", 142, 144, 1991 },
                    { 145, true, "Katherine Sebov", 32, 145, 1999 },
                    { 146, true, "Sachia Vickery", 185, 146, 1995 },
                    { 147, true, "Jil Teichmann", 167, 147, 1997 },
                    { 148, true, "Caty McNally", 185, 148, 2001 },
                    { 149, true, "Shelby Rogers", 185, 149, 1992 },
                    { 150, true, "Danka Kovinic", 116, 150, 1994 },
                    { 151, true, "Madison Brengle", 185, 151, 1990 },
                    { 152, true, "Arianne Hartono", 123, 152, 1996 },
                    { 153, true, "Martina Capurro Taborda", 7, 153, 1997 },
                    { 154, true, "Leolia Jeanjean", 60, 154, 1995 },
                    { 155, true, "Tereza Martincova", 45, 155, 1994 },
                    { 156, true, "Yuliia Starodubtseva", 182, 156, 2000 },
                    { 157, true, "Chloe Paquet", 60, 157, 1994 },
                    { 158, true, "Anastasia Tikhonova", 142, 158, 2001 },
                    { 159, true, "Jessica Bouzas Maneiro", 162, 159, 2002 },
                    { 160, true, "Panna Udvardy", 74, 160, 1998 },
                    { 161, true, "Fiona Ferro", 60, 161, 1997 },
                    { 162, true, "Su Jeong Jang", 90, 162, 1995 },
                    { 163, true, "Gabriela Andrea Knutson", 45, 163, 1997 },
                    { 164, true, "Zeynep Sonmez", 178, 164, 2002 },
                    { 165, true, "Jule Niemeier", 64, 165, 1999 },
                    { 166, true, "Mirjam Bjorklund", 166, 166, 1998 },
                    { 167, true, "Simona Waltert", 167, 167, 2000 },
                    { 168, true, "Kaia Kanepi", 55, 168, 1985 },
                    { 169, true, "Ann Li", 185, 169, 2000 },
                    { 170, true, "Aliona Bolsova", 162, 170, 1997 },
                    { 171, true, "Storm Hunter", 9, 171, 1994 },
                    { 172, true, "Katarina Zavatska", 182, 172, 2000 },
                    { 173, true, "Petra Marcinko", 42, 173, 2005 },
                    { 174, true, "Alina Korneeva", 142, 174, 2007 },
                    { 175, true, "Solana Sierra", 7, 175, 2004 },
                    { 176, true, "Rebecca Marino", 32, 176, 1990 },
                    { 177, true, "Noma Noha Akugue", 64, 177, 2003 },
                    { 178, true, "Raluca Georgiana Serban", 44, 178, 1997 },
                    { 179, true, "Ella Seidel", 64, 179, 2006 },
                    { 180, true, "Natalija Stevanovic", 152, 180, 1995 },
                    { 181, true, "Himeno Sakatsume", 84, 181, 2002 },
                    { 182, true, "Polina Kudermetova", 142, 182, 2004 },
                    { 183, true, "Irina Maria Bara", 141, 183, 1996 },
                    { 184, true, "Jana Fett", 42, 184, 1997 },
                    { 185, true, "Ekaterina Makarova", 142, 185, 1996 },
                    { 186, true, "Yuriko Miyazaki", 184, 186, 1996 },
                    { 187, true, "Elsa Jacquemot", 60, 187, 2004 },
                    { 188, true, "Timea Babos", 74, 188, 1994 },
                    { 189, true, "Ysaline Bonaventure", 17, 189, 1995 },
                    { 190, true, "Alexandra Eala", 137, 190, 2006 },
                    { 191, true, "Robin Montgomery", 185, 191, 2005 },
                    { 192, true, "Anastasia Zakharova", 142, 192, 2003 },
                    { 193, true, "Veronika Erjavec", 157, 193, 2000 },
                    { 194, true, "Miriam Bianca Bulgaru", 141, 194, 1999 },
                    { 195, true, "Carole Monnet", 60, 195, 2002 },
                    { 196, true, "Sinja Kraus", 10, 196, 2003 },
                    { 197, true, "Katarzyna Kawa", 138, 197, 1993 },
                    { 198, true, "Elvina Kalieva", 185, 198, 2004 },
                    { 199, true, "Moyuka Uchijima", 105, 199, 2001 },
                    { 200, true, "Iryna Shymanovich", 16, 200, 1997 },
                    { 201, true, "Sofya Lansere", 142, 201, 2000 },
                    { 202, true, "Darya Astakhova", 142, 202, 2002 },
                    { 203, true, "Taylah Preston", 9, 203, 2005 },
                    { 204, true, "Daria Saville", 9, 204, 1994 },
                    { 205, true, "Priscilla Hon", 9, 205, 1998 },
                    { 206, true, "Nuria Brancaccio", 82, 206, 2000 },
                    { 207, true, "Yuliya Hatouka", 16, 207, 2000 },
                    { 208, true, "Francisca Jorge", 139, 208, 2000 },
                    { 209, true, "Destanee Aiava", 9, 209, 2000 },
                    { 210, true, "Ya-Yi Yang", 169, 210, 2004 },
                    { 211, true, "Suzan Lamens", 123, 211, 1999 },
                    { 212, true, "Jaimee Fourlis", 9, 212, 1999 },
                    { 213, true, "Lina Gjorcheska", 128, 213, 1994 },
                    { 214, true, "Lulu Sun", 124, 214, 2001 },
                    { 215, true, "Ankita Raina", 76, 215, 1993 },
                    { 216, true, "Andreea Mitu", 141, 216, 1991 },
                    { 217, true, "Nigina Abduraimova", 187, 217, 1994 },
                    { 218, true, "Yexin Ma", 36, 218, 1999 },
                    { 219, true, "Carol Zhao", 32, 219, 1995 },
                    { 220, true, "Valentini Grammatikopoulou", 66, 220, 1997 },
                    { 221, true, "Mccartney Kessler", 185, 221, 1999 },
                    { 222, true, "Despina Papamichail", 66, 222, 1993 },
                    { 223, true, "Alice Robbe", 60, 223, 2000 },
                    { 224, true, "Dominika Salkova", 45, 224, 2004 },
                    { 225, true, "Jana Kolodynska", 16, 225, 2003 },
                    { 226, true, "Lea Boskovic", 42, 226, 1999 },
                    { 227, true, "Xiaodi You", 36, 227, 1996 },
                    { 228, true, "Tena Lukas", 42, 228, 1995 },
                    { 229, true, "Selena Janicijevic", 60, 229, 2002 },
                    { 230, true, "Harmony Tan", 60, 230, 1997 },
                    { 231, true, "Tatiana Prozorova", 142, 231, 2003 },
                    { 232, true, "Sijia Wei", 36, 232, 2003 },
                    { 233, true, "Jennifer Brady", 185, 233, 1995 },
                    { 234, true, "Lesley Pattinama Kerkhove", 123, 234, 1991 },
                    { 235, true, "Margaux Rouvroy", 60, 235, 2001 },
                    { 236, true, "Carlota Martinez Cirez", 162, 236, 2001 },
                    { 237, true, "Lanlana Tararudee", 172, 237, 2004 },
                    { 238, true, "Stacey Fung", 32, 238, 1997 },
                    { 239, true, "Kristina Mladenovic", 60, 239, 1993 },
                    { 240, true, "Dalila Jakupovic", 157, 240, 1991 },
                    { 241, true, "Antonia Ruzic", 42, 241, 2003 },
                    { 242, true, "Ipek Oz", 178, 242, 1999 },
                    { 243, true, "Seone Mendez", 9, 243, 1999 },
                    { 244, true, "Anca Alexia Todoni", 141, 244, 2004 },
                    { 245, true, "Shuai Zhang", 36, 245, 1989 },
                    { 246, true, "Justina Mikulskyte", 100, 246, 1996 },
                    { 247, true, "Mona Barthel", 64, 247, 1990 },
                    { 248, true, "Sonay Kartal", 184, 248, 2001 },
                    { 249, true, "Caroline Wozniacki", 46, 249, 1990 },
                    { 250, true, "Gergana Topalova", 26, 250, 2000 },
                    { 251, true, "Maryna Zanevska", 17, 251, 1993 },
                    { 252, true, "Sofia Costoulas", 17, 252, 2005 },
                    { 253, true, "Joanna Garland", 169, 253, 2001 },
                    { 254, true, "Makenna Jones", 185, 254, 1998 },
                    { 255, true, "Valeriya Strakhova", 182, 255, 1995 },
                    { 256, true, "Dejana Radanovic", 152, 256, 1996 },
                    { 257, true, "Hanna Chang", 185, 257, 1998 },
                    { 258, true, "Julia Avdeeva", 142, 258, 2002 },
                    { 259, true, "Lucie Havlickova", 45, 259, 2005 },
                    { 260, true, "Mananchaya Sawangkaew", 172, 260, 2002 },
                    { 261, true, "Ylena In-Albon", 167, 261, 1999 },
                    { 262, true, "Fanny Stollar", 74, 262, 1998 },
                    { 263, true, "Aliona Falei", 16, 263, 2004 },
                    { 264, true, "Berfu Cengiz", 178, 264, 1999 },
                    { 265, true, "Marie Benoit", 17, 265, 1995 },
                    { 266, true, "Louisa Chirico", 185, 266, 1996 },
                    { 267, true, "Polona Hercog", 157, 267, 1991 },
                    { 268, true, "Xinyu Gao", 36, 268, 1997 },
                    { 269, true, "Irene Burillo Escorihuela", 162, 269, 1997 },
                    { 270, true, "Talia Gibson", 9, 270, 2004 },
                    { 271, true, "Haruka Kaji", 84, 271, 1994 },
                    { 272, true, "Vera Zvonareva", 142, 272, 1984 },
                    { 273, true, "Marina Stakusic", 32, 273, 2004 },
                    { 274, true, "Isabella Shinikova", 26, 274, 1991 },
                    { 275, true, "Lucija Ciric Bagaric", 42, 275, 2004 },
                    { 276, true, "Kateryna Volodko", 182, 276, 1986 },
                    { 277, true, "En Shuo Liang", 169, 277, 2000 },
                    { 278, true, "Lola Radivojevic", 152, 278, 2005 },
                    { 279, true, "Silvia Ambrosio", 64, 279, 1997 },
                    { 280, true, "Katie Swan", 184, 280, 1999 },
                    { 281, true, "Cristina Dinu", 141, 281, 1993 },
                    { 282, true, "Eudice Wong Chong", 155, 282, 1996 },
                    { 283, true, "Sapfo Sakellaridi", 66, 283, 2003 },
                    { 284, true, "Grace Min", 185, 284, 1994 },
                    { 285, true, "Maddison Inglis", 9, 285, 1998 },
                    { 286, true, "Alexandra Cadantu", 141, 286, 1990 },
                    { 287, true, "Eugenie Bouchard", 32, 287, 1994 },
                    { 288, true, "Sakura Hosogi", 84, 288, 2000 },
                    { 289, true, "Maria Mateas", 185, 289, 1999 },
                    { 290, true, "Ajla Tomljanovic", 9, 290, 1993 },
                    { 291, true, "Varvara Lepchenko", 185, 291, 1986 },
                    { 292, true, "Kathinka Von Deichmann", 99, 292, 1994 },
                    { 293, true, "Jamie Loeb", 185, 293, 1995 },
                    { 294, true, "Nikola Bartunkova", 45, 294, 2006 },
                    { 295, true, "Julie Struplova", 45, 295, 2004 },
                    { 296, true, "Francesca Jones", 184, 296, 2000 },
                    { 297, true, "Rosa Vicens Mas", 162, 297, 2000 },
                    { 298, true, "Emma Raducanu", 184, 298, 2002 },
                    { 299, true, "Guiomar Zuleta De Reales", 162, 299, 1999 },
                    { 300, true, "Valentina Ryser", 167, 300, 2002 },
                    { 301, true, "Ana Sofia Sanchez", 111, 301, 1995 },
                    { 302, true, "Georgia Pedone", 82, 302, 2005 },
                    { 303, true, "Hanne Vandewinkel", 17, 303, 2005 },
                    { 304, true, "Carolina Meligeni Alves", 24, 304, 1997 },
                    { 305, true, "Leyre Romero Gormaz", 162, 305, 2003 },
                    { 306, true, "Amarni Banks", 184, 306, 2003 },
                    { 307, true, "Victoria Jimenez Kasintseva", 4, 307, 2006 },
                    { 308, true, "Anastasia Kulikova", 59, 308, 2001 },
                    { 309, true, "Sohyun Park", 90, 309, 2003 },
                    { 310, true, "Maria Bondarenko", 142, 310, 2004 },
                    { 311, true, "Sabine Lisicki", 64, 311, 1990 },
                    { 312, true, "Lois Boisson", 60, 312, 2004 },
                    { 313, true, "Amandine Hesse", 60, 313, 1994 },
                    { 314, true, "Veronica Miroshnichenko", 142, 314, 1998 },
                    { 315, true, "Francesca Curmi", 107, 315, 2003 },
                    { 316, true, "Ayano Shimizu", 84, 316, 1999 },
                    { 317, true, "Lizette Cabrera", 9, 317, 1998 },
                    { 318, true, "Martha Matoula", 66, 318, 1998 },
                    { 319, true, "Liv Hovde", 185, 319, 2006 },
                    { 320, true, "Katarina Kozarov", 152, 320, 1999 },
                    { 321, true, "Na-Lae Han", 90, 321, 1993 },
                    { 322, true, "Audrey Albie", 60, 322, 1995 },
                    { 323, true, "Camilla Rosatello", 82, 323, 1996 },
                    { 324, true, "Linda Klimovicova", 45, 324, 2005 },
                    { 325, true, "Andreea Prisacariu", 141, 325, 2001 },
                    { 326, true, "Kristina Dmitruk", 16, 326, 2004 },
                    { 327, true, "Polina Iatcenko", 142, 327, 2004 },
                    { 328, true, "Alina Charaeva", 142, 328, 2003 },
                    { 329, true, "Karman Kaur Thandi", 76, 329, 1999 },
                    { 330, true, "Sada Nahimana", 28, 330, 2002 },
                    { 331, true, "Ekaterine Gorgodze", 63, 331, 1992 },
                    { 332, true, "Raveena Kingsley", 185, 332, 1999 },
                    { 333, true, "Victoria Mboko", 32, 333, 2007 },
                    { 334, true, "Anastasiia Sobolieva", 182, 334, 2005 },
                    { 335, true, "Mia Ristic", 152, 335, 2007 },
                    { 336, true, "Kyoka Okamura", 84, 336, 1996 },
                    { 337, true, "Susan Bandecchi", 167, 337, 1999 },
                    { 338, true, "Rutuja Bhosale", 76, 338, 1997 },
                    { 339, true, "Victoria Hu", 185, 339, 2003 },
                    { 340, true, "Dalila Spiteri", 82, 340, 1998 },
                    { 341, true, "Lisa Pigato", 82, 341, 2004 },
                    { 342, true, "Elena Pridankina", 142, 342, 2006 },
                    { 343, true, "Reka-Luca Jani", 74, 343, 1992 },
                    { 344, true, "Alison Van Uytvanck", 17, 344, 1995 },
                    { 345, true, "Madison Sieg", 185, 345, 2004 },
                    { 346, true, "Diana Marcinkevica", 94, 346, 1993 },
                    { 347, true, "Barbora Palicova", 45, 347, 2005 },
                    { 348, true, "Fernanda Contreras Gomez", 111, 348, 1998 },
                    { 349, true, "Magali Kempen", 17, 349, 1998 },
                    { 350, true, "Conny Perrin", 167, 350, 1991 },
                    { 351, true, "Daria Lodikova", 142, 351, 1997 },
                    { 352, true, "Elena Malygina", 55, 352, 2001 },
                    { 353, true, "Anna Siskova", 45, 353, 2002 },
                    { 354, true, "Jia-Jing Lu", 36, 354, 1990 },
                    { 355, true, "Lina Glushko", 81, 355, 2001 },
                    { 356, true, "Allie Kiick", 185, 356, 1996 },
                    { 357, true, "Eva Vedder", 123, 357, 2000 },
                    { 358, true, "Sara Saito", 84, 358, 2007 },
                    { 359, true, "Maja Chwalinska", 138, 359, 2002 },
                    { 360, true, "Katharina Hobgarski", 64, 360, 1998 },
                    { 361, true, "Ayla Aksu", 178, 361, 1997 },
                    { 362, true, "Ilinca Dalina Amariei", 141, 362, 2003 },
                    { 363, true, "Martyna Kubka", 138, 363, 2002 },
                    { 364, true, "Nefisa Berberovic", 22, 364, 2000 },
                    { 365, true, "Asia Muhammad", 185, 365, 1992 },
                    { 366, true, "Ksenia Zaytseva", 142, 366, 2005 },
                    { 367, true, "Katy Dunne", 184, 367, 1996 },
                    { 368, true, "Eden Silva", 184, 368, 1997 },
                    { 369, true, "Amanda Anisimova", 185, 369, 2002 },
                    { 370, true, "Sophie Chang", 185, 370, 1998 },
                    { 371, true, "Georgina Garcia-Perez", 162, 371, 1993 },
                    { 372, true, "Anna Brogan", 184, 372, 1998 },
                    { 373, true, "Victoria Rodriguez", 111, 373, 1996 },
                    { 374, true, "Natsumi Kawaguchi", 84, 374, 2003 },
                    { 375, true, "Daniela Vismane", 94, 375, 2001 },
                    { 376, true, "Ylona-Georgiana Ghioroaie", 141, 376, 1999 },
                    { 377, true, "Vivian Wolff", 64, 377, 1999 },
                    { 378, true, "Martina Colmegna", 82, 378, 1997 },
                    { 379, true, "Julia Middendorf", 64, 379, 2004 },
                    { 380, true, "Manon Leonard", 60, 380, 2002 },
                    { 381, true, "Rina Saigo", 84, 381, 2001 },
                    { 382, true, "Cagla Buyukakcay", 178, 382, 1990 },
                    { 383, true, "Aoi Ito", 84, 383, 2005 },
                    { 384, true, "Gabriela Ce", 24, 384, 1994 },
                    { 385, true, "Guillermina Naya", 7, 385, 1997 },
                    { 386, true, "Lucia Cortez Llorca", 162, 386, 2001 },
                    { 387, true, "Zongyu Li", 36, 387, 2004 },
                    { 388, true, "Tamira Paszek", 10, 388, 1991 },
                    { 389, true, "Chloe Beck", 185, 389, 2002 },
                    { 390, true, "Jessie Aney", 185, 390, 1999 },
                    { 391, true, "Oleksandra Oliynykova", 42, 391, 2002 },
                    { 392, true, "Eva Guerrero Alvarez", 162, 392, 2000 },
                    { 393, true, "Gabriela Lee", 141, 393, 1996 },
                    { 394, true, "Robin Anderson", 185, 394, 1994 },
                    { 395, true, "Marcela Zacarias", 111, 395, 1995 },
                    { 396, true, "Weronika Falkowska", 138, 396, 2001 },
                    { 397, true, "Ashley Lahey", 185, 397, 2000 },
                    { 398, true, "Whitney Osuigwe", 185, 398, 2003 },
                    { 399, true, "Emma Lene", 60, 399, 2000 },
                    { 400, true, "Nika Radisic", 157, 400, 2001 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 400);
        }
    }
}
