using Microsoft.EntityFrameworkCore;
using System;
using TennisSim.Models;

namespace TennisSim.Data
{
    public static class PlayerSeedData
    {
        public static void SeedPlayers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>().HasData(
                new Player { Id = 1, Name = "Iga Swiatek", YearOfBirth = 2001, NationalityId = 138, Ranking = 1, Active = true }, // Poland
                new Player { Id = 2, Name = "Aryna Sabalenka", YearOfBirth = 1998, NationalityId = 16, Ranking = 2, Active = true }, // Belarus
                new Player { Id = 3, Name = "Cori Gauff", YearOfBirth = 2004, NationalityId = 185, Ranking = 3, Active = true }, // USA
                new Player { Id = 4, Name = "Elena Rybakina", YearOfBirth = 1999, NationalityId = 86, Ranking = 4, Active = true }, // Kazakhstan
                new Player { Id = 5, Name = "Jessica Pegula", YearOfBirth = 1994, NationalityId = 185, Ranking = 5, Active = true }, // USA
                new Player { Id = 6, Name = "Ons Jabeur", YearOfBirth = 1994, NationalityId = 177, Ranking = 6, Active = true }, // Tunisia
                new Player { Id = 7, Name = "Marketa Vondrousova", YearOfBirth = 1999, NationalityId = 45, Ranking = 7, Active = true }, // Czech Republic
                new Player { Id = 8, Name = "Karolina Muchova", YearOfBirth = 1996, NationalityId = 45, Ranking = 8, Active = true }, // Czech Republic
                new Player { Id = 9, Name = "Maria Sakkari", YearOfBirth = 1995, NationalityId = 66, Ranking = 9, Active = true }, // Greece
                new Player { Id = 10, Name = "Barbora Krejcikova", YearOfBirth = 1995, NationalityId = 45, Ranking = 10, Active = true }, // Czech Republic
                new Player { Id = 11, Name = "Beatriz Haddad Maia", YearOfBirth = 1996, NationalityId = 24, Ranking = 11, Active = true }, // Brazil
                new Player { Id = 12, Name = "Madison Keys", YearOfBirth = 1995, NationalityId = 185, Ranking = 12, Active = true }, // USA
                new Player { Id = 13, Name = "Jelena Ostapenko", YearOfBirth = 1997, NationalityId = 94, Ranking = 13, Active = true }, // Latvia
                new Player { Id = 14, Name = "Petra Kvitova", YearOfBirth = 1990, NationalityId = 45, Ranking = 14, Active = true }, // Czech Republic
                new Player { Id = 15, Name = "Qinwen Zheng", YearOfBirth = 2002, NationalityId = 36, Ranking = 15, Active = true }, // China
                new Player { Id = 16, Name = "Liudmila Samsonova", YearOfBirth = 1998, NationalityId = 142, Ranking = 16, Active = true }, // Russia
                new Player { Id = 17, Name = "Belinda Bencic", YearOfBirth = 1997, NationalityId = 167, Ranking = 17, Active = true }, // Switzerland
                new Player { Id = 18, Name = "Daria Kasatkina", YearOfBirth = 1997, NationalityId = 142, Ranking = 18, Active = true }, // Russia
                new Player { Id = 19, Name = "Veronika Kudermetova", YearOfBirth = 1997, NationalityId = 142, Ranking = 19, Active = true }, // Russia
                new Player { Id = 20, Name = "Caroline Garcia", YearOfBirth = 1993, NationalityId = 60, Ranking = 20, Active = true }, // France
                new Player { Id = 21, Name = "Ekaterina Alexandrova", YearOfBirth = 1994, NationalityId = 142, Ranking = 21, Active = true }, // Russia
                new Player { Id = 22, Name = "Victoria Azarenka", YearOfBirth = 1989, NationalityId = 16, Ranking = 22, Active = true }, // Belarus
                new Player { Id = 23, Name = "Donna Vekic", YearOfBirth = 1996, NationalityId = 42, Ranking = 23, Active = true }, // Croatia
                new Player { Id = 24, Name = "Magda Linette", YearOfBirth = 1992, NationalityId = 138, Ranking = 24, Active = true }, // Poland
                new Player { Id = 25, Name = "Elina Svitolina", YearOfBirth = 1994, NationalityId = 182, Ranking = 25, Active = true }, // Ukraine
                new Player { Id = 26, Name = "Sorana Cirstea", YearOfBirth = 1990, NationalityId = 141, Ranking = 26, Active = true }, // Romania
                new Player { Id = 27, Name = "Anastasia Potapova", YearOfBirth = 2001, NationalityId = 142, Ranking = 27, Active = true }, // Russia
                new Player { Id = 28, Name = "Anhelina Kalinina", YearOfBirth = 1997, NationalityId = 182, Ranking = 28, Active = true }, // Ukraine
                new Player { Id = 29, Name = "Elise Mertens", YearOfBirth = 1995, NationalityId = 17, Ranking = 29, Active = true }, // Belgium
                new Player { Id = 30, Name = "Jasmine Paolini", YearOfBirth = 1996, NationalityId = 82, Ranking = 30, Active = true }, // Italy
                new Player { Id = 31, Name = "Lesya Tsurenko", YearOfBirth = 1989, NationalityId = 182, Ranking = 31, Active = true }, // Ukraine
                new Player { Id = 32, Name = "Emma Navarro", YearOfBirth = 2001, NationalityId = 185, Ranking = 32, Active = true }, // USA
                new Player { Id = 33, Name = "Sofia Kenin", YearOfBirth = 1998, NationalityId = 185, Ranking = 33, Active = true }, // USA
                new Player { Id = 34, Name = "Marie Bouzkova", YearOfBirth = 1998, NationalityId = 45, Ranking = 34, Active = true }, // Czech Republic
                new Player { Id = 35, Name = "Leylah Annie Fernandez", YearOfBirth = 2002, NationalityId = 32, Ranking = 35, Active = true }, // Canada
                new Player { Id = 36, Name = "Xinyu Wang", YearOfBirth = 2001, NationalityId = 36, Ranking = 36, Active = true }, // China
                new Player { Id = 37, Name = "Lin Zhu", YearOfBirth = 1994, NationalityId = 36, Ranking = 37, Active = true }, // China
                new Player { Id = 38, Name = "Karolina Pliskova", YearOfBirth = 1992, NationalityId = 45, Ranking = 38, Active = true }, // Czech Republic
                new Player { Id = 39, Name = "Marta Kostyuk", YearOfBirth = 2002, NationalityId = 182, Ranking = 39, Active = true }, // Ukraine
                new Player { Id = 40, Name = "Petra Martic", YearOfBirth = 1991, NationalityId = 42, Ranking = 40, Active = true }, // Croatia
                new Player { Id = 41, Name = "Linda Noskova", YearOfBirth = 2004, NationalityId = 45, Ranking = 41, Active = true }, // Czech Republic
                new Player { Id = 42, Name = "Martina Trevisan", YearOfBirth = 1993, NationalityId = 82, Ranking = 42, Active = true }, // Italy
                new Player { Id = 43, Name = "Varvara Gracheva", YearOfBirth = 2000, NationalityId = 60, Ranking = 43, Active = true }, // France
                new Player { Id = 44, Name = "Caroline Dolehide", YearOfBirth = 1998, NationalityId = 185, Ranking = 44, Active = true }, // USA
                new Player { Id = 45, Name = "Katerina Siniakova", YearOfBirth = 1996, NationalityId = 45, Ranking = 45, Active = true }, // Czech Republic
                new Player { Id = 46, Name = "Elisabetta Cocciaretto", YearOfBirth = 2001, NationalityId = 82, Ranking = 46, Active = true }, // Italy
                new Player { Id = 47, Name = "Sloane Stephens", YearOfBirth = 1993, NationalityId = 185, Ranking = 47, Active = true }, // USA
                new Player { Id = 48, Name = "Sara Sorribes Tormo", YearOfBirth = 1996, NationalityId = 162, Ranking = 48, Active = true }, // Spain
                new Player { Id = 49, Name = "Peyton Stearns", YearOfBirth = 2001, NationalityId = 185, Ranking = 49, Active = true }, // USA
                new Player { Id = 50, Name = "Anna Blinkova", YearOfBirth = 1998, NationalityId = 142, Ranking = 50, Active = true }, // Russia
                new Player { Id = 51, Name = "Arantxa Rus", YearOfBirth = 1990, NationalityId = 123, Ranking = 51, Active = true }, // Netherlands
                new Player { Id = 52, Name = "Danielle Collins", YearOfBirth = 1993, NationalityId = 185, Ranking = 52, Active = true }, // USA
                new Player { Id = 53, Name = "Camila Giorgi", YearOfBirth = 1991, NationalityId = 82, Ranking = 53, Active = true }, // Italy
                new Player { Id = 54, Name = "Tatjana Maria", YearOfBirth = 1987, NationalityId = 64, Ranking = 54, Active = true }, // Germany
                new Player { Id = 55, Name = "Clara Burel", YearOfBirth = 2001, NationalityId = 60, Ranking = 55, Active = true }, // France
                new Player { Id = 56, Name = "Katie Boulter", YearOfBirth = 1996, NationalityId = 184, Ranking = 56, Active = true }, // Great Britain
                new Player { Id = 57, Name = "Mirra Andreeva", YearOfBirth = 2007, NationalityId = 142, Ranking = 57, Active = true }, // Russia
                new Player { Id = 58, Name = "Anastasia Pavlyuchenkova", YearOfBirth = 1991, NationalityId = 142, Ranking = 58, Active = true }, // Russia
                new Player { Id = 59, Name = "Mayar Sherif", YearOfBirth = 1996, NationalityId = 51, Ranking = 59, Active = true }, // Egypt
                new Player { Id = 60, Name = "Greetje Minnen", YearOfBirth = 1997, NationalityId = 17, Ranking = 60, Active = true }, // Belgium
                new Player { Id = 61, Name = "Cristina Bucsa", YearOfBirth = 1998, NationalityId = 162, Ranking = 61, Active = true }, // Spain
                new Player { Id = 62, Name = "Lucia Bronzetti", YearOfBirth = 1998, NationalityId = 82, Ranking = 62, Active = true }, // Italy
                new Player { Id = 63, Name = "Rebeka Masarova", YearOfBirth = 1999, NationalityId = 167, Ranking = 63, Active = true }, // Switzerland
                new Player { Id = 64, Name = "Paula Badosa", YearOfBirth = 1997, NationalityId = 162, Ranking = 64, Active = true }, // Spain
                new Player { Id = 65, Name = "Bernarda Pera", YearOfBirth = 1994, NationalityId = 185, Ranking = 65, Active = true }, // USA
                new Player { Id = 66, Name = "Yulia Putintseva", YearOfBirth = 1995, NationalityId = 86, Ranking = 66, Active = true }, // Kazakhstan
                new Player { Id = 67, Name = "Nadia Podoroska", YearOfBirth = 1997, NationalityId = 7, Ranking = 67, Active = true }, // Argentina
                new Player { Id = 68, Name = "Lauren Davis", YearOfBirth = 1993, NationalityId = 185, Ranking = 68, Active = true }, // USA
                new Player { Id = 69, Name = "Ana Bogdan", YearOfBirth = 1992, NationalityId = 141, Ranking = 69, Active = true }, // Romania
                new Player { Id = 70, Name = "Xiyu Wang", YearOfBirth = 2001, NationalityId = 36, Ranking = 70, Active = true }, // China
                new Player { Id = 71, Name = "Yanina Wickmayer", YearOfBirth = 1989, NationalityId = 17, Ranking = 71, Active = true }, // Belgium
                new Player { Id = 72, Name = "Anna Schmiedlova", YearOfBirth = 1994, NationalityId = 156, Ranking = 72, Active = true }, // Slovakia
                new Player { Id = 73, Name = "Elina Avanesyan", YearOfBirth = 2002, NationalityId = 8, Ranking = 73, Active = true }, // Armenia
                new Player { Id = 74, Name = "Magdalena Frech", YearOfBirth = 1997, NationalityId = 138, Ranking = 74, Active = true }, // Poland
                new Player { Id = 75, Name = "Irina-Camelia Begu", YearOfBirth = 1990, NationalityId = 141, Ranking = 75, Active = true }, // Romania
                new Player { Id = 76, Name = "Anna Kalinskaya", YearOfBirth = 1998, NationalityId = 142, Ranking = 76, Active = true }, // Russia
                new Player { Id = 77, Name = "Yue Yuan", YearOfBirth = 1998, NationalityId = 36, Ranking = 77, Active = true }, // China
                new Player { Id = 78, Name = "Maria Camila Osorio Serrano", YearOfBirth = 2001, NationalityId = 37, Ranking = 78, Active = true }, // Colombia
                new Player { Id = 79, Name = "Diane Parry", YearOfBirth = 2002, NationalityId = 60, Ranking = 79, Active = true }, // France
                new Player { Id = 80, Name = "Viktoriya Tomova", YearOfBirth = 1995, NationalityId = 26, Ranking = 80, Active = true }, // Bulgaria
                new Player { Id = 81, Name = "Taylor Townsend", YearOfBirth = 1996, NationalityId = 185, Ranking = 81, Active = true }, // USA
                new Player { Id = 82, Name = "Ashlyn Krueger", YearOfBirth = 2004, NationalityId = 185, Ranking = 82, Active = true }, // USA
                new Player { Id = 83, Name = "Viktorija Golubic", YearOfBirth = 1992, NationalityId = 167, Ranking = 83, Active = true }, // Switzerland
                new Player { Id = 84, Name = "Tamara Korpatsch", YearOfBirth = 1995, NationalityId = 64, Ranking = 84, Active = true }, // Germany
                new Player { Id = 85, Name = "Alycia Parks", YearOfBirth = 2001, NationalityId = 185, Ranking = 85, Active = true }, // USA
                new Player { Id = 86, Name = "Laura Siegemund", YearOfBirth = 1988, NationalityId = 64, Ranking = 86, Active = true }, // Germany
                new Player { Id = 87, Name = "Kayla Day", YearOfBirth = 1999, NationalityId = 185, Ranking = 87, Active = true }, // USA
                new Player { Id = 88, Name = "Zhuoxuan Bai", YearOfBirth = 2002, NationalityId = 36, Ranking = 88, Active = true }, // China
                new Player { Id = 89, Name = "Jaqueline Cristian", YearOfBirth = 1998, NationalityId = 141, Ranking = 89, Active = true }, // Romania
                new Player { Id = 90, Name = "Aliaksandra Sasnovich", YearOfBirth = 1994, NationalityId = 16, Ranking = 90, Active = true }, // Belarus
                new Player { Id = 91, Name = "Emina Bektas", YearOfBirth = 1993, NationalityId = 185, Ranking = 91, Active = true }, // USA
                new Player { Id = 92, Name = "Linda Fruhvirtova", YearOfBirth = 2005, NationalityId = 45, Ranking = 92, Active = true }, // Czech Republic
                new Player { Id = 93, Name = "Diana Shnaider", YearOfBirth = 2004, NationalityId = 142, Ranking = 93, Active = true }, // Russia
                new Player { Id = 94, Name = "Nao Hibino", YearOfBirth = 1994, NationalityId = 84, Ranking = 94, Active = true }, // Japan
                new Player { Id = 95, Name = "Bianca Andreescu", YearOfBirth = 2000, NationalityId = 32, Ranking = 95, Active = true }, // Canada
                new Player { Id = 96, Name = "Oceane Dodin", YearOfBirth = 1996, NationalityId = 60, Ranking = 96, Active = true }, // France
                new Player { Id = 97, Name = "Jodie Burrage", YearOfBirth = 1999, NationalityId = 184, Ranking = 97, Active = true }, // Great Britain
                new Player { Id = 98, Name = "Claire Liu", YearOfBirth = 2000, NationalityId = 185, Ranking = 98, Active = true }, // USA
                new Player { Id = 99, Name = "Kamilla Rakhimova", YearOfBirth = 2001, NationalityId = 142, Ranking = 99, Active = true }, // Russia
                new Player { Id = 100, Name = "Yafan Wang", YearOfBirth = 1994, NationalityId = 36, Ranking = 100, Active = true }, // China
                new Player { Id = 101, Name = "Julia Grabher", YearOfBirth = 1996, NationalityId = 10, Ranking = 101, Active = true }, // Austria
                new Player { Id = 102, Name = "Dayana Yastremska", YearOfBirth = 2000, NationalityId = 182, Ranking = 102, Active = true }, // Ukraine
                new Player { Id = 103, Name = "Tamara Zidansek", YearOfBirth = 1997, NationalityId = 157, Ranking = 103, Active = true }, // Slovenia
                new Player { Id = 104, Name = "Renata Zarazua", YearOfBirth = 1997, NationalityId = 111, Ranking = 104, Active = true }, // Mexico
                new Player { Id = 105, Name = "Sara Errani", YearOfBirth = 1987, NationalityId = 82, Ranking = 105, Active = true }, // Italy
                new Player { Id = 106, Name = "Kaja Juvan", YearOfBirth = 2000, NationalityId = 157, Ranking = 106, Active = true }, // Slovenia
                new Player { Id = 107, Name = "Clara Tauson", YearOfBirth = 2002, NationalityId = 46, Ranking = 107, Active = true }, // Denmark
                new Player { Id = 108, Name = "Katie Volynets", YearOfBirth = 2002, NationalityId = 185, Ranking = 108, Active = true }, // USA
                new Player { Id = 109, Name = "Marina Bassols Ribera", YearOfBirth = 1999, NationalityId = 162, Ranking = 109, Active = true }, // Spain
                new Player { Id = 110, Name = "Laura Pigossi", YearOfBirth = 1994, NationalityId = 24, Ranking = 110, Active = true }, // Brazil
                new Player { Id = 111, Name = "Brenda Fruhvirtova", YearOfBirth = 2007, NationalityId = 45, Ranking = 111, Active = true }, // Czech Republic
                new Player { Id = 112, Name = "Erika Andreeva", YearOfBirth = 2004, NationalityId = 142, Ranking = 112, Active = true }, // Russia
                new Player { Id = 113, Name = "Elizabeth Mandlik", YearOfBirth = 2001, NationalityId = 185, Ranking = 113, Active = true }, // USA
                new Player { Id = 114, Name = "Arina Rodionova", YearOfBirth = 1989, NationalityId = 9, Ranking = 114, Active = true }, // Australia
                new Player { Id = 115, Name = "Kimberly Birrell", YearOfBirth = 1998, NationalityId = 9, Ranking = 115, Active = true }, // Australia
                new Player { Id = 116, Name = "Emiliana Arango", YearOfBirth = 2000, NationalityId = 37, Ranking = 116, Active = true }, // Colombia
                new Player { Id = 117, Name = "Alize Cornet", YearOfBirth = 1990, NationalityId = 60, Ranking = 117, Active = true }, // France
                new Player { Id = 118, Name = "Anna Bondar", YearOfBirth = 1997, NationalityId = 74, Ranking = 118, Active = true }, // Hungary
                new Player { Id = 119, Name = "Olga Danilovic", YearOfBirth = 2001, NationalityId = 152, Ranking = 119, Active = true }, // Serbia
                new Player { Id = 120, Name = "Mai Hontama", YearOfBirth = 1999, NationalityId = 84, Ranking = 120, Active = true }, // Japan
                new Player { Id = 121, Name = "Harriet Dart", YearOfBirth = 1996, NationalityId = 184, Ranking = 121, Active = true }, // United Kingdom
                new Player { Id = 122, Name = "Maria Lourdes Carle", YearOfBirth = 2000, NationalityId = 7, Ranking = 122, Active = true }, // Argentina
                new Player { Id = 123, Name = "Lucrezia Stefanini", YearOfBirth = 1998, NationalityId = 82, Ranking = 123, Active = true }, // Italy
                new Player { Id = 124, Name = "Astra Sharma", YearOfBirth = 1995, NationalityId = 9, Ranking = 124, Active = true }, // Australia
                new Player { Id = 125, Name = "Nuria Parrizas-Diaz", YearOfBirth = 1991, NationalityId = 162, Ranking = 125, Active = true }, // Spain
                new Player { Id = 126, Name = "Olivia Gadecki", YearOfBirth = 2002, NationalityId = 9, Ranking = 126, Active = true }, // Australia
                new Player { Id = 127, Name = "Rebecca Peterson", YearOfBirth = 1995, NationalityId = 166, Ranking = 127, Active = true }, // Sweden
                new Player { Id = 128, Name = "Elena Gabriela Ruse", YearOfBirth = 1997, NationalityId = 141, Ranking = 128, Active = true }, // Romania
                new Player { Id = 129, Name = "Sara Bejlek", YearOfBirth = 2006, NationalityId = 45, Ranking = 129, Active = true }, // Czech Republic
                new Player { Id = 130, Name = "Rebecca Sramkova", YearOfBirth = 1996, NationalityId = 156, Ranking = 130, Active = true }, // Slovakia
                new Player { Id = 131, Name = "Hailey Baptiste", YearOfBirth = 2001, NationalityId = 185, Ranking = 131, Active = true }, // USA
                new Player { Id = 132, Name = "Kateryna Baindl", YearOfBirth = 1994, NationalityId = 182, Ranking = 132, Active = true }, // Ukraine
                new Player { Id = 133, Name = "Jessika Ponchet", YearOfBirth = 1996, NationalityId = 60, Ranking = 133, Active = true }, // France
                new Player { Id = 134, Name = "Daria Snigur", YearOfBirth = 2002, NationalityId = 182, Ranking = 134, Active = true }, // Ukraine
                new Player { Id = 135, Name = "Anna-Lena Friedsam", YearOfBirth = 1994, NationalityId = 64, Ranking = 135, Active = true }, // Germany
                new Player { Id = 136, Name = "Eva Lys", YearOfBirth = 2002, NationalityId = 64, Ranking = 136, Active = true }, // Germany
                new Player { Id = 137, Name = "Heather Watson", YearOfBirth = 1992, NationalityId = 184, Ranking = 137, Active = true }, // United Kingdom
                new Player { Id = 138, Name = "Viktoria Hruncakova", YearOfBirth = 1998, NationalityId = 156, Ranking = 138, Active = true }, // Slovakia
                new Player { Id = 139, Name = "Julia Riera", YearOfBirth = 2002, NationalityId = 7, Ranking = 139, Active = true }, // Argentina
                new Player { Id = 140, Name = "Darja Semenistaja", YearOfBirth = 2002, NationalityId = 94, Ranking = 140, Active = true }, // Latvia
                new Player { Id = 141, Name = "Celine Naef", YearOfBirth = 2005, NationalityId = 167, Ranking = 141, Active = true }, // Switzerland
                new Player { Id = 142, Name = "Dalma Galfi", YearOfBirth = 1998, NationalityId = 74, Ranking = 142, Active = true }, // Hungary
                new Player { Id = 143, Name = "Maria Timofeeva", YearOfBirth = 2003, NationalityId = 142, Ranking = 143, Active = true }, // Russia
                new Player { Id = 144, Name = "Valeria Savinykh", YearOfBirth = 1991, NationalityId = 142, Ranking = 144, Active = true }, // Russia
                new Player { Id = 145, Name = "Katherine Sebov", YearOfBirth = 1999, NationalityId = 32, Ranking = 145, Active = true }, // Canada
                new Player { Id = 146, Name = "Sachia Vickery", YearOfBirth = 1995, NationalityId = 185, Ranking = 146, Active = true }, // USA
                new Player { Id = 147, Name = "Jil Teichmann", YearOfBirth = 1997, NationalityId = 167, Ranking = 147, Active = true }, // Switzerland
                new Player { Id = 148, Name = "Caty McNally", YearOfBirth = 2001, NationalityId = 185, Ranking = 148, Active = true }, // USA
                new Player { Id = 149, Name = "Shelby Rogers", YearOfBirth = 1992, NationalityId = 185, Ranking = 149, Active = true }, // USA
                new Player { Id = 150, Name = "Danka Kovinic", YearOfBirth = 1994, NationalityId = 116, Ranking = 150, Active = true }, // Montenegro
                new Player { Id = 151, Name = "Madison Brengle", YearOfBirth = 1990, NationalityId = 185, Ranking = 151, Active = true }, // USA
                new Player { Id = 152, Name = "Arianne Hartono", YearOfBirth = 1996, NationalityId = 123, Ranking = 152, Active = true }, // Netherlands
                new Player { Id = 153, Name = "Martina Capurro Taborda", YearOfBirth = 1997, NationalityId = 7, Ranking = 153, Active = true }, // Argentina
                new Player { Id = 154, Name = "Leolia Jeanjean", YearOfBirth = 1995, NationalityId = 60, Ranking = 154, Active = true }, // France
                new Player { Id = 155, Name = "Tereza Martincova", YearOfBirth = 1994, NationalityId = 45, Ranking = 155, Active = true }, // Czech Republic
                new Player { Id = 156, Name = "Yuliia Starodubtseva", YearOfBirth = 2000, NationalityId = 182, Ranking = 156, Active = true }, // Ukraine
                new Player { Id = 157, Name = "Chloe Paquet", YearOfBirth = 1994, NationalityId = 60, Ranking = 157, Active = true }, // France
                new Player { Id = 158, Name = "Anastasia Tikhonova", YearOfBirth = 2001, NationalityId = 142, Ranking = 158, Active = true }, // Russia
                new Player { Id = 159, Name = "Jessica Bouzas Maneiro", YearOfBirth = 2002, NationalityId = 162, Ranking = 159, Active = true }, // Spain
                new Player { Id = 160, Name = "Panna Udvardy", YearOfBirth = 1998, NationalityId = 74, Ranking = 160, Active = true }, // Hungary
                new Player { Id = 161, Name = "Fiona Ferro", YearOfBirth = 1997, NationalityId = 60, Ranking = 161, Active = true }, // France
                new Player { Id = 162, Name = "Su Jeong Jang", YearOfBirth = 1995, NationalityId = 90, Ranking = 162, Active = true }, // Korea South
                new Player { Id = 163, Name = "Gabriela Andrea Knutson", YearOfBirth = 1997, NationalityId = 45, Ranking = 163, Active = true }, // Czech Republic
                new Player { Id = 164, Name = "Zeynep Sonmez", YearOfBirth = 2002, NationalityId = 178, Ranking = 164, Active = true }, // Turkey
                new Player { Id = 165, Name = "Jule Niemeier", YearOfBirth = 1999, NationalityId = 64, Ranking = 165, Active = true }, // Germany
                new Player { Id = 166, Name = "Mirjam Bjorklund", YearOfBirth = 1998, NationalityId = 166, Ranking = 166, Active = true }, // Sweden
                new Player { Id = 167, Name = "Simona Waltert", YearOfBirth = 2000, NationalityId = 167, Ranking = 167, Active = true }, // Switzerland
                new Player { Id = 168, Name = "Kaia Kanepi", YearOfBirth = 1985, NationalityId = 55, Ranking = 168, Active = false }, // Estonia
                new Player { Id = 169, Name = "Ann Li", YearOfBirth = 2000, NationalityId = 185, Ranking = 169, Active = true }, // USA
                new Player { Id = 170, Name = "Aliona Bolsova", YearOfBirth = 1997, NationalityId = 162, Ranking = 170, Active = true }, // Spain
                new Player { Id = 171, Name = "Storm Hunter", YearOfBirth = 1994, NationalityId = 9, Ranking = 171, Active = true }, // Australia
                new Player { Id = 172, Name = "Katarina Zavatska", YearOfBirth = 2000, NationalityId = 182, Ranking = 172, Active = true }, // Ukraine
                new Player { Id = 173, Name = "Petra Marcinko", YearOfBirth = 2005, NationalityId = 42, Ranking = 173, Active = true }, // Croatia
                new Player { Id = 174, Name = "Alina Korneeva", YearOfBirth = 2007, NationalityId = 142, Ranking = 174, Active = true }, // Russia
                new Player { Id = 175, Name = "Solana Sierra", YearOfBirth = 2004, NationalityId = 7, Ranking = 175, Active = true }, // Argentina
                new Player { Id = 176, Name = "Rebecca Marino", YearOfBirth = 1990, NationalityId = 32, Ranking = 176, Active = true }, // Canada
                new Player { Id = 177, Name = "Noma Noha Akugue", YearOfBirth = 2003, NationalityId = 64, Ranking = 177, Active = true }, // Germany
                new Player { Id = 178, Name = "Raluca Georgiana Serban", YearOfBirth = 1997, NationalityId = 44, Ranking = 178, Active = true }, // Cyprus
                new Player { Id = 179, Name = "Ella Seidel", YearOfBirth = 2006, NationalityId = 64, Ranking = 179, Active = true }, // Germany
                new Player { Id = 180, Name = "Natalija Stevanovic", YearOfBirth = 1995, NationalityId = 152, Ranking = 180, Active = true }, // Serbia
                new Player { Id = 181, Name = "Himeno Sakatsume", YearOfBirth = 2002, NationalityId = 84, Ranking = 181, Active = true }, // Japan
                new Player { Id = 182, Name = "Polina Kudermetova", YearOfBirth = 2004, NationalityId = 142, Ranking = 182, Active = true }, // Russia
                new Player { Id = 183, Name = "Irina Maria Bara", YearOfBirth = 1996, NationalityId = 141, Ranking = 183, Active = true }, // Romania
                new Player { Id = 184, Name = "Jana Fett", YearOfBirth = 1997, NationalityId = 42, Ranking = 184, Active = true }, // Croatia
                new Player { Id = 185, Name = "Ekaterina Makarova", YearOfBirth = 1996, NationalityId = 142, Ranking = 185, Active = true }, // Russia
                new Player { Id = 186, Name = "Yuriko Miyazaki", YearOfBirth = 1996, NationalityId = 184, Ranking = 186, Active = true }, // United Kingdom
                new Player { Id = 187, Name = "Elsa Jacquemot", YearOfBirth = 2004, NationalityId = 60, Ranking = 187, Active = true }, // France
                new Player { Id = 188, Name = "Timea Babos", YearOfBirth = 1994, NationalityId = 74, Ranking = 188, Active = true }, // Hungary
                new Player { Id = 189, Name = "Ysaline Bonaventure", YearOfBirth = 1995, NationalityId = 17, Ranking = 189, Active = true }, // Belgium
                new Player { Id = 190, Name = "Alexandra Eala", YearOfBirth = 2006, NationalityId = 137, Ranking = 190, Active = true }, // Philippines
                new Player { Id = 191, Name = "Robin Montgomery", YearOfBirth = 2005, NationalityId = 185, Ranking = 191, Active = true }, // United States
                new Player { Id = 192, Name = "Anastasia Zakharova", YearOfBirth = 2003, NationalityId = 142, Ranking = 192, Active = true }, // Russia
                new Player { Id = 193, Name = "Veronika Erjavec", YearOfBirth = 2000, NationalityId = 157, Ranking = 193, Active = true }, // Slovenia
                new Player { Id = 194, Name = "Miriam Bianca Bulgaru", YearOfBirth = 1999, NationalityId = 141, Ranking = 194, Active = true }, // Romania
                new Player { Id = 195, Name = "Carole Monnet", YearOfBirth = 2002, NationalityId = 60, Ranking = 195, Active = true }, // France
                new Player { Id = 196, Name = "Sinja Kraus", YearOfBirth = 2003, NationalityId = 10, Ranking = 196, Active = true }, // Austria
                new Player { Id = 197, Name = "Katarzyna Kawa", YearOfBirth = 1993, NationalityId = 138, Ranking = 197, Active = true }, // Poland
                new Player { Id = 198, Name = "Elvina Kalieva", YearOfBirth = 2004, NationalityId = 185, Ranking = 198, Active = true }, // United States
                new Player { Id = 199, Name = "Moyuka Uchijima", YearOfBirth = 2001, NationalityId = 84, Ranking = 199, Active = true }, // Japan
new Player { Id = 200, Name = "Iryna Shymanovich", YearOfBirth = 1997, NationalityId = 16, Ranking = 200, Active = true }, // Belarus
new Player { Id = 201, Name = "Sofya Lansere", YearOfBirth = 2000, NationalityId = 142, Ranking = 201, Active = true }, // Russia
new Player { Id = 202, Name = "Darya Astakhova", YearOfBirth = 2002, NationalityId = 142, Ranking = 202, Active = true }, // Russia
new Player { Id = 203, Name = "Taylah Preston", YearOfBirth = 2005, NationalityId = 9, Ranking = 203, Active = true }, // Australia
new Player { Id = 204, Name = "Daria Saville", YearOfBirth = 1994, NationalityId = 9, Ranking = 204, Active = true }, // Australia
new Player { Id = 205, Name = "Priscilla Hon", YearOfBirth = 1998, NationalityId = 9, Ranking = 205, Active = true }, // Australia
new Player { Id = 206, Name = "Nuria Brancaccio", YearOfBirth = 2000, NationalityId = 82, Ranking = 206, Active = true }, // Italy
new Player { Id = 207, Name = "Yuliya Hatouka", YearOfBirth = 2000, NationalityId = 16, Ranking = 207, Active = true }, // Belarus
new Player { Id = 208, Name = "Francisca Jorge", YearOfBirth = 2000, NationalityId = 139, Ranking = 208, Active = true }, // Portugal
new Player { Id = 209, Name = "Destanee Aiava", YearOfBirth = 2000, NationalityId = 9, Ranking = 209, Active = true }, // Australia
new Player { Id = 210, Name = "Ya-Yi Yang", YearOfBirth = 2004, NationalityId = 169, Ranking = 210, Active = true }, // Taiwan
new Player { Id = 211, Name = "Suzan Lamens", YearOfBirth = 1999, NationalityId = 123, Ranking = 211, Active = true }, // Netherlands
new Player { Id = 212, Name = "Jaimee Fourlis", YearOfBirth = 1999, NationalityId = 9, Ranking = 212, Active = true }, // Australia
new Player { Id = 213, Name = "Lina Gjorcheska", YearOfBirth = 1994, NationalityId = 128, Ranking = 213, Active = true }, // North Macedonia
new Player { Id = 214, Name = "Lulu Sun", YearOfBirth = 2001, NationalityId = 124, Ranking = 214, Active = true }, // New Zealand
new Player { Id = 215, Name = "Ankita Raina", YearOfBirth = 1993, NationalityId = 76, Ranking = 215, Active = true }, // India
new Player { Id = 216, Name = "Andreea Mitu", YearOfBirth = 1991, NationalityId = 141, Ranking = 216, Active = true }, // Romania
new Player { Id = 217, Name = "Nigina Abduraimova", YearOfBirth = 1994, NationalityId = 187, Ranking = 217, Active = true }, // Uzbekistan
new Player { Id = 218, Name = "Yexin Ma", YearOfBirth = 1999, NationalityId = 36, Ranking = 218, Active = true }, // China
new Player { Id = 219, Name = "Carol Zhao", YearOfBirth = 1995, NationalityId = 32, Ranking = 219, Active = true }, // Canada
new Player { Id = 220, Name = "Valentini Grammatikopoulou", YearOfBirth = 1997, NationalityId = 66, Ranking = 220, Active = true }, // Greece
new Player { Id = 221, Name = "Mccartney Kessler", YearOfBirth = 1999, NationalityId = 185, Ranking = 221, Active = true }, // USA
new Player { Id = 222, Name = "Despina Papamichail", YearOfBirth = 1993, NationalityId = 66, Ranking = 222, Active = true }, // Greece
new Player { Id = 223, Name = "Alice Robbe", YearOfBirth = 2000, NationalityId = 60, Ranking = 223, Active = true }, // France
new Player { Id = 224, Name = "Dominika Salkova", YearOfBirth = 2004, NationalityId = 45, Ranking = 224, Active = true }, // Czech Republic
new Player { Id = 225, Name = "Jana Kolodynska", YearOfBirth = 2003, NationalityId = 16, Ranking = 225, Active = true }, // Belarus
new Player { Id = 226, Name = "Lea Boskovic", YearOfBirth = 1999, NationalityId = 42, Ranking = 226, Active = true }, // Croatia
new Player { Id = 227, Name = "Xiaodi You", YearOfBirth = 1996, NationalityId = 36, Ranking = 227, Active = true }, // China
new Player { Id = 228, Name = "Tena Lukas", YearOfBirth = 1995, NationalityId = 42, Ranking = 228, Active = true }, // Croatia
new Player { Id = 229, Name = "Selena Janicijevic", YearOfBirth = 2002, NationalityId = 60, Ranking = 229, Active = true }, // France
new Player { Id = 230, Name = "Harmony Tan", YearOfBirth = 1997, NationalityId = 60, Ranking = 230, Active = true }, // France
new Player { Id = 231, Name = "Tatiana Prozorova", YearOfBirth = 2003, NationalityId = 142, Ranking = 231, Active = true }, // Russia
new Player { Id = 232, Name = "Sijia Wei", YearOfBirth = 2003, NationalityId = 36, Ranking = 232, Active = true }, // China
new Player { Id = 233, Name = "Jennifer Brady", YearOfBirth = 1995, NationalityId = 185, Ranking = 233, Active = true }, // USA
new Player { Id = 234, Name = "Lesley Pattinama Kerkhove", YearOfBirth = 1991, NationalityId = 123, Ranking = 234, Active = true }, // Netherlands
new Player { Id = 235, Name = "Margaux Rouvroy", YearOfBirth = 2001, NationalityId = 60, Ranking = 235, Active = true }, // France
new Player { Id = 236, Name = "Carlota Martinez Cirez", YearOfBirth = 2001, NationalityId = 162, Ranking = 236, Active = true }, // Spain
new Player { Id = 237, Name = "Lanlana Tararudee", YearOfBirth = 2004, NationalityId = 172, Ranking = 237, Active = true }, // Thailand
new Player { Id = 238, Name = "Stacey Fung", YearOfBirth = 1997, NationalityId = 32, Ranking = 238, Active = true }, // Canada
new Player { Id = 239, Name = "Kristina Mladenovic", YearOfBirth = 1993, NationalityId = 60, Ranking = 239, Active = true }, // France
new Player { Id = 240, Name = "Dalila Jakupovic", YearOfBirth = 1991, NationalityId = 157, Ranking = 240, Active = true }, // Slovenia
new Player { Id = 241, Name = "Antonia Ruzic", YearOfBirth = 2003, NationalityId = 42, Ranking = 241, Active = true }, // Croatia
new Player { Id = 242, Name = "Ipek Oz", YearOfBirth = 1999, NationalityId = 178, Ranking = 242, Active = true }, // Turkey
new Player { Id = 243, Name = "Seone Mendez", YearOfBirth = 1999, NationalityId = 9, Ranking = 243, Active = true }, // Australia
new Player { Id = 244, Name = "Anca Alexia Todoni", YearOfBirth = 2004, NationalityId = 141, Ranking = 244, Active = true }, // Romania
new Player { Id = 245, Name = "Shuai Zhang", YearOfBirth = 1989, NationalityId = 36, Ranking = 245, Active = true }, // China
new Player { Id = 246, Name = "Justina Mikulskyte", YearOfBirth = 1996, NationalityId = 100, Ranking = 246, Active = true }, // Lithuania
new Player { Id = 247, Name = "Mona Barthel", YearOfBirth = 1990, NationalityId = 64, Ranking = 247, Active = true }, // Germany
new Player { Id = 248, Name = "Sonay Kartal", YearOfBirth = 2001, NationalityId = 184, Ranking = 248, Active = true }, // United Kingdom
new Player { Id = 249, Name = "Caroline Wozniacki", YearOfBirth = 1990, NationalityId = 46, Ranking = 249, Active = true }, // Denmark
new Player { Id = 250, Name = "Gergana Topalova", YearOfBirth = 2000, NationalityId = 26, Ranking = 250, Active = true }, // Bulgaria
new Player { Id = 251, Name = "Maryna Zanevska", YearOfBirth = 1993, NationalityId = 17, Ranking = 251, Active = true }, // Belgium
new Player { Id = 252, Name = "Sofia Costoulas", YearOfBirth = 2005, NationalityId = 17, Ranking = 252, Active = true }, // Belgium
new Player { Id = 253, Name = "Joanna Garland", YearOfBirth = 2001, NationalityId = 169, Ranking = 253, Active = true }, // Taiwan
new Player { Id = 254, Name = "Makenna Jones", YearOfBirth = 1998, NationalityId = 185, Ranking = 254, Active = true }, // USA
new Player { Id = 255, Name = "Valeriya Strakhova", YearOfBirth = 1995, NationalityId = 182, Ranking = 255, Active = true }, // Ukraine
new Player { Id = 256, Name = "Dejana Radanovic", YearOfBirth = 1996, NationalityId = 152, Ranking = 256, Active = true }, // Serbia
new Player { Id = 257, Name = "Hanna Chang", YearOfBirth = 1998, NationalityId = 185, Ranking = 257, Active = true }, // USA
new Player { Id = 258, Name = "Julia Avdeeva", YearOfBirth = 2002, NationalityId = 142, Ranking = 258, Active = true }, // Russia
new Player { Id = 259, Name = "Lucie Havlickova", YearOfBirth = 2005, NationalityId = 45, Ranking = 259, Active = true }, // Czech Republic
new Player { Id = 260, Name = "Mananchaya Sawangkaew", YearOfBirth = 2002, NationalityId = 172, Ranking = 260, Active = true }, // Thailand
new Player { Id = 261, Name = "Ylena In-Albon", YearOfBirth = 1999, NationalityId = 167, Ranking = 261, Active = true }, // Switzerland
new Player { Id = 262, Name = "Fanny Stollar", YearOfBirth = 1998, NationalityId = 74, Ranking = 262, Active = true }, // Hungary
new Player { Id = 263, Name = "Aliona Falei", YearOfBirth = 2004, NationalityId = 16, Ranking = 263, Active = true }, // Belarus
new Player { Id = 264, Name = "Berfu Cengiz", YearOfBirth = 1999, NationalityId = 178, Ranking = 264, Active = true }, // Turkey
new Player { Id = 265, Name = "Marie Benoit", YearOfBirth = 1995, NationalityId = 17, Ranking = 265, Active = true }, // Belgium
new Player { Id = 266, Name = "Louisa Chirico", YearOfBirth = 1996, NationalityId = 185, Ranking = 266, Active = true }, // USA
new Player { Id = 267, Name = "Polona Hercog", YearOfBirth = 1991, NationalityId = 157, Ranking = 267, Active = true }, // Slovenia
new Player { Id = 268, Name = "Xinyu Gao", YearOfBirth = 1997, NationalityId = 36, Ranking = 268, Active = true }, // China
new Player { Id = 269, Name = "Irene Burillo Escorihuela", YearOfBirth = 1997, NationalityId = 162, Ranking = 269, Active = true }, // Spain
new Player { Id = 270, Name = "Talia Gibson", YearOfBirth = 2004, NationalityId = 9, Ranking = 270, Active = true }, // Australia
new Player { Id = 271, Name = "Haruka Kaji", YearOfBirth = 1994, NationalityId = 84, Ranking = 271, Active = true }, // Japan
new Player { Id = 272, Name = "Vera Zvonareva", YearOfBirth = 1984, NationalityId = 142, Ranking = 272, Active = true }, // Russia
new Player { Id = 273, Name = "Marina Stakusic", YearOfBirth = 2004, NationalityId = 32, Ranking = 273, Active = true }, // Canada
new Player { Id = 274, Name = "Isabella Shinikova", YearOfBirth = 1991, NationalityId = 26, Ranking = 274, Active = true }, // Bulgaria
new Player { Id = 275, Name = "Lucija Ciric Bagaric", YearOfBirth = 2004, NationalityId = 42, Ranking = 275, Active = true }, // Croatia
new Player { Id = 276, Name = "Kateryna Volodko", YearOfBirth = 1986, NationalityId = 182, Ranking = 276, Active = true }, // Ukraine
new Player { Id = 277, Name = "En Shuo Liang", YearOfBirth = 2000, NationalityId = 169, Ranking = 277, Active = true }, // Taiwan
new Player { Id = 278, Name = "Lola Radivojevic", YearOfBirth = 2005, NationalityId = 152, Ranking = 278, Active = true }, // Serbia
new Player { Id = 279, Name = "Silvia Ambrosio", YearOfBirth = 1997, NationalityId = 64, Ranking = 279, Active = true }, // Germany
new Player { Id = 280, Name = "Katie Swan", YearOfBirth = 1999, NationalityId = 184, Ranking = 280, Active = true }, // United Kingdom
new Player { Id = 281, Name = "Cristina Dinu", YearOfBirth = 1993, NationalityId = 141, Ranking = 281, Active = true }, // Romania
new Player { Id = 282, Name = "Eudice Wong Chong", YearOfBirth = 1996, NationalityId = 155, Ranking = 282, Active = true }, // Hong Kong (using Singapore's ID as placeholder)
new Player { Id = 283, Name = "Sapfo Sakellaridi", YearOfBirth = 2003, NationalityId = 66, Ranking = 283, Active = true }, // Greece
new Player { Id = 284, Name = "Grace Min", YearOfBirth = 1994, NationalityId = 185, Ranking = 284, Active = true }, // USA
new Player { Id = 285, Name = "Maddison Inglis", YearOfBirth = 1998, NationalityId = 9, Ranking = 285, Active = true }, // Australia
new Player { Id = 286, Name = "Alexandra Cadantu", YearOfBirth = 1990, NationalityId = 141, Ranking = 286, Active = true }, // Romania
new Player { Id = 287, Name = "Eugenie Bouchard", YearOfBirth = 1994, NationalityId = 32, Ranking = 287, Active = true }, // Canada
new Player { Id = 288, Name = "Sakura Hosogi", YearOfBirth = 2000, NationalityId = 84, Ranking = 288, Active = true }, // Japan
new Player { Id = 289, Name = "Maria Mateas", YearOfBirth = 1999, NationalityId = 185, Ranking = 289, Active = true }, // USA
new Player { Id = 290, Name = "Ajla Tomljanovic", YearOfBirth = 1993, NationalityId = 9, Ranking = 290, Active = true }, // Australia
new Player { Id = 291, Name = "Varvara Lepchenko", YearOfBirth = 1986, NationalityId = 185, Ranking = 291, Active = true }, // USA
new Player { Id = 292, Name = "Kathinka Von Deichmann", YearOfBirth = 1994, NationalityId = 99, Ranking = 292, Active = true }, // Liechtenstein
new Player { Id = 293, Name = "Jamie Loeb", YearOfBirth = 1995, NationalityId = 185, Ranking = 293, Active = true }, // USA
new Player { Id = 294, Name = "Nikola Bartunkova", YearOfBirth = 2006, NationalityId = 45, Ranking = 294, Active = true }, // Czech Republic
new Player { Id = 295, Name = "Julie Struplova", YearOfBirth = 2004, NationalityId = 45, Ranking = 295, Active = true }, // Czech Republic
new Player { Id = 296, Name = "Francesca Jones", YearOfBirth = 2000, NationalityId = 184, Ranking = 296, Active = true }, // United Kingdom
new Player { Id = 297, Name = "Rosa Vicens Mas", YearOfBirth = 2000, NationalityId = 162, Ranking = 297, Active = true }, // Spain
new Player { Id = 298, Name = "Emma Raducanu", YearOfBirth = 2002, NationalityId = 184, Ranking = 298, Active = true }, // United Kingdom
new Player { Id = 299, Name = "Guiomar Zuleta De Reales", YearOfBirth = 1999, NationalityId = 162, Ranking = 299, Active = true }, // Spain
new Player { Id = 300, Name = "Valentina Ryser", YearOfBirth = 2002, NationalityId = 167, Ranking = 300, Active = true }, // Switzerland
new Player { Id = 301, Name = "Ana Sofia Sanchez", YearOfBirth = 1995, NationalityId = 111, Ranking = 301, Active = true }, // Mexico
new Player { Id = 302, Name = "Georgia Pedone", YearOfBirth = 2005, NationalityId = 82, Ranking = 302, Active = true }, // Italy
new Player { Id = 303, Name = "Hanne Vandewinkel", YearOfBirth = 2005, NationalityId = 17, Ranking = 303, Active = true }, // Belgium
new Player { Id = 304, Name = "Carolina Meligeni Alves", YearOfBirth = 1997, NationalityId = 24, Ranking = 304, Active = true }, // Brazil
new Player { Id = 305, Name = "Leyre Romero Gormaz", YearOfBirth = 2003, NationalityId = 162, Ranking = 305, Active = true }, // Spain
new Player { Id = 306, Name = "Amarni Banks", YearOfBirth = 2003, NationalityId = 184, Ranking = 306, Active = true }, // United Kingdom
new Player { Id = 307, Name = "Victoria Jimenez Kasintseva", YearOfBirth = 2006, NationalityId = 4, Ranking = 307, Active = true }, // Andorra
new Player { Id = 308, Name = "Anastasia Kulikova", YearOfBirth = 2001, NationalityId = 59, Ranking = 308, Active = true }, // Finland
new Player { Id = 309, Name = "Sohyun Park", YearOfBirth = 2003, NationalityId = 90, Ranking = 309, Active = true }, // Korea South
new Player { Id = 310, Name = "Maria Bondarenko", YearOfBirth = 2004, NationalityId = 142, Ranking = 310, Active = true }, // Russia
new Player { Id = 311, Name = "Sabine Lisicki", YearOfBirth = 1990, NationalityId = 64, Ranking = 311, Active = true }, // Germany
new Player { Id = 312, Name = "Lois Boisson", YearOfBirth = 2004, NationalityId = 60, Ranking = 312, Active = true }, // France
new Player { Id = 313, Name = "Amandine Hesse", YearOfBirth = 1994, NationalityId = 60, Ranking = 313, Active = true }, // France
new Player { Id = 314, Name = "Veronica Miroshnichenko", YearOfBirth = 1998, NationalityId = 142, Ranking = 314, Active = true }, // Russia
new Player { Id = 315, Name = "Francesca Curmi", YearOfBirth = 2003, NationalityId = 107, Ranking = 315, Active = true }, // Malta
new Player { Id = 316, Name = "Ayano Shimizu", YearOfBirth = 1999, NationalityId = 84, Ranking = 316, Active = true }, // Japan
new Player { Id = 317, Name = "Lizette Cabrera", YearOfBirth = 1998, NationalityId = 9, Ranking = 317, Active = true }, // Australia
new Player { Id = 318, Name = "Martha Matoula", YearOfBirth = 1998, NationalityId = 66, Ranking = 318, Active = true }, // Greece
new Player { Id = 319, Name = "Liv Hovde", YearOfBirth = 2006, NationalityId = 185, Ranking = 319, Active = true }, // United States
new Player { Id = 320, Name = "Katarina Kozarov", YearOfBirth = 1999, NationalityId = 152, Ranking = 320, Active = true }, // Serbia
new Player { Id = 321, Name = "Na-Lae Han", YearOfBirth = 1993, NationalityId = 90, Ranking = 321, Active = true }, // Korea South
new Player { Id = 322, Name = "Audrey Albie", YearOfBirth = 1995, NationalityId = 60, Ranking = 322, Active = true }, // France
new Player { Id = 323, Name = "Camilla Rosatello", YearOfBirth = 1996, NationalityId = 82, Ranking = 323, Active = true }, // Italy
new Player { Id = 324, Name = "Linda Klimovicova", YearOfBirth = 2005, NationalityId = 45, Ranking = 324, Active = true }, // Czech Republic
new Player { Id = 325, Name = "Andreea Prisacariu", YearOfBirth = 2001, NationalityId = 141, Ranking = 325, Active = true }, // Romania
new Player { Id = 326, Name = "Kristina Dmitruk", YearOfBirth = 2004, NationalityId = 16, Ranking = 326, Active = true }, // Belarus
new Player { Id = 327, Name = "Polina Iatcenko", YearOfBirth = 2004, NationalityId = 142, Ranking = 327, Active = true }, // Russia
new Player { Id = 328, Name = "Alina Charaeva", YearOfBirth = 2003, NationalityId = 142, Ranking = 328, Active = true }, // Russia
new Player { Id = 329, Name = "Karman Kaur Thandi", YearOfBirth = 1999, NationalityId = 76, Ranking = 329, Active = true }, // India
new Player { Id = 330, Name = "Sada Nahimana", YearOfBirth = 2002, NationalityId = 28, Ranking = 330, Active = true }, // Burundi
new Player { Id = 331, Name = "Ekaterine Gorgodze", YearOfBirth = 1992, NationalityId = 63, Ranking = 331, Active = true }, // Georgia
new Player { Id = 332, Name = "Raveena Kingsley", YearOfBirth = 1999, NationalityId = 185, Ranking = 332, Active = true }, // United States
new Player { Id = 333, Name = "Victoria Mboko", YearOfBirth = 2007, NationalityId = 32, Ranking = 333, Active = true }, // Canada
new Player { Id = 334, Name = "Anastasiia Sobolieva", YearOfBirth = 2005, NationalityId = 182, Ranking = 334, Active = true }, // Ukraine
new Player { Id = 335, Name = "Mia Ristic", YearOfBirth = 2007, NationalityId = 152, Ranking = 335, Active = true }, // Serbia
new Player { Id = 336, Name = "Kyoka Okamura", YearOfBirth = 1996, NationalityId = 84, Ranking = 336, Active = true }, // Japan
new Player { Id = 337, Name = "Susan Bandecchi", YearOfBirth = 1999, NationalityId = 167, Ranking = 337, Active = true }, // Switzerland
new Player { Id = 338, Name = "Rutuja Bhosale", YearOfBirth = 1997, NationalityId = 76, Ranking = 338, Active = true }, // India
new Player { Id = 339, Name = "Victoria Hu", YearOfBirth = 2003, NationalityId = 185, Ranking = 339, Active = true }, // United States
new Player { Id = 340, Name = "Dalila Spiteri", YearOfBirth = 1998, NationalityId = 82, Ranking = 340, Active = true }, // Italy
new Player { Id = 341, Name = "Lisa Pigato", YearOfBirth = 2004, NationalityId = 82, Ranking = 341, Active = true }, // Italy
new Player { Id = 342, Name = "Elena Pridankina", YearOfBirth = 2006, NationalityId = 142, Ranking = 342, Active = true }, // Russia
new Player { Id = 343, Name = "Reka-Luca Jani", YearOfBirth = 1992, NationalityId = 74, Ranking = 343, Active = true }, // Hungary
new Player { Id = 344, Name = "Alison Van Uytvanck", YearOfBirth = 1995, NationalityId = 17, Ranking = 344, Active = true }, // Belgium
new Player { Id = 345, Name = "Madison Sieg", YearOfBirth = 2004, NationalityId = 185, Ranking = 345, Active = true }, // United States
new Player { Id = 346, Name = "Diana Marcinkevica", YearOfBirth = 1993, NationalityId = 94, Ranking = 346, Active = true }, // Latvia
new Player { Id = 347, Name = "Barbora Palicova", YearOfBirth = 2005, NationalityId = 45, Ranking = 347, Active = true }, // Czech Republic
new Player { Id = 348, Name = "Fernanda Contreras Gomez", YearOfBirth = 1998, NationalityId = 111, Ranking = 348, Active = true }, // Mexico
new Player { Id = 349, Name = "Magali Kempen", YearOfBirth = 1998, NationalityId = 17, Ranking = 349, Active = true }, // Belgium
new Player { Id = 350, Name = "Conny Perrin", YearOfBirth = 1991, NationalityId = 167, Ranking = 350, Active = true }, // Switzerland
new Player { Id = 351, Name = "Daria Lodikova", YearOfBirth = 1997, NationalityId = 142, Ranking = 351, Active = true }, // Russia
new Player { Id = 352, Name = "Elena Malygina", YearOfBirth = 2001, NationalityId = 55, Ranking = 352, Active = true }, // Estonia
new Player { Id = 353, Name = "Anna Siskova", YearOfBirth = 2002, NationalityId = 45, Ranking = 353, Active = true }, // Czech Republic
new Player { Id = 354, Name = "Jia-Jing Lu", YearOfBirth = 1990, NationalityId = 36, Ranking = 354, Active = true }, // China
new Player { Id = 355, Name = "Lina Glushko", YearOfBirth = 2001, NationalityId = 81, Ranking = 355, Active = true }, // Israel
new Player { Id = 356, Name = "Allie Kiick", YearOfBirth = 1996, NationalityId = 185, Ranking = 356, Active = true }, // United States
new Player { Id = 357, Name = "Eva Vedder", YearOfBirth = 2000, NationalityId = 123, Ranking = 357, Active = true }, // Netherlands
new Player { Id = 358, Name = "Sara Saito", YearOfBirth = 2007, NationalityId = 84, Ranking = 358, Active = true }, // Japan
new Player { Id = 359, Name = "Maja Chwalinska", YearOfBirth = 2002, NationalityId = 138, Ranking = 359, Active = true }, // Poland
new Player { Id = 360, Name = "Katharina Hobgarski", YearOfBirth = 1998, NationalityId = 64, Ranking = 360, Active = true }, // Germany
new Player { Id = 361, Name = "Ayla Aksu", YearOfBirth = 1997, NationalityId = 178, Ranking = 361, Active = true }, // Turkey
new Player { Id = 362, Name = "Ilinca Dalina Amariei", YearOfBirth = 2003, NationalityId = 141, Ranking = 362, Active = true }, // Romania
new Player { Id = 363, Name = "Martyna Kubka", YearOfBirth = 2002, NationalityId = 138, Ranking = 363, Active = true }, // Poland
new Player { Id = 364, Name = "Nefisa Berberovic", YearOfBirth = 2000, NationalityId = 22, Ranking = 364, Active = true }, // Bosnia and Herzegovina
new Player { Id = 365, Name = "Asia Muhammad", YearOfBirth = 1992, NationalityId = 185, Ranking = 365, Active = true }, // United States
new Player { Id = 366, Name = "Ksenia Zaytseva", YearOfBirth = 2005, NationalityId = 142, Ranking = 366, Active = true }, // Russia
new Player { Id = 367, Name = "Katy Dunne", YearOfBirth = 1996, NationalityId = 184, Ranking = 367, Active = true }, // United Kingdom
new Player { Id = 368, Name = "Eden Silva", YearOfBirth = 1997, NationalityId = 184, Ranking = 368, Active = true }, // United Kingdom
new Player { Id = 369, Name = "Amanda Anisimova", YearOfBirth = 2002, NationalityId = 185, Ranking = 369, Active = true }, // United States
new Player { Id = 370, Name = "Sophie Chang", YearOfBirth = 1998, NationalityId = 185, Ranking = 370, Active = true }, // United States
new Player { Id = 371, Name = "Georgina Garcia-Perez", YearOfBirth = 1993, NationalityId = 162, Ranking = 371, Active = true }, // Spain
new Player { Id = 372, Name = "Anna Brogan", YearOfBirth = 1998, NationalityId = 184, Ranking = 372, Active = true }, // United Kingdom
new Player { Id = 373, Name = "Victoria Rodriguez", YearOfBirth = 1996, NationalityId = 111, Ranking = 373, Active = true }, // Mexico
new Player { Id = 374, Name = "Natsumi Kawaguchi", YearOfBirth = 2003, NationalityId = 84, Ranking = 374, Active = true }, // Japan
new Player { Id = 375, Name = "Daniela Vismane", YearOfBirth = 2001, NationalityId = 94, Ranking = 375, Active = true }, // Latvia
new Player { Id = 376, Name = "Ylona-Georgiana Ghioroaie", YearOfBirth = 1999, NationalityId = 141, Ranking = 376, Active = true }, // Romania
new Player { Id = 377, Name = "Vivian Wolff", YearOfBirth = 1999, NationalityId = 64, Ranking = 377, Active = true }, // Germany
new Player { Id = 378, Name = "Martina Colmegna", YearOfBirth = 1997, NationalityId = 82, Ranking = 378, Active = true }, // Italy
new Player { Id = 379, Name = "Julia Middendorf", YearOfBirth = 2004, NationalityId = 64, Ranking = 379, Active = true }, // Germany
new Player { Id = 380, Name = "Manon Leonard", YearOfBirth = 2002, NationalityId = 60, Ranking = 380, Active = true }, // France
new Player { Id = 381, Name = "Rina Saigo", YearOfBirth = 2001, NationalityId = 84, Ranking = 381, Active = true }, // Japan
new Player { Id = 382, Name = "Cagla Buyukakcay", YearOfBirth = 1990, NationalityId = 178, Ranking = 382, Active = true }, // Turkey
new Player { Id = 383, Name = "Aoi Ito", YearOfBirth = 2005, NationalityId = 84, Ranking = 383, Active = true }, // Japan
new Player { Id = 384, Name = "Gabriela Ce", YearOfBirth = 1994, NationalityId = 24, Ranking = 384, Active = true }, // Brazil
new Player { Id = 385, Name = "Guillermina Naya", YearOfBirth = 1997, NationalityId = 7, Ranking = 385, Active = true }, // Argentina
new Player { Id = 386, Name = "Lucia Cortez Llorca", YearOfBirth = 2001, NationalityId = 162, Ranking = 386, Active = true }, // Spain
new Player { Id = 387, Name = "Zongyu Li", YearOfBirth = 2004, NationalityId = 36, Ranking = 387, Active = true }, // China
new Player { Id = 388, Name = "Tamira Paszek", YearOfBirth = 1991, NationalityId = 10, Ranking = 388, Active = true }, // Austria
new Player { Id = 389, Name = "Chloe Beck", YearOfBirth = 2002, NationalityId = 185, Ranking = 389, Active = true }, // USA
new Player { Id = 390, Name = "Jessie Aney", YearOfBirth = 1999, NationalityId = 185, Ranking = 390, Active = true }, // USA
new Player { Id = 391, Name = "Oleksandra Oliynykova", YearOfBirth = 2002, NationalityId = 42, Ranking = 391, Active = true }, // Croatia
new Player { Id = 392, Name = "Eva Guerrero Alvarez", YearOfBirth = 2000, NationalityId = 162, Ranking = 392, Active = true }, // Spain
new Player { Id = 393, Name = "Gabriela Lee", YearOfBirth = 1996, NationalityId = 141, Ranking = 393, Active = true }, // Romania
new Player { Id = 394, Name = "Robin Anderson", YearOfBirth = 1994, NationalityId = 185, Ranking = 394, Active = true }, // USA
new Player { Id = 395, Name = "Marcela Zacarias", YearOfBirth = 1995, NationalityId = 111, Ranking = 395, Active = true }, // Mexico
new Player { Id = 396, Name = "Weronika Falkowska", YearOfBirth = 2001, NationalityId = 138, Ranking = 396, Active = true }, // Poland
new Player { Id = 397, Name = "Ashley Lahey", YearOfBirth = 2000, NationalityId = 185, Ranking = 397, Active = true }, // USA
new Player { Id = 398, Name = "Whitney Osuigwe", YearOfBirth = 2003, NationalityId = 185, Ranking = 398, Active = true }, // USA
new Player { Id = 399, Name = "Emma Lene", YearOfBirth = 2000, NationalityId = 60, Ranking = 399, Active = true }, // France
new Player { Id = 400, Name = "Nika Radisic", YearOfBirth = 2001, NationalityId = 157, Ranking = 400, Active = true } // Slovenia
);
        }
    }
}
