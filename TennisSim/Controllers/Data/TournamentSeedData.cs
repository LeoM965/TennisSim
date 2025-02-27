using System;
using TennisSim.Models;
using Microsoft.EntityFrameworkCore;

namespace TennisSim.Data
{
    public static class TournamentSeedData
    {
        public static void SeedTournaments(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tournament>().HasData(
                // Week 1
                new Tournament
                {
                    Id = 1,
                    Name = "Brisbane Masters500",
                    Location = "Australia",
                    StartDate = new DateTime(2024, 1, 1),
                    EndDate = new DateTime(2024, 1, 7),
                    QualifyingStartDate = new DateTime(2023, 12, 30),
                    QualifyingEndDate = new DateTime(2023, 12, 31),
                    Surface = "Hard",
                    Category = TournamentCategory.Masters500,
                    QualifyingRounds = 2
                },
                new Tournament
                {
                    Id = 2,
                    Name = "Auckland Masters250",
                    Location = "New Zealand",
                    StartDate = new DateTime(2024, 1, 1),
                    EndDate = new DateTime(2024, 1, 7),
                    QualifyingStartDate = new DateTime(2023, 12, 30),
                    QualifyingEndDate = new DateTime(2023, 12, 31),
                    Surface = "Hard",
                    Category = TournamentCategory.Masters250,
                    QualifyingRounds = 2
                },
                new Tournament
                {
                    Id = 3,
                    Name = "Canberra ITF100K",
                    Location = "Australia",
                    StartDate = new DateTime(2024, 1, 1),
                    EndDate = new DateTime(2024, 1, 7),
                    QualifyingStartDate = new DateTime(2023, 12, 29),
                    QualifyingEndDate = new DateTime(2023, 12, 30),
                    Surface = "Hard",
                    Category = TournamentCategory.ITF100K,
                    QualifyingRounds = 2
                },
                new Tournament
                {
                    Id = 4,
                    Name = "Nonthaburi1 ITF50K",
                    Location = "Thailand",
                    StartDate = new DateTime(2024, 1, 1),
                    EndDate = new DateTime(2024, 1, 7),
                    QualifyingStartDate = new DateTime(2023, 12, 29),
                    QualifyingEndDate = new DateTime(2023, 12, 30),
                    Surface = "Hard",
                    Category = TournamentCategory.ITF50K,
                    QualifyingRounds = 2
                },
                new Tournament
                {
                    Id = 5,
                    Name = "Arcadia ITF25K",
                    Location = "USA",
                    StartDate = new DateTime(2024, 1, 1),
                    EndDate = new DateTime(2024, 1, 7),
                    QualifyingStartDate = new DateTime(2023, 12, 29),
                    QualifyingEndDate = new DateTime(2023, 12, 30),
                    Surface = "Hard",
                    Category = TournamentCategory.ITF25K,
                    QualifyingRounds = 2
                },
                new Tournament
                {
                    Id = 6,
                    Name = "Monastir1 ITF10K",
                    Location = "Tunisia",
                    StartDate = new DateTime(2024, 1, 1),
                    EndDate = new DateTime(2024, 1, 7),
                    QualifyingStartDate = new DateTime(2023, 12, 29),
                    QualifyingEndDate = new DateTime(2023, 12, 30),
                    Surface = "Hard",
                    Category = TournamentCategory.ITF10K,
                    QualifyingRounds = 2
                },

                 // Week 2
                new Tournament
                {
                    Id = 7,
                    Name = "Adelaide Masters500",
                    Location = "Australia",
                    StartDate = new DateTime(2024, 1, 8),
                    EndDate = new DateTime(2024, 1, 14),
                    QualifyingStartDate = new DateTime(2024, 1, 6),
                    QualifyingEndDate = new DateTime(2024, 1, 7),
                    Surface = "Hard",
                    Category = TournamentCategory.Masters500,
                    QualifyingRounds = 2
                },
                new Tournament
                {
                    Id = 8,
                    Name = "Hobart Masters250",
                    Location = "Australia",
                    StartDate = new DateTime(2024, 1, 8),
                    EndDate = new DateTime(2024, 1, 14),
                    QualifyingStartDate = new DateTime(2024, 1, 6),
                    QualifyingEndDate = new DateTime(2024, 1, 7),
                    Surface = "Hard",
                    Category = TournamentCategory.Masters250,
                    QualifyingRounds = 2
                },
                new Tournament
                {
                    Id = 9,
                    Name = "Nonthaburi2 ITF50K",
                    Location = "Thailand",
                    StartDate = new DateTime(2024, 1, 8),
                    EndDate = new DateTime(2024, 1, 14),
                    QualifyingStartDate = new DateTime(2024, 1, 6),
                    QualifyingEndDate = new DateTime(2024, 1, 7),
                    Surface = "Hard",
                    Category = TournamentCategory.ITF50K,
                    QualifyingRounds = 2
                },
                new Tournament
                {
                    Id = 10,
                    Name = "Naples1 ITF25K",
                    Location = "USA",
                    StartDate = new DateTime(2024, 1, 8),
                    EndDate = new DateTime(2024, 1, 14),
                    QualifyingStartDate = new DateTime(2024, 1, 6),
                    QualifyingEndDate = new DateTime(2024, 1, 7),
                    Surface = "Clay",
                    Category = TournamentCategory.ITF25K,
                    QualifyingRounds = 2
                },
                new Tournament
                {
                    Id = 11,
                    Name = "Monastir2 ITF10K",
                    Location = "Tunisia",
                    StartDate = new DateTime(2024, 1, 8),
                    EndDate = new DateTime(2024, 1, 14),
                    QualifyingStartDate = new DateTime(2024, 1, 6),
                    QualifyingEndDate = new DateTime(2024, 1, 7),
                    Surface = "Hard",
                    Category = TournamentCategory.ITF10K,
                    QualifyingRounds = 2
                },

                // Week 3
                new Tournament
                {
                    Id = 12,
                    Name = "Australian Open",
                    Location = "Australia",
                    StartDate = new DateTime(2024, 1, 15),
                    EndDate = new DateTime(2024, 1, 28),
                    QualifyingStartDate = new DateTime(2024, 1, 11),
                    QualifyingEndDate = new DateTime(2024, 1, 13),
                    Surface = "Hard",
                    Category = TournamentCategory.GrandSlam,
                    QualifyingRounds = 3
                },
                new Tournament
                {
                    Id = 13,
                    Name = "Bengaluru ITF50K",
                    Location = "India",
                    StartDate = new DateTime(2024, 1, 15),
                    EndDate = new DateTime(2024, 1, 21),
                    QualifyingStartDate = new DateTime(2024, 1, 13),
                    QualifyingEndDate = new DateTime(2024, 1, 14),
                    Surface = "Hard",
                    Category = TournamentCategory.ITF50K,
                    QualifyingRounds = 2
                },
                new Tournament
                {
                    Id = 14,
                    Name = "Naples2 ITF25K",
                    Location = "USA",
                    StartDate = new DateTime(2024, 1, 15),
                    EndDate = new DateTime(2024, 1, 21),
                    QualifyingStartDate = new DateTime(2024, 1, 13),
                    QualifyingEndDate = new DateTime(2024, 1, 14),
                    Surface = "Clay",
                    Category = TournamentCategory.ITF25K,
                    QualifyingRounds = 2
                },
                new Tournament
                {
                    Id = 15,
                    Name = "Monastir3 ITF25K",
                    Location = "Tunisia",
                    StartDate = new DateTime(2024, 1, 15),
                    EndDate = new DateTime(2024, 1, 21),
                    QualifyingStartDate = new DateTime(2024, 1, 13),
                    QualifyingEndDate = new DateTime(2024, 1, 14),
                    Surface = "Hard",
                    Category = TournamentCategory.ITF25K,
                    QualifyingRounds = 2
                },

                //Week 4

                new Tournament
                {
                    Id = 16,
                    Name = "Vero Beach ITF50K",
                    Location = "USA",
                    StartDate = new DateTime(2024, 1, 22),
                    EndDate = new DateTime(2024, 1, 28),
                    QualifyingStartDate = new DateTime(2024, 1, 20),
                    QualifyingEndDate = new DateTime(2024, 1, 21),
                    Surface = "Clay",
                    Category = TournamentCategory.ITF50K,
                    QualifyingRounds = 2
                },
                new Tournament
                {
                    Id = 17,
                    Name = "Pune ITF50K",
                    Location = "India",
                    StartDate = new DateTime(2024, 1, 22),
                    EndDate = new DateTime(2024, 1, 28),
                    QualifyingStartDate = new DateTime(2024, 1, 20),
                    QualifyingEndDate = new DateTime(2024, 1, 21),
                    Surface = "Hard",
                    Category = TournamentCategory.ITF50K,
                    QualifyingRounds = 2
                },
                new Tournament
                {
                    Id = 18,
                    Name = "Monastir4 ITF25K",
                    Location = "Tunisia",
                    StartDate = new DateTime(2024, 1, 22),
                    EndDate = new DateTime(2024, 1, 28),
                    QualifyingStartDate = new DateTime(2024, 1, 20),
                    QualifyingEndDate = new DateTime(2024, 1, 21),
                    Surface = "Hard",
                    Category = TournamentCategory.ITF25K,
                    QualifyingRounds = 2
                },
                new Tournament
                {
                    Id = 19,
                    Name = "Antalya1 ITF10K",
                    Location = "Turkey",
                    StartDate = new DateTime(2024, 1, 22),
                    EndDate = new DateTime(2024, 1, 28),
                    QualifyingStartDate = new DateTime(2024, 1, 20),
                    QualifyingEndDate = new DateTime(2024, 1, 21),
                    Surface = "Clay",
                    Category = TournamentCategory.ITF10K,
                    QualifyingRounds = 2
                },

                //Week 5
                new Tournament
                {
                    Id = 20,
                    Name = "Linz Masters500",
                    Location = "Austria",
                    StartDate = new DateTime(2024, 1, 29),
                    EndDate = new DateTime(2024, 2, 4),
                    QualifyingStartDate = new DateTime(2024, 1, 27),
                    QualifyingEndDate = new DateTime(2024, 1, 28),
                    Surface = "Hard Indoor",
                    Category = TournamentCategory.Masters500,
                    QualifyingRounds = 2
                },
                new Tournament
                {
                    Id = 21,
                    Name = "Hua Hin Masters250",
                    Location = "Thailand",
                    StartDate = new DateTime(2024, 1, 29),
                    EndDate = new DateTime(2024, 2, 4),
                    QualifyingStartDate = new DateTime(2024, 1, 27),
                    QualifyingEndDate = new DateTime(2024, 1, 28),
                    Surface = "Hard",
                    Category = TournamentCategory.Masters250,
                    QualifyingRounds = 2
                },
                new Tournament
                {
                    Id = 22,
                    Name = "Burnie ITF100K",
                    Location = "Australia",
                    StartDate = new DateTime(2024, 1, 29),
                    EndDate = new DateTime(2024, 2, 4),
                    QualifyingStartDate = new DateTime(2024, 1, 27),
                    QualifyingEndDate = new DateTime(2024, 1, 28),
                    Surface = "Hard",
                    Category = TournamentCategory.ITF100K,
                    QualifyingRounds = 2
                },
                new Tournament
                {
                    Id = 23,
                    Name = "Indore ITF50K",
                    Location = "India",
                    StartDate = new DateTime(2024, 1, 29),
                    EndDate = new DateTime(2024, 2, 4),
                    QualifyingStartDate = new DateTime(2024, 1, 27),
                    QualifyingEndDate = new DateTime(2024, 1, 28),
                    Surface = "Hard",
                    Category = TournamentCategory.ITF50K,
                    QualifyingRounds = 2
                },
                new Tournament
                {
                    Id = 24,
                    Name = "Monastir5 ITF10K",
                    Location = "Tunisia",
                    StartDate = new DateTime(2024, 1, 29),
                    EndDate = new DateTime(2024, 2, 4),
                    QualifyingStartDate = new DateTime(2024, 1, 27),
                    QualifyingEndDate = new DateTime(2024, 1, 28),
                    Surface = "Hard",
                    Category = TournamentCategory.ITF10K,
                    QualifyingRounds = 2
                },
                new Tournament
                {
                    Id = 25,
                    Name = "Antalya2 ITF10K",
                    Location = "Turkey",
                    StartDate = new DateTime(2024, 1, 29),
                    EndDate = new DateTime(2024, 2, 4),
                    QualifyingStartDate = new DateTime(2024, 1, 27),
                    QualifyingEndDate = new DateTime(2024, 1, 28),
                    Surface = "Clay",
                    Category = TournamentCategory.ITF10K,
                    QualifyingRounds = 2
                },
                // Week 6
                new Tournament
                {
                    Id = 26,
                    Name = "Abu Dhabi Masters500",
                    Location = "UAE",
                    StartDate = new DateTime(2024, 2, 5),
                    EndDate = new DateTime(2024, 2, 11),
                    QualifyingStartDate = new DateTime(2024, 2, 3),
                    QualifyingEndDate = new DateTime(2024, 2, 4),
                    Surface = "Hard",
                    Category = TournamentCategory.Masters500,
                    QualifyingRounds = 2
                },
                new Tournament
                {
                    Id = 27,
                    Name = "Transylvania Masters250",
                    Location = "Romania",
                    StartDate = new DateTime(2024, 2, 5),
                    EndDate = new DateTime(2024, 2, 11),
                    QualifyingStartDate = new DateTime(2024, 2, 3),
                    QualifyingEndDate = new DateTime(2024, 2, 4),
                    Surface = "Hard Indoor",
                    Category = TournamentCategory.Masters250,
                    QualifyingRounds = 2
                },
                new Tournament
                {
                    Id = 28,
                    Name = "Mumbai ITF100K",
                    Location = "India",
                    StartDate = new DateTime(2024, 2, 5),
                    EndDate = new DateTime(2024, 2, 11),
                    QualifyingStartDate = new DateTime(2024, 2, 3),
                    QualifyingEndDate = new DateTime(2024, 2, 4),
                    Surface = "Hard",
                    Category = TournamentCategory.ITF100K,
                    QualifyingRounds = 2
                },
                new Tournament
                {
                    Id = 29,
                    Name = "Grenoble ITF50K",
                    Location = "France",
                    StartDate = new DateTime(2024, 2, 5),
                    EndDate = new DateTime(2024, 2, 11),
                    QualifyingStartDate = new DateTime(2024, 2, 3),
                    QualifyingEndDate = new DateTime(2024, 2, 4),
                    Surface = "Hard Indoor",
                    Category = TournamentCategory.ITF50K,
                    QualifyingRounds = 2
                },
                new Tournament
                {
                    Id = 30,
                    Name = "Monastir6 ITF10K",
                    Location = "Tunisia",
                    StartDate = new DateTime(2024, 2, 5),
                    EndDate = new DateTime(2024, 2, 11),
                    QualifyingStartDate = new DateTime(2024, 2, 3),
                    QualifyingEndDate = new DateTime(2024, 2, 4),
                    Surface = "Hard",
                    Category = TournamentCategory.ITF10K,
                    QualifyingRounds = 2
                },
                new Tournament
                {
                    Id = 31,
                    Name = "Antalya3 ITF10K",
                    Location = "Turkey",
                    StartDate = new DateTime(2024, 2, 5),
                    EndDate = new DateTime(2024, 2, 11),
                    QualifyingStartDate = new DateTime(2024, 2, 3),
                    QualifyingEndDate = new DateTime(2024, 2, 4),
                    Surface = "Clay",
                    Category = TournamentCategory.ITF10K,
                    QualifyingRounds = 2
                },
                // Week 7
                new Tournament
                {
                    Id = 32,
                    Name = "Qatar Open Masters1000",
                    Location = "Qatar",
                    StartDate = new DateTime(2024, 2, 12),
                    EndDate = new DateTime(2024, 2, 18),
                    QualifyingStartDate = new DateTime(2024, 2, 10),
                    QualifyingEndDate = new DateTime(2024, 2, 11),
                    Surface = "Hard",
                    Category = TournamentCategory.Masters1000,
                    QualifyingRounds = 2
                },
                new Tournament
                {
                    Id = 33,
                    Name = "Altenkirchen ITF50K",
                    Location = "Germany",
                    StartDate = new DateTime(2024, 2, 12),
                    EndDate = new DateTime(2024, 2, 18),
                    QualifyingStartDate = new DateTime(2024, 2, 10),
                    QualifyingEndDate = new DateTime(2024, 2, 11),
                    Surface = "Carpet",
                    Category = TournamentCategory.ITF50K,
                    QualifyingRounds = 2
                },
                new Tournament
                {
                    Id = 34,
                    Name = "Morelia ITF50K",
                    Location = "Mexico",
                    StartDate = new DateTime(2024, 2, 12),
                    EndDate = new DateTime(2024, 2, 18),
                    QualifyingStartDate = new DateTime(2024, 2, 10),
                    QualifyingEndDate = new DateTime(2024, 2, 11),
                    Surface = "Hard",
                    Category = TournamentCategory.ITF50K,
                    QualifyingRounds = 2
                },
                new Tournament
                {
                    Id = 35,
                    Name = "Monacor1 ITF10K",
                    Location = "Spain",
                    StartDate = new DateTime(2024, 2, 12),
                    EndDate = new DateTime(2024, 2, 18),
                    QualifyingStartDate = new DateTime(2024, 2, 10),
                    QualifyingEndDate = new DateTime(2024, 2, 11),
                    Surface = "Hard",
                    Category = TournamentCategory.ITF10K,
                    QualifyingRounds = 2
                },
                new Tournament
                {
                    Id = 36,
                    Name = "Antalya4 ITF10K",
                    Location = "Turkey",
                    StartDate = new DateTime(2024, 2, 12),
                    EndDate = new DateTime(2024, 2, 18),
                    QualifyingStartDate = new DateTime(2024, 2, 10),
                    QualifyingEndDate = new DateTime(2024, 2, 11),
                    Surface = "Clay",
                    Category = TournamentCategory.ITF10K,
                    QualifyingRounds = 2
                },

                // Week 8
                new Tournament
                {
                    Id = 37,
                    Name = "Dubai Open Masters1000",
                    Location = "UAE",
                    StartDate = new DateTime(2024, 2, 19),
                    EndDate = new DateTime(2024, 2, 25),
                    QualifyingStartDate = new DateTime(2024, 2, 17),
                    QualifyingEndDate = new DateTime(2024, 2, 18),
                    Surface = "Hard",
                    Category = TournamentCategory.Masters1000,
                    QualifyingRounds = 2
                },
                new Tournament
                {
                    Id = 38,
                    Name = "Puerta Vallarta ITF100K",
                    Location = "Mexico",
                    StartDate = new DateTime(2024, 2, 19),
                    EndDate = new DateTime(2024, 2, 25),
                    QualifyingStartDate = new DateTime(2024, 2, 17),
                    QualifyingEndDate = new DateTime(2024, 2, 18),
                    Surface = "Hard",
                    Category = TournamentCategory.ITF100K,
                    QualifyingRounds = 2
                },
                new Tournament
                {
                    Id = 39,
                    Name = "Mexico City ITF25K",
                    Location = "Mexico",
                    StartDate = new DateTime(2024, 2, 19),
                    EndDate = new DateTime(2024, 2, 25),
                    QualifyingStartDate = new DateTime(2024, 2, 17),
                    QualifyingEndDate = new DateTime(2024, 2, 18),
                    Surface = "Hard",
                    Category = TournamentCategory.ITF25K,
                    QualifyingRounds = 2
                },
                new Tournament
                {
                    Id = 40,
                    Name = "Monacor2 ITF15K",
                    Location = "Spain",
                    StartDate = new DateTime(2024, 2, 19),
                    EndDate = new DateTime(2024, 2, 25),
                    QualifyingStartDate = new DateTime(2024, 2, 17),
                    QualifyingEndDate = new DateTime(2024, 2, 18),
                    Surface = "Hard",
                    Category = TournamentCategory.ITF10K,
                    QualifyingRounds = 2
                },

                // Week 9
                new Tournament
                {
                    Id = 41,
                    Name = "San Diego Masters500",
                    Location = "USA",
                    StartDate = new DateTime(2024, 2, 26),
                    EndDate = new DateTime(2024, 3, 3),
                    QualifyingStartDate = new DateTime(2024, 2, 24),
                    QualifyingEndDate = new DateTime(2024, 2, 25),
                    Surface = "Hard",
                    Category = TournamentCategory.Masters500,
                    QualifyingRounds = 2
                },
                new Tournament
                {
                    Id = 42,
                    Name = "Austin Masters250",
                    Location = "USA",
                    StartDate = new DateTime(2024, 2, 26),
                    EndDate = new DateTime(2024, 3, 3),
                    QualifyingStartDate = new DateTime(2024, 2, 24),
                    QualifyingEndDate = new DateTime(2024, 2, 25),
                    Surface = "Hard",
                    Category = TournamentCategory.Masters250,
                    QualifyingRounds = 2
                },
                new Tournament
                {
                    Id = 43,
                    Name = "Pretoria1 ITF50K",
                    Location = "South Africa",
                    StartDate = new DateTime(2024, 2, 26),
                    EndDate = new DateTime(2024, 3, 3),
                    QualifyingStartDate = new DateTime(2024, 2, 24),
                    QualifyingEndDate = new DateTime(2024, 2, 25),
                    Surface = "Hard",
                    Category = TournamentCategory.ITF50K,
                    QualifyingRounds = 2
                },
                new Tournament
                {
                    Id = 44,
                    Name = "Trnava1 ITF25K",
                    Location = "Slovakia",
                    StartDate = new DateTime(2024, 2, 26),
                    EndDate = new DateTime(2024, 3, 3),
                    QualifyingStartDate = new DateTime(2024, 2, 24),
                    QualifyingEndDate = new DateTime(2024, 2, 25),
                    Surface = "Hard Indoor",
                    Category = TournamentCategory.ITF25K,
                    QualifyingRounds = 2
                },
                new Tournament
                {
                    Id = 45,
                    Name = "Monacor3 ITF15K",
                    Location = "Spain",
                    StartDate = new DateTime(2024, 2, 26),
                    EndDate = new DateTime(2024, 3, 3),
                    QualifyingStartDate = new DateTime(2024, 2, 24),
                    QualifyingEndDate = new DateTime(2024, 2, 25),
                    Surface = "Hard",
                    Category = TournamentCategory.ITF10K,
                    QualifyingRounds = 2
                },
                // Week 10
                new Tournament
                {
                    Id = 46,
                    Name = "Indian Wells Masters1000",
                    Location = "USA",
                    StartDate = new DateTime(2024, 3, 4),
                    EndDate = new DateTime(2024, 3, 17),
                    QualifyingStartDate = new DateTime(2024, 3, 2),
                    QualifyingEndDate = new DateTime(2024, 3, 3),
                    Surface = "Hard",
                    Category = TournamentCategory.Masters1000,
                    QualifyingRounds = 2
                },
                new Tournament
                {
                    Id = 47,
                    Name = "Pretoria2 ITF50K",
                    Location = "South Africa",
                    StartDate = new DateTime(2024, 3, 4),
                    EndDate = new DateTime(2024, 3, 10),
                    QualifyingStartDate = new DateTime(2024, 3, 2),
                    QualifyingEndDate = new DateTime(2024, 3, 3),
                    Surface = "Hard",
                    Category = TournamentCategory.ITF50K,
                    QualifyingRounds = 2
                },
                new Tournament
                {
                    Id = 48,
                    Name = "Trnava2 ITF50K",
                    Location = "Slovakia",
                    StartDate = new DateTime(2024, 3, 4),
                    EndDate = new DateTime(2024, 3, 10),
                    QualifyingStartDate = new DateTime(2024, 3, 2),
                    QualifyingEndDate = new DateTime(2024, 3, 3),
                    Surface = "Hard Indoor",
                    Category = TournamentCategory.ITF50K,
                    QualifyingRounds = 2
                },
                new Tournament
                {
                    Id = 49,
                    Name = "Heraklion1 ITF10K",
                    Location = "Greece",
                    StartDate = new DateTime(2024, 3, 4),
                    EndDate = new DateTime(2024, 3, 10),
                    QualifyingStartDate = new DateTime(2024, 3, 2),
                    QualifyingEndDate = new DateTime(2024, 3, 3),
                    Surface = "Clay",
                    Category = TournamentCategory.ITF10K,
                    QualifyingRounds = 2
                },

                // Week 11
                new Tournament
                {
                    Id = 50,
                    Name = "Indian Wells",
                    Location = "USA",
                    StartDate = new DateTime(2024, 3, 11),
                    EndDate = new DateTime(2024, 3, 17),
                    QualifyingStartDate = new DateTime(2024, 3, 9),
                    QualifyingEndDate = new DateTime(2024, 3, 10),
                    Surface = "Hard",
                    Category = TournamentCategory.ITF100K,
                    QualifyingRounds = 2
                },
                new Tournament
                {
                    Id = 51,
                    Name = "Charleston.ITF ITF100K",
                    Location = "USA",
                    StartDate = new DateTime(2024, 3, 11),
                    EndDate = new DateTime(2024, 3, 17),
                    QualifyingStartDate = new DateTime(2024, 3, 9),
                    QualifyingEndDate = new DateTime(2024, 3, 10),
                    Surface = "Hard",
                    Category = TournamentCategory.ITF100K,
                    QualifyingRounds = 2
                },
                new Tournament
                {
                    Id = 52,
                    Name = "Ricany ITF50K",
                    Location = "Czechia",
                    StartDate = new DateTime(2024, 3, 11),
                    EndDate = new DateTime(2024, 3, 17),
                    QualifyingStartDate = new DateTime(2024, 3, 9),
                    QualifyingEndDate = new DateTime(2024, 3, 10),
                    Surface = "Hard Indoor",
                    Category = TournamentCategory.ITF50K,
                    QualifyingRounds = 2
                },
                new Tournament
                {
                    Id = 53,
                    Name = "Alaminos-Larnaca1 ITF25K",
                    Location = "Cyprus",
                    StartDate = new DateTime(2024, 3, 11),
                    EndDate = new DateTime(2024, 3, 17),
                    QualifyingStartDate = new DateTime(2024, 3, 9),
                    QualifyingEndDate = new DateTime(2024, 3, 10),
                    Surface = "Clay",
                    Category = TournamentCategory.ITF25K,
                    QualifyingRounds = 2
                },
                new Tournament
                {
                    Id = 54,
                    Name = "Heraklion2 ITF10K",
                    Location = "Greece",
                    StartDate = new DateTime(2024, 3, 11),
                    EndDate = new DateTime(2024, 3, 17),
                    QualifyingStartDate = new DateTime(2024, 3, 9),
                    QualifyingEndDate = new DateTime(2024, 3, 10),
                    Surface = "Clay",
                    Category = TournamentCategory.ITF10K,
                    QualifyingRounds = 2
                },

                // Week 12
                new Tournament
                {
                    Id = 55,
                    Name = "Miami Masters1000",
                    Location = "USA",
                    StartDate = new DateTime(2024, 3, 18),
                    EndDate = new DateTime(2024, 3, 31),
                    QualifyingStartDate = new DateTime(2024, 3, 16),
                    QualifyingEndDate = new DateTime(2024, 3, 17),
                    Surface = "Hard",
                    Category = TournamentCategory.Masters1000,
                    QualifyingRounds = 2
                },
                new Tournament
                {
                    Id = 56,
                    Name = "Maribor ITF50K",
                    Location = "Slovenia",
                    StartDate = new DateTime(2024, 3, 18),
                    EndDate = new DateTime(2024, 3, 24),
                    QualifyingStartDate = new DateTime(2024, 3, 16),
                    QualifyingEndDate = new DateTime(2024, 3, 17),
                    Surface = "Hard Indoor",
                    Category = TournamentCategory.ITF50K,
                    QualifyingRounds = 2
                },
                new Tournament
                {
                    Id = 57,
                    Name = "Alaminos-Larnaca2 ITF25K",
                    Location = "Cyprus",
                    StartDate = new DateTime(2024, 3, 18),
                    EndDate = new DateTime(2024, 3, 24),
                    QualifyingStartDate = new DateTime(2024, 3, 16),
                    QualifyingEndDate = new DateTime(2024, 3, 17),
                    Surface = "Clay",
                    Category = TournamentCategory.ITF25K,
                    QualifyingRounds = 2
                },
                // Week 13
                new Tournament
                {
                    Id = 58,
                    Name = "San Luis ITF100K",
                    Location = "Mexico",
                    StartDate = new DateTime(2024, 3, 25),
                    EndDate = new DateTime(2024, 3, 31),
                    QualifyingStartDate = new DateTime(2024, 3, 23),
                    QualifyingEndDate = new DateTime(2024, 3, 24),
                    Surface = "Clay",
                    Category = TournamentCategory.ITF100K,
                    QualifyingRounds = 2
                },
                new Tournament
                {
                    Id = 59,
                    Name = "Megasaray Antalya ITF100K",
                    Location = "Turkey",
                    StartDate = new DateTime(2024, 3, 25),
                    EndDate = new DateTime(2024, 3, 31),
                    QualifyingStartDate = new DateTime(2024, 3, 23),
                    QualifyingEndDate = new DateTime(2024, 3, 24),
                    Surface = "Clay",
                    Category = TournamentCategory.ITF100K,
                    QualifyingRounds = 2
                },
                new Tournament
                {
                    Id = 60,
                    Name = "Murska Sobota ITF50K",
                    Location = "Slovenia",
                    StartDate = new DateTime(2024, 3, 25),
                    EndDate = new DateTime(2024, 3, 31),
                    QualifyingStartDate = new DateTime(2024, 3, 23),
                    QualifyingEndDate = new DateTime(2024, 3, 24),
                    Surface = "Hard Indoor",
                    Category = TournamentCategory.ITF50K,
                    QualifyingRounds = 2
                },
                new Tournament
                {
                    Id = 61,
                    Name = "Santa Margherita Di Pula1 ITF10K",
                    Location = "Italy",
                    StartDate = new DateTime(2024, 3, 25),
                    EndDate = new DateTime(2024, 3, 31),
                    QualifyingStartDate = new DateTime(2024, 3, 23),
                    QualifyingEndDate = new DateTime(2024, 3, 24),
                    Surface = "Clay",
                    Category = TournamentCategory.ITF10K,
                    QualifyingRounds = 2
                },

            //Week 14
               new Tournament
               {
                   Id = 62,
                   Name = "Charleston Masters500",
                   Location = "USA",
                   StartDate = new DateTime(2024, 4, 14),
                   EndDate = new DateTime(2024, 4, 20),
                   QualifyingStartDate = new DateTime(2024, 4, 12),
                   QualifyingEndDate = new DateTime(2024, 4, 13),
                   Surface = "Clay",
                   Category = TournamentCategory.Masters500,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 63,
                   Name = "Bogota Masters250",
                   Location = "Colombia",
                   StartDate = new DateTime(2024, 4, 14),
                   EndDate = new DateTime(2024, 4, 20),
                   QualifyingStartDate = new DateTime(2024, 4, 12),
                   QualifyingEndDate = new DateTime(2024, 4, 13),
                   Surface = "Clay",
                   Category = TournamentCategory.Masters250,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 64,
                   Name = "La Bisbal d'Emporda ITF100K",
                   Location = "Spain",
                   StartDate = new DateTime(2024, 4, 14),
                   EndDate = new DateTime(2024, 4, 20),
                   QualifyingStartDate = new DateTime(2024, 4, 12),
                   QualifyingEndDate = new DateTime(2024, 4, 13),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF100K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 65,
                   Name = "Split ITF50K",
                   Location = "Croatia",
                   StartDate = new DateTime(2024, 4, 14),
                   EndDate = new DateTime(2024, 4, 20),
                   QualifyingStartDate = new DateTime(2024, 4, 12),
                   QualifyingEndDate = new DateTime(2024, 4, 13),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF50K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 66,
                   Name = "Santa Margherita Di Pula2 ITF10K",
                   Location = "Italy",
                   StartDate = new DateTime(2024, 4, 14),
                   EndDate = new DateTime(2024, 4, 20),
                   QualifyingStartDate = new DateTime(2024, 4, 12),
                   QualifyingEndDate = new DateTime(2024, 4, 13),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF10K,
                   QualifyingRounds = 2
               },
               //Week 15
               new Tournament
               {
                   Id = 67,
                   Name = "Zaragoza ITF100K",
                   Location = "Spain",
                   StartDate = new DateTime(2024, 4, 21),
                   EndDate = new DateTime(2024, 4, 27),
                   QualifyingStartDate = new DateTime(2024, 4, 19),
                   QualifyingEndDate = new DateTime(2024, 4, 20),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF100K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 68,
                   Name = "Bellinzona ITF25K",
                   Location = "Switzerland",
                   StartDate = new DateTime(2024, 4, 21),
                   EndDate = new DateTime(2024, 4, 27),
                   QualifyingStartDate = new DateTime(2024, 4, 19),
                   QualifyingEndDate = new DateTime(2024, 4, 20),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF25K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 69,
                   Name = "Bujumbura1 ITF25K",
                   Location = "Burundi",
                   StartDate = new DateTime(2024, 4, 21),
                   EndDate = new DateTime(2024, 4, 27),
                   QualifyingStartDate = new DateTime(2024, 4, 19),
                   QualifyingEndDate = new DateTime(2024, 4, 20),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF25K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 70,
                   Name = "Santa Margherita Di Pula3 ITF10K",
                   Location = "Italy",
                   StartDate = new DateTime(2024, 4, 21),
                   EndDate = new DateTime(2024, 4, 27),
                   QualifyingStartDate = new DateTime(2024, 4, 19),
                   QualifyingEndDate = new DateTime(2024, 4, 20),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF10K,
                   QualifyingRounds = 2
               },

               //Week 16
               new Tournament
               {
                   Id = 71,
                   Name = "Stuttgart Masters500",
                   Location = "Germany",
                   StartDate = new DateTime(2024, 4, 28),
                   EndDate = new DateTime(2024, 5, 4),
                   QualifyingStartDate = new DateTime(2024, 4, 26),
                   QualifyingEndDate = new DateTime(2024, 4, 27),
                   Surface = "Clay",
                   Category = TournamentCategory.Masters500,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 72,
                   Name = "Rouen Masters250",
                   Location = "France",
                   StartDate = new DateTime(2024, 4, 28),
                   EndDate = new DateTime(2024, 5, 4),
                   QualifyingStartDate = new DateTime(2024, 4, 26),
                   QualifyingEndDate = new DateTime(2024, 4, 27),
                   Surface = "Clay",
                   Category = TournamentCategory.Masters250,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 73,
                   Name = "Oeiras1 ITF100K",
                   Location = "Portugal",
                   StartDate = new DateTime(2024, 4, 28),
                   EndDate = new DateTime(2024, 5, 4),
                   QualifyingStartDate = new DateTime(2024, 4, 26),
                   QualifyingEndDate = new DateTime(2024, 4, 27),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF100K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 74,
                   Name = "Chiasso ITF50K",
                   Location = "Switzerland",
                   StartDate = new DateTime(2024, 4, 28),
                   EndDate = new DateTime(2024, 5, 4),
                   QualifyingStartDate = new DateTime(2024, 4, 26),
                   QualifyingEndDate = new DateTime(2024, 4, 27),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF50K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 75,
                   Name = "Bujumbura2 ITF25K",
                   Location = "Burundi",
                   StartDate = new DateTime(2024, 4, 28),
                   EndDate = new DateTime(2024, 5, 4),
                   QualifyingStartDate = new DateTime(2024, 4, 26),
                   QualifyingEndDate = new DateTime(2024, 4, 27),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF25K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 76,
                   Name = "Santa Margherita Di Pula4 ITF10K",
                   Location = "Italy",
                   StartDate = new DateTime(2024, 4, 28),
                   EndDate = new DateTime(2024, 5, 4),
                   QualifyingStartDate = new DateTime(2024, 4, 26),
                   QualifyingEndDate = new DateTime(2024, 4, 27),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF10K,
                   QualifyingRounds = 2
               },
               //Week 17
               new Tournament
               {
                   Id = 77,
                   Name = "Madrid Masters1000",
                   Location = "Spain",
                   StartDate = new DateTime(2024, 5, 5),
                   EndDate = new DateTime(2024, 5, 18), 
                   QualifyingStartDate = new DateTime(2024, 5, 3),
                   QualifyingEndDate = new DateTime(2024, 5, 4),
                   Surface = "Clay",
                   Category = TournamentCategory.Masters1000,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 78,
                   Name = "Oeiras2 ITF50K",
                   Location = "Portugal",
                   StartDate = new DateTime(2024, 5, 5),
                   EndDate = new DateTime(2024, 5, 11),
                   QualifyingStartDate = new DateTime(2024, 5, 3),
                   QualifyingEndDate = new DateTime(2024, 5, 4),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF50K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 79,
                   Name = "Lopota1 ITF25K",
                   Location = "Georgia",
                   StartDate = new DateTime(2024, 5, 5),
                   EndDate = new DateTime(2024, 5, 11),
                   QualifyingStartDate = new DateTime(2024, 5, 3),
                   QualifyingEndDate = new DateTime(2024, 5, 4),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF25K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 80,
                   Name = "Nottingham ITF25K",
                   Location = "Great Britain",
                   StartDate = new DateTime(2024, 5, 5),
                   EndDate = new DateTime(2024, 5, 11),
                   QualifyingStartDate = new DateTime(2024, 5, 3),
                   QualifyingEndDate = new DateTime(2024, 5, 4),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF25K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 81,
                   Name = "Shymkent ITF10K",
                   Location = "Kazakhstan",
                   StartDate = new DateTime(2024, 5, 5),
                   EndDate = new DateTime(2024, 5, 11),
                   QualifyingStartDate = new DateTime(2024, 5, 3),
                   QualifyingEndDate = new DateTime(2024, 5, 4),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF10K,
                   QualifyingRounds = 2
               },
               //Week 18
               new Tournament
               {
                   Id = 82,
                   Name = "Madrid Masters125",
                   Location = "Spain",
                   StartDate = new DateTime(2024, 5, 12),
                   EndDate = new DateTime(2024, 5, 18), 
                   QualifyingStartDate = new DateTime(2024, 5, 10),
                   QualifyingEndDate = new DateTime(2024, 5, 11),
                   Surface = "Clay",
                   Category = TournamentCategory.Challenger,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 83,
                   Name = "Saint-Malo ITF100K",
                   Location = "France",
                   StartDate = new DateTime(2024, 5, 12),
                   EndDate = new DateTime(2024, 5, 18),
                   QualifyingStartDate = new DateTime(2024, 5, 10),
                   QualifyingEndDate = new DateTime(2024, 5, 11),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF100K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 84,
                   Name = "Lleida ITF100K",
                   Location = "Spain",
                   StartDate = new DateTime(2024, 5, 12),
                   EndDate = new DateTime(2024, 5, 18),
                   QualifyingStartDate = new DateTime(2024, 5, 10),
                   QualifyingEndDate = new DateTime(2024, 5, 11),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF100K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 85,
                   Name = "Bonita Springs ITF50K",
                   Location = "USA",
                   StartDate = new DateTime(2024, 5, 12),
                   EndDate = new DateTime(2024, 5, 18),
                   QualifyingStartDate = new DateTime(2024, 5, 10),
                   QualifyingEndDate = new DateTime(2024, 5, 11),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF50K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 86,
                   Name = "Lopota2 ITF25K",
                   Location = "Georgia",
                   StartDate = new DateTime(2024, 5, 12),
                   EndDate = new DateTime(2024, 5, 18),
                   QualifyingStartDate = new DateTime(2024, 5, 10),
                   QualifyingEndDate = new DateTime(2024, 5, 11),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF25K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 87,
                   Name = "Varberg ITF10K",
                   Location = "Sweden",
                   StartDate = new DateTime(2024, 5, 12),
                   EndDate = new DateTime(2024, 5, 18),
                   QualifyingStartDate = new DateTime(2024, 5, 10),
                   QualifyingEndDate = new DateTime(2024, 5, 11),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF10K,
                   QualifyingRounds = 2
               },
               //Week 19
               new Tournament
               {
                   Id = 88,
                   Name = "Rome Masters1000",
                   Location = "Italy",
                   StartDate = new DateTime(2024, 5, 19),
                   EndDate = new DateTime(2024, 6, 1), 
                   QualifyingStartDate = new DateTime(2024, 5, 17),
                   QualifyingEndDate = new DateTime(2024, 5, 18),
                   Surface = "Clay",
                   Category = TournamentCategory.Masters1000,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 89,
                   Name = "Zephyrhills ITF50K",
                   Location = "USA",
                   StartDate = new DateTime(2024, 5, 19),
                   EndDate = new DateTime(2024, 5, 25),
                   QualifyingStartDate = new DateTime(2024, 5, 17),
                   QualifyingEndDate = new DateTime(2024, 5, 18),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF50K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 90,
                   Name = "Bastad ITF50K",
                   Location = "Sweden",
                   StartDate = new DateTime(2024, 5, 19),
                   EndDate = new DateTime(2024, 5, 25),
                   QualifyingStartDate = new DateTime(2024, 5, 17),
                   QualifyingEndDate = new DateTime(2024, 5, 18),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF50K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 91,
                   Name = "Kursumlijska Banja1 ITF10K",
                   Location = "Serbia",
                   StartDate = new DateTime(2024, 5, 19),
                   EndDate = new DateTime(2024, 5, 25),
                   QualifyingStartDate = new DateTime(2024, 5, 17),
                   QualifyingEndDate = new DateTime(2024, 5, 18),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF10K,
                   QualifyingRounds = 2
               },
               //Week 20
               new Tournament
               {
                   Id = 92,
                   Name = "Rome Masters125",
                   Location = "Italy",
                   StartDate = new DateTime(2024, 6, 2),
                   EndDate = new DateTime(2024, 6, 8), 
                   QualifyingStartDate = new DateTime(2024, 5, 31),
                   QualifyingEndDate = new DateTime(2024, 6, 1),
                   Surface = "Clay",
                   Category = TournamentCategory.Challenger,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 93,
                   Name = "Clarins ITF100K",
                   Location = "France",
                   StartDate = new DateTime(2024, 6, 2),
                   EndDate = new DateTime(2024, 6, 8),
                   QualifyingStartDate = new DateTime(2024, 5, 31),
                   QualifyingEndDate = new DateTime(2024, 6, 1),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF100K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 94,
                   Name = "Parma ITF100K",
                   Location = "Italy",
                   StartDate = new DateTime(2024, 6, 2),
                   EndDate = new DateTime(2024, 6, 8),
                   QualifyingStartDate = new DateTime(2024, 5, 31),
                   QualifyingEndDate = new DateTime(2024, 6, 1),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF100K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 95,
                   Name = "Villach ITF50K",
                   Location = "Austria",
                   StartDate = new DateTime(2024, 6, 2),
                   EndDate = new DateTime(2024, 6, 8),
                   QualifyingStartDate = new DateTime(2024, 5, 31),
                   QualifyingEndDate = new DateTime(2024, 6, 1),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF50K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 96,
                   Name = "Bethany Beach ITF50K",
                   Location = "USA",
                   StartDate = new DateTime(2024, 6, 2),
                   EndDate = new DateTime(2024, 6, 8),
                   QualifyingStartDate = new DateTime(2024, 5, 31),
                   QualifyingEndDate = new DateTime(2024, 6, 1),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF50K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 97,
                   Name = "Kursumlijska Banja2 ITF25K",
                   Location = "Serbia",
                   StartDate = new DateTime(2024, 6, 2),
                   EndDate = new DateTime(2024, 6, 8),
                   QualifyingStartDate = new DateTime(2024, 5, 31),
                   QualifyingEndDate = new DateTime(2024, 6, 1),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF25K,
                   QualifyingRounds = 3
               },
               //Week 21
               new Tournament
               {
                   Id = 98,
                   Name = "Strasbourg Masters500",
                   Location = "France",
                   StartDate = new DateTime(2024, 6, 9),
                   EndDate = new DateTime(2024, 6, 15),
                   QualifyingStartDate = new DateTime(2024, 6, 7),
                   QualifyingEndDate = new DateTime(2024, 6, 8),
                   Surface = "Clay",
                   Category = TournamentCategory.Masters500,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 99,
                   Name = "Grado ITF50K",
                   Location = "Italy",
                   StartDate = new DateTime(2024, 6, 9),
                   EndDate = new DateTime(2024, 6, 15),
                   QualifyingStartDate = new DateTime(2024, 6, 7),
                   QualifyingEndDate = new DateTime(2024, 6, 8),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF50K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 100,
                   Name = "Goyang ITF50K",
                   Location = "South Korea",
                   StartDate = new DateTime(2024, 6, 9),
                   EndDate = new DateTime(2024, 6, 15),
                   QualifyingStartDate = new DateTime(2024, 6, 7),
                   QualifyingEndDate = new DateTime(2024, 6, 8),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF50K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 101,
                   Name = "Annenheim ITF25K",
                   Location = "Austria",
                   StartDate = new DateTime(2024, 6, 9),
                   EndDate = new DateTime(2024, 6, 15),
                   QualifyingStartDate = new DateTime(2024, 6, 7),
                   QualifyingEndDate = new DateTime(2024, 6, 8),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF25K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 102,
                   Name = "Kursumlijska Banja3 ITF25K",
                   Location = "Serbia",
                   StartDate = new DateTime(2024, 6, 9),
                   EndDate = new DateTime(2024, 6, 15),
                   QualifyingStartDate = new DateTime(2024, 6, 7),
                   QualifyingEndDate = new DateTime(2024, 6, 8),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF25K,
                   QualifyingRounds = 2
               },
               //Week 22
               new Tournament
               {
                   Id = 103,
                   Name = "French Open GrandSlam",
                   Location = "France",
                   StartDate = new DateTime(2024, 6, 16),
                   EndDate = new DateTime(2024, 6, 29), // Durata de 2 săptămâni
                   QualifyingStartDate = new DateTime(2024, 6, 12),
                   QualifyingEndDate = new DateTime(2024, 6, 14),
                   Surface = "Clay",
                   Category = TournamentCategory.GrandSlam,
                   QualifyingRounds = 3
               },
               new Tournament
               {
                   Id = 104,
                   Name = "Troisdorf ITF50K",
                   Location = "Germany",
                   StartDate = new DateTime(2024, 6, 16),
                   EndDate = new DateTime(2024, 6, 22),
                   QualifyingStartDate = new DateTime(2024, 6, 13),
                   QualifyingEndDate = new DateTime(2024, 6, 14),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF50K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 105,
                   Name = "Changwon ITF25K",
                   Location = "South Korea",
                   StartDate = new DateTime(2024, 6, 16),
                   EndDate = new DateTime(2024, 6, 22),
                   QualifyingStartDate = new DateTime(2024, 6, 13),
                   QualifyingEndDate = new DateTime(2024, 6, 14),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF25K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 106,
                   Name = "Galati ITF10K",
                   Location = "Romania",
                   StartDate = new DateTime(2024, 6, 16),
                   EndDate = new DateTime(2024, 6, 22),
                   QualifyingStartDate = new DateTime(2024, 6, 13),
                   QualifyingEndDate = new DateTime(2024, 6, 14),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF10K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 107,
                   Name = "Monastir7 ITF10K",
                   Location = "Tunisia",
                   StartDate = new DateTime(2024, 6, 16),
                   EndDate = new DateTime(2024, 6, 22),
                   QualifyingStartDate = new DateTime(2024, 6, 13),
                   QualifyingEndDate = new DateTime(2024, 6, 14),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF10K,
                   QualifyingRounds = 2
               },
               //Week 23
               new Tournament
               {
                   Id = 108,
                   Name = "French Open Challenger",
                   Location = "France",
                   StartDate = new DateTime(2024, 6, 30),
                   EndDate = new DateTime(2024, 7, 6), // Continuare din săptămâna 22
                   QualifyingStartDate = new DateTime(2024, 6, 28),
                   QualifyingEndDate = new DateTime(2024, 6, 29),
                   Surface = "Clay",
                   Category = TournamentCategory.Challenger,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 109,
                   Name = "Makarska ITF100K",
                   Location = "Croatia",
                   StartDate = new DateTime(2024, 6, 30),
                   EndDate = new DateTime(2024, 7, 6),
                   QualifyingStartDate = new DateTime(2024, 6, 28),
                   QualifyingEndDate = new DateTime(2024, 6, 29),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF100K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 110,
                   Name = "Bari ITF100K",
                   Location = "Italy",
                   StartDate = new DateTime(2024, 6, 30),
                   EndDate = new DateTime(2024, 7, 6),
                   QualifyingStartDate = new DateTime(2024, 6, 28),
                   QualifyingEndDate = new DateTime(2024, 6, 29),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF100K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 111,
                   Name = "Surbiton ITF50K",
                   Location = "Great Britain",
                   StartDate = new DateTime(2024, 6, 30),
                   EndDate = new DateTime(2024, 7, 6),
                   QualifyingStartDate = new DateTime(2024, 6, 28),
                   QualifyingEndDate = new DateTime(2024, 6, 29),
                   Surface = "Grass",
                   Category = TournamentCategory.ITF50K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 112,
                   Name = "Sumter ITF25K",
                   Location = "USA",
                   StartDate = new DateTime(2024, 6, 30),
                   EndDate = new DateTime(2024, 7, 6),
                   QualifyingStartDate = new DateTime(2024, 6, 28),
                   QualifyingEndDate = new DateTime(2024, 6, 29),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF25K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 113,
                   Name = "Monastir8 ITF10K",
                   Location = "Tunisia",
                   StartDate = new DateTime(2024, 6, 30),
                   EndDate = new DateTime(2024, 7, 6),
                   QualifyingStartDate = new DateTime(2024, 6, 28),
                   QualifyingEndDate = new DateTime(2024, 6, 29),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF10K,
                   QualifyingRounds = 2
               },
               //Week 24
               new Tournament
               {
                   Id = 114,
                   Name = "Libema Open Masters250",
                   Location = "Netherlands",
                   StartDate = new DateTime(2024, 7, 7),
                   EndDate = new DateTime(2024, 7, 13),
                   QualifyingStartDate = new DateTime(2024, 7, 5),
                   QualifyingEndDate = new DateTime(2024, 7, 6),
                   Surface = "Grass",
                   Category = TournamentCategory.Masters250,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 115,
                   Name = "Nottingham Open Masters250",
                   Location = "Great Britain",
                   StartDate = new DateTime(2024, 7, 7),
                   EndDate = new DateTime(2024, 7, 13),
                   QualifyingStartDate = new DateTime(2024, 7, 5),
                   QualifyingEndDate = new DateTime(2024, 7, 6),
                   Surface = "Grass",
                   Category = TournamentCategory.Masters250,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 116,
                   Name = "Valencia ITF100K",
                   Location = "Spain",
                   StartDate = new DateTime(2024, 7, 7),
                   EndDate = new DateTime(2024, 7, 13),
                   QualifyingStartDate = new DateTime(2024, 7, 5),
                   QualifyingEndDate = new DateTime(2024, 7, 6),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF100K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 117,
                   Name = "Gdansk ITF25K",
                   Location = "Poland",
                   StartDate = new DateTime(2024, 7, 7),
                   EndDate = new DateTime(2024, 7, 13),
                   QualifyingStartDate = new DateTime(2024, 7, 5),
                   QualifyingEndDate = new DateTime(2024, 7, 6),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF25K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 118,
                   Name = "San Diego ITF25K",
                   Location = "USA",
                   StartDate = new DateTime(2024, 7, 7),
                   EndDate = new DateTime(2024, 7, 13),
                   QualifyingStartDate = new DateTime(2024, 7, 5),
                   QualifyingEndDate = new DateTime(2024, 7, 6),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF25K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 119,
                   Name = "Monastir9 ITF10K",
                   Location = "Tunisia",
                   StartDate = new DateTime(2024, 7, 7),
                   EndDate = new DateTime(2024, 7, 13),
                   QualifyingStartDate = new DateTime(2024, 7, 5),
                   QualifyingEndDate = new DateTime(2024, 7, 6),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF10K,
                   QualifyingRounds = 2
               },
               //Week 25
               new Tournament
               {
                   Id = 120,
                   Name = "Berlin Masters500",
                   Location = "Germany",
                   StartDate = new DateTime(2024, 7, 14),
                   EndDate = new DateTime(2024, 7, 20),
                   QualifyingStartDate = new DateTime(2024, 7, 12),
                   QualifyingEndDate = new DateTime(2024, 7, 13),
                   Surface = "Grass",
                   Category = TournamentCategory.Masters500,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 121,
                   Name = "Birmingham Masters250",
                   Location = "Great Britain",
                   StartDate = new DateTime(2024, 7, 14),
                   EndDate = new DateTime(2024, 7, 20),
                   QualifyingStartDate = new DateTime(2024, 7, 12),
                   QualifyingEndDate = new DateTime(2024, 7, 13),
                   Surface = "Grass",
                   Category = TournamentCategory.Masters250,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 122,
                   Name = "Ikley ITF100K",
                   Location = "Great Britain",
                   StartDate = new DateTime(2024, 7, 14),
                   EndDate = new DateTime(2024, 7, 20),
                   QualifyingStartDate = new DateTime(2024, 7, 12),
                   QualifyingEndDate = new DateTime(2024, 7, 13),
                   Surface = "Grass",
                   Category = TournamentCategory.ITF100K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 123,
                   Name = "Gaiba ITF100K",
                   Location = "Italy",
                   StartDate = new DateTime(2024, 7, 14),
                   EndDate = new DateTime(2024, 7, 20),
                   QualifyingStartDate = new DateTime(2024, 7, 12),
                   QualifyingEndDate = new DateTime(2024, 7, 13),
                   Surface = "Grass",
                   Category = TournamentCategory.ITF100K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 125,
                   Name = "Monastir10 ITF10K",
                   Location = "Tunisia",
                   StartDate = new DateTime(2024, 7, 14),
                   EndDate = new DateTime(2024, 7, 20),
                   QualifyingStartDate = new DateTime(2024, 7, 12),
                   QualifyingEndDate = new DateTime(2024, 7, 13),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF10K,
                   QualifyingRounds = 2
               },
               //Week 26
               new Tournament
               {
                   Id = 126,
                   Name = "Bad Homburg Masters500",
                   Location = "Germany",
                   StartDate = new DateTime(2024, 6, 24),
                   EndDate = new DateTime(2024, 6, 30),
                   QualifyingStartDate = new DateTime(2024, 6, 22),
                   QualifyingEndDate = new DateTime(2024, 6, 23),
                   Surface = "Grass",
                   Category = TournamentCategory.Masters500,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 127,
                   Name = "Eastbourne Masters500",
                   Location = "Great Britain",
                   StartDate = new DateTime(2024, 6, 24),
                   EndDate = new DateTime(2024, 6, 30),
                   QualifyingStartDate = new DateTime(2024, 6, 22),
                   QualifyingEndDate = new DateTime(2024, 6, 23),
                   Surface = "Grass",
                   Category = TournamentCategory.Masters500,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 128,
                   Name = "Stare Splavy ITF50K",
                   Location = "Czechia",
                   StartDate = new DateTime(2024, 6, 24),
                   EndDate = new DateTime(2024, 6, 30),
                   QualifyingStartDate = new DateTime(2024, 6, 22),
                   QualifyingEndDate = new DateTime(2024, 6, 23),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF50K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 129,
                   Name = "Taipei ITF25K",
                   Location = "Taipei",
                   StartDate = new DateTime(2024, 6, 24),
                   EndDate = new DateTime(2024, 6, 30),
                   QualifyingStartDate = new DateTime(2024, 6, 22),
                   QualifyingEndDate = new DateTime(2024, 6, 23),
                   Surface = "Hard",
                   Category = TournamentCategory.ITF25K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 130,
                   Name = "Tianjin ITF10K",
                   Location = "China",
                   StartDate = new DateTime(2024, 6, 24),
                   EndDate = new DateTime(2024, 6, 30),
                   QualifyingStartDate = new DateTime(2024, 6, 22),
                   QualifyingEndDate = new DateTime(2024, 6, 23),
                   Surface = "Hard",
                   Category = TournamentCategory.ITF10K,
                   QualifyingRounds = 2
               },
               //Week 27
               new Tournament
               {
                   Id = 131,
                   Name = "Wimbledon GrandSlam",
                   Location = "Great Britain",
                   StartDate = new DateTime(2024, 7, 1),
                   EndDate = new DateTime(2024, 7, 14),
                   QualifyingStartDate = new DateTime(2024, 6, 26),
                   QualifyingEndDate = new DateTime(2024, 6, 28),
                   Surface = "Grass",
                   Category = TournamentCategory.GrandSlam,
                   QualifyingRounds = 3
               },
               new Tournament
               {
                   Id = 132,
                   Name = "Stuttgart-Vaihingen ITF50K",
                   Location = "Germany",
                   StartDate = new DateTime(2024, 7, 1),
                   EndDate = new DateTime(2024, 7, 7),
                   QualifyingStartDate = new DateTime(2024, 6, 29),
                   QualifyingEndDate = new DateTime(2024, 6, 30),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF50K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 133,
                   Name = "Hong Kong ITF25K",
                   Location = "Hong Kong",
                   StartDate = new DateTime(2024, 7, 1),
                   EndDate = new DateTime(2024, 7, 7),
                   QualifyingStartDate = new DateTime(2024, 6, 29),
                   QualifyingEndDate = new DateTime(2024, 6, 30),
                   Surface = "Hard",
                   Category = TournamentCategory.ITF25K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 134,
                   Name = "Amstelveen ITF10K",
                   Location = "Netherlands",
                   StartDate = new DateTime(2024, 7, 1),
                   EndDate = new DateTime(2024, 7, 7),
                   QualifyingStartDate = new DateTime(2024, 6, 29),
                   QualifyingEndDate = new DateTime(2024, 6, 30),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF10K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 135,
                   Name = "Mogyorod ITF10K",
                   Location = "Hungary",
                   StartDate = new DateTime(2024, 7, 1),
                   EndDate = new DateTime(2024, 7, 7),
                   QualifyingStartDate = new DateTime(2024, 6, 29),
                   QualifyingEndDate = new DateTime(2024, 6, 30),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF10K,
                   QualifyingRounds = 2
               },
               //Week 28
               new Tournament
               {
                   Id = 136,
                   Name = "Wimbledon 125k",
                   Location = "Great Britain",
                   StartDate = new DateTime(2024, 7, 7),
                   EndDate = new DateTime(2024, 7, 14),
                   QualifyingStartDate = new DateTime(2024, 7, 5),
                   QualifyingEndDate = new DateTime(2024, 7, 6),
                   Surface = "Grass",
                   Category = TournamentCategory.Challenger,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 137,
                   Name = "Bastad ITF100K",
                   Location = "Sweden",
                   StartDate = new DateTime(2024, 7, 7),
                   EndDate = new DateTime(2024, 7, 13),
                   QualifyingStartDate = new DateTime(2024, 7, 5),
                   QualifyingEndDate = new DateTime(2024, 7, 6),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF100K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 138,
                   Name = "Contrexeville ITF100K",
                   Location = "France",
                   StartDate = new DateTime(2024, 7, 7),
                   EndDate = new DateTime(2024, 7, 13),
                   QualifyingStartDate = new DateTime(2024, 7, 5),
                   QualifyingEndDate = new DateTime(2024, 7, 6),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF100K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 139,
                   Name = "The Hague ITF50K",
                   Location = "Netherlands",
                   StartDate = new DateTime(2024, 7, 7),
                   EndDate = new DateTime(2024, 7, 13),
                   QualifyingStartDate = new DateTime(2024, 7, 5),
                   QualifyingEndDate = new DateTime(2024, 7, 6),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF50K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 140,
                   Name = "Nakhon Si Thammarat ITF25K",
                   Location = "Thailand",
                   StartDate = new DateTime(2024, 7, 7),
                   EndDate = new DateTime(2024, 7, 13),
                   QualifyingStartDate = new DateTime(2024, 7, 5),
                   QualifyingEndDate = new DateTime(2024, 7, 6),
                   Surface = "Hard",
                   Category = TournamentCategory.ITF25K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 141,
                   Name = "Grodzisk Mazowiecki ITF10K",
                   Location = "Poland",
                   StartDate = new DateTime(2024, 7, 7),
                   EndDate = new DateTime(2024, 7, 13),
                   QualifyingStartDate = new DateTime(2024, 7, 5),
                   QualifyingEndDate = new DateTime(2024, 7, 6),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF10K,
                   QualifyingRounds = 2
               },
               //Week 29
               new Tournament
               {
                   Id = 142,
                   Name = "Palermo Masters250",
                   Location = "Italy",
                   StartDate = new DateTime(2024, 7, 14),
                   EndDate = new DateTime(2024, 7, 20),
                   QualifyingStartDate = new DateTime(2024, 7, 12),
                   QualifyingEndDate = new DateTime(2024, 7, 13),
                   Surface = "Clay",
                   Category = TournamentCategory.Masters250,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 143,
                   Name = "Budapest Masters250",
                   Location = "Hungary",
                   StartDate = new DateTime(2024, 7, 14),
                   EndDate = new DateTime(2024, 7, 20),
                   QualifyingStartDate = new DateTime(2024, 7, 12),
                   QualifyingEndDate = new DateTime(2024, 7, 13),
                   Surface = "Clay",
                   Category = TournamentCategory.Masters250,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 144,
                   Name = "Granby ITF50K",
                   Location = "Canada",
                   StartDate = new DateTime(2024, 7, 14),
                   EndDate = new DateTime(2024, 7, 20),
                   QualifyingStartDate = new DateTime(2024, 7, 12),
                   QualifyingEndDate = new DateTime(2024, 7, 13),
                   Surface = "Hard",
                   Category = TournamentCategory.ITF50K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 145,
                   Name = "Nottingham ITF50K",
                   Location = "Great Britain",
                   StartDate = new DateTime(2024, 7, 14),
                   EndDate = new DateTime(2024, 7, 20),
                   QualifyingStartDate = new DateTime(2024, 7, 12),
                   QualifyingEndDate = new DateTime(2024, 7, 13),
                   Surface = "Grass",
                   Category = TournamentCategory.ITF50K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 146,
                   Name = "Casablanca1 ITF10K",
                   Location = "Morocco",
                   StartDate = new DateTime(2024, 7, 14),
                   EndDate = new DateTime(2024, 7, 20),
                   QualifyingStartDate = new DateTime(2024, 7, 12),
                   QualifyingEndDate = new DateTime(2024, 7, 13),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF10K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 147,
                   Name = "Timisoara ITF10K",
                   Location = "Romania",
                   StartDate = new DateTime(2024, 7, 14),
                   EndDate = new DateTime(2024, 7, 20),
                   QualifyingStartDate = new DateTime(2024, 7, 12),
                   QualifyingEndDate = new DateTime(2024, 7, 13),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF10K,
                   QualifyingRounds = 2
               },
               //Week 30
               new Tournament
               {
                   Id = 148,
                   Name = "Iasi Masters250",
                   Location = "Romania",
                   StartDate = new DateTime(2024, 7, 21),
                   EndDate = new DateTime(2024, 7, 27),
                   QualifyingStartDate = new DateTime(2024, 7, 19),
                   QualifyingEndDate = new DateTime(2024, 7, 20),
                   Surface = "Clay",
                   Category = TournamentCategory.Masters250,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 149,
                   Name = "Prague Masters250",
                   Location = "Czechia",
                   StartDate = new DateTime(2024, 7, 21),
                   EndDate = new DateTime(2024, 7, 27),
                   QualifyingStartDate = new DateTime(2024, 7, 19),
                   QualifyingEndDate = new DateTime(2024, 7, 20),
                   Surface = "Clay",
                   Category = TournamentCategory.Masters250,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 150,
                   Name = "Warsaw ITF100K",
                   Location = "Poland",
                   StartDate = new DateTime(2024, 7, 21),
                   EndDate = new DateTime(2024, 7, 27),
                   QualifyingStartDate = new DateTime(2024, 7, 19),
                   QualifyingEndDate = new DateTime(2024, 7, 20),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF100K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 151,
                   Name = "Dallas ITF50K",
                   Location = "USA",
                   StartDate = new DateTime(2024, 7, 21),
                   EndDate = new DateTime(2024, 7, 27),
                   QualifyingStartDate = new DateTime(2024, 7, 19),
                   QualifyingEndDate = new DateTime(2024, 7, 20),
                   Surface = "Hard Indoor",
                   Category = TournamentCategory.ITF50K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 152,
                   Name = "Casablanca2 ITF25K",
                   Location = "Morocco",
                   StartDate = new DateTime(2024, 7, 21),
                   EndDate = new DateTime(2024, 7, 27),
                   QualifyingStartDate = new DateTime(2024, 7, 19),
                   QualifyingEndDate = new DateTime(2024, 7, 20),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF25K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 153,
                   Name = "Astana ITF10K",
                   Location = "Kazakhstan",
                   StartDate = new DateTime(2024, 7, 21),
                   EndDate = new DateTime(2024, 7, 27),
                   QualifyingStartDate = new DateTime(2024, 7, 19),
                   QualifyingEndDate = new DateTime(2024, 7, 20),
                   Surface = "Hard",
                   Category = TournamentCategory.ITF10K,
                   QualifyingRounds = 2
               },
               //Week 31
               new Tournament
               {
                   Id = 154,
                   Name = "Washington Masters500",
                   Location = "USA",
                   StartDate = new DateTime(2024, 7, 28),
                   EndDate = new DateTime(2024, 8, 3),
                   QualifyingStartDate = new DateTime(2024, 7, 26),
                   QualifyingEndDate = new DateTime(2024, 7, 27),
                   Surface = "Hard",
                   Category = TournamentCategory.Masters500,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 155,
                   Name = "Lexington ITF50K",
                   Location = "USA",
                   StartDate = new DateTime(2024, 7, 28),
                   EndDate = new DateTime(2024, 8, 3),
                   QualifyingStartDate = new DateTime(2024, 7, 26),
                   QualifyingEndDate = new DateTime(2024, 7, 27),
                   Surface = "Hard",
                   Category = TournamentCategory.ITF50K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 156,
                   Name = "Mohammedia ITF25K",
                   Location = "Morocco",
                   StartDate = new DateTime(2024, 7, 28),
                   EndDate = new DateTime(2024, 8, 3),
                   QualifyingStartDate = new DateTime(2024, 7, 26),
                   QualifyingEndDate = new DateTime(2024, 7, 27),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF25K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 157,
                   Name = "Koge ITF25K",
                   Location = "Denmark",
                   StartDate = new DateTime(2024, 7, 28),
                   EndDate = new DateTime(2024, 8, 3),
                   QualifyingStartDate = new DateTime(2024, 7, 26),
                   QualifyingEndDate = new DateTime(2024, 7, 27),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF25K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 158,
                   Name = "Ust-Kamenogorsk ITF10K",
                   Location = "Kazakhstan",
                   StartDate = new DateTime(2024, 7, 28),
                   EndDate = new DateTime(2024, 8, 3),
                   QualifyingStartDate = new DateTime(2024, 7, 26),
                   QualifyingEndDate = new DateTime(2024, 7, 27),
                   Surface = "Hard",
                   Category = TournamentCategory.ITF10K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 159,
                   Name = "Brasov ITF10K",
                   Location = "Romania",
                   StartDate = new DateTime(2024, 7, 28),
                   EndDate = new DateTime(2024, 8, 3),
                   QualifyingStartDate = new DateTime(2024, 7, 26),
                   QualifyingEndDate = new DateTime(2024, 7, 27),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF10K,
                   QualifyingRounds = 2
               },
               //Week 32
               new Tournament
               {
                   Id = 160,
                   Name = "Canadian Open Masters1000",
                   Location = "Canada",
                   StartDate = new DateTime(2024, 8, 4),
                   EndDate = new DateTime(2024, 8, 10),
                   QualifyingStartDate = new DateTime(2024, 8, 2),
                   QualifyingEndDate = new DateTime(2024, 8, 3),
                   Surface = "Hard",
                   Category = TournamentCategory.Masters1000,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 161,
                   Name = "Hamburg ITF100K",
                   Location = "Germany",
                   StartDate = new DateTime(2024, 8, 4),
                   EndDate = new DateTime(2024, 8, 10),
                   QualifyingStartDate = new DateTime(2024, 8, 2),
                   QualifyingEndDate = new DateTime(2024, 8, 3),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF100K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 162,
                   Name = "Landisville ITF50K",
                   Location = "USA",
                   StartDate = new DateTime(2024, 8, 4),
                   EndDate = new DateTime(2024, 8, 10),
                   QualifyingStartDate = new DateTime(2024, 8, 2),
                   QualifyingEndDate = new DateTime(2024, 8, 3),
                   Surface = "Hard",
                   Category = TournamentCategory.ITF50K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 163,
                   Name = "Koksijde ITF25K",
                   Location = "Belgium",
                   StartDate = new DateTime(2024, 8, 4),
                   EndDate = new DateTime(2024, 8, 10),
                   QualifyingStartDate = new DateTime(2024, 8, 2),
                   QualifyingEndDate = new DateTime(2024, 8, 3),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF25K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 164,
                   Name = "Roehampton ITF25K",
                   Location = "Great Britain",
                   StartDate = new DateTime(2024, 8, 4),
                   EndDate = new DateTime(2024, 8, 10),
                   QualifyingStartDate = new DateTime(2024, 8, 2),
                   QualifyingEndDate = new DateTime(2024, 8, 3),
                   Surface = "Hard Indoor",
                   Category = TournamentCategory.ITF25K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 165,
                   Name = "Dublin ITF10K",
                   Location = "Ireland",
                   StartDate = new DateTime(2024, 8, 4),
                   EndDate = new DateTime(2024, 8, 10),
                   QualifyingStartDate = new DateTime(2024, 8, 2),
                   QualifyingEndDate = new DateTime(2024, 8, 3),
                   Surface = "Carpet",
                   Category = TournamentCategory.ITF10K,
                   QualifyingRounds = 2
               },
               //Week 33
               new Tournament
               {
                   Id = 166,
                   Name = "Cincinnati Masters1000",
                   Location = "USA",
                   StartDate = new DateTime(2024, 8, 11),
                   EndDate = new DateTime(2024, 8, 17),
                   QualifyingStartDate = new DateTime(2024, 8, 9),
                   QualifyingEndDate = new DateTime(2024, 8, 10),
                   Surface = "Hard",
                   Category = TournamentCategory.Masters1000,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 167,
                   Name = "Seoul ITF100K",
                   Location = "South Korea",
                   StartDate = new DateTime(2024, 8, 11),
                   EndDate = new DateTime(2024, 8, 17),
                   QualifyingStartDate = new DateTime(2024, 8, 9),
                   QualifyingEndDate = new DateTime(2024, 8, 10),
                   Surface = "Hard",
                   Category = TournamentCategory.ITF100K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 168,
                   Name = "Newport ITF50K",
                   Location = "USA",
                   StartDate = new DateTime(2024, 8, 11),
                   EndDate = new DateTime(2024, 8, 17),
                   QualifyingStartDate = new DateTime(2024, 8, 9),
                   QualifyingEndDate = new DateTime(2024, 8, 10),
                   Surface = "Hard Indoor",
                   Category = TournamentCategory.ITF50K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 169,
                   Name = "Moscow ITF25K",
                   Location = "Russia",
                   StartDate = new DateTime(2024, 8, 11),
                   EndDate = new DateTime(2024, 8, 17),
                   QualifyingStartDate = new DateTime(2024, 8, 9),
                   QualifyingEndDate = new DateTime(2024, 8, 10),
                   Surface = "Hard",
                   Category = TournamentCategory.ITF25K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 170,
                   Name = "San Juan ITF25K",
                   Location = "Puerto Rico",
                   StartDate = new DateTime(2024, 8, 11),
                   EndDate = new DateTime(2024, 8, 17),
                   QualifyingStartDate = new DateTime(2024, 8, 9),
                   QualifyingEndDate = new DateTime(2024, 8, 10),
                   Surface = "Hard",
                   Category = TournamentCategory.ITF25K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 171,
                   Name = "Tunis ITF10K",
                   Location = "Tunisia",
                   StartDate = new DateTime(2024, 8, 11),
                   EndDate = new DateTime(2024, 8, 17),
                   QualifyingStartDate = new DateTime(2024, 8, 9),
                   QualifyingEndDate = new DateTime(2024, 8, 10),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF10K,
                   QualifyingRounds = 2
               },
               //Week 34
               new Tournament
               {
                   Id = 172,
                   Name = "US Open Grand Slam",
                   Location = "USA",
                   StartDate = new DateTime(2024, 8, 18),
                   EndDate = new DateTime(2024, 8, 31),
                   QualifyingStartDate = new DateTime(2024, 8, 15),
                   QualifyingEndDate = new DateTime(2024, 8, 17),
                   Surface = "Hard",
                   Category = TournamentCategory.GrandSlam,
                   QualifyingRounds = 3
               },
               new Tournament
               {
                   Id = 173,
                   Name = "Los Angeles ITF100K",
                   Location = "USA",
                   StartDate = new DateTime(2024, 8, 18),
                   EndDate = new DateTime(2024, 8, 24),
                   QualifyingStartDate = new DateTime(2024, 8, 16),
                   QualifyingEndDate = new DateTime(2024, 8, 17),
                   Surface = "Hard",
                   Category = TournamentCategory.ITF100K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 174,
                   Name = "Gstaad ITF50K",
                   Location = "Switzerland",
                   StartDate = new DateTime(2024, 8, 18),
                   EndDate = new DateTime(2024, 8, 24),
                   QualifyingStartDate = new DateTime(2024, 8, 16),
                   QualifyingEndDate = new DateTime(2024, 8, 17),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF50K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 175,
                   Name = "Indian Wells ITF25K",
                   Location = "USA",
                   StartDate = new DateTime(2024, 8, 18),
                   EndDate = new DateTime(2024, 8, 24),
                   QualifyingStartDate = new DateTime(2024, 8, 16),
                   QualifyingEndDate = new DateTime(2024, 8, 17),
                   Surface = "Hard",
                   Category = TournamentCategory.ITF25K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 176,
                   Name = "Stockholm ITF25K",
                   Location = "Sweden",
                   StartDate = new DateTime(2024, 8, 18),
                   EndDate = new DateTime(2024, 8, 24),
                   QualifyingStartDate = new DateTime(2024, 8, 16),
                   QualifyingEndDate = new DateTime(2024, 8, 17),
                   Surface = "Hard",
                   Category = TournamentCategory.ITF25K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 177,
                   Name = "Tbilisi ITF10K",
                   Location = "Georgia",
                   StartDate = new DateTime(2024, 8, 18),
                   EndDate = new DateTime(2024, 8, 24),
                   QualifyingStartDate = new DateTime(2024, 8, 16),
                   QualifyingEndDate = new DateTime(2024, 8, 17),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF10K,
                   QualifyingRounds = 2
               },
               //Week 35
               new Tournament
               {
                   Id = 178,
                   Name = "Czech Open ITF100K",
                   Location = "Czech Republic",
                   StartDate = new DateTime(2024, 8, 25),
                   EndDate = new DateTime(2024, 8, 31),
                   QualifyingStartDate = new DateTime(2024, 8, 23),
                   QualifyingEndDate = new DateTime(2024, 8, 24),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF100K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 179,
                   Name = "Tokyo ITF50K",
                   Location = "Japan",
                   StartDate = new DateTime(2024, 8, 25),
                   EndDate = new DateTime(2024, 8, 31),
                   QualifyingStartDate = new DateTime(2024, 8, 23),
                   QualifyingEndDate = new DateTime(2024, 8, 24),
                   Surface = "Hard",
                   Category = TournamentCategory.ITF50K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 180,
                   Name = "Vienna ITF25K",
                   Location = "Austria",
                   StartDate = new DateTime(2024, 8, 25),
                   EndDate = new DateTime(2024, 8, 31),
                   QualifyingStartDate = new DateTime(2024, 8, 23),
                   QualifyingEndDate = new DateTime(2024, 8, 24),
                   Surface = "Hard",
                   Category = TournamentCategory.ITF25K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 181,
                   Name = "London ITF25K",
                   Location = "United Kingdom",
                   StartDate = new DateTime(2024, 8, 25),
                   EndDate = new DateTime(2024, 8, 31),
                   QualifyingStartDate = new DateTime(2024, 8, 23),
                   QualifyingEndDate = new DateTime(2024, 8, 24),
                   Surface = "Hard Indoor",
                   Category = TournamentCategory.ITF25K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 182,
                   Name = "Tashkent ITF10K",
                   Location = "Uzbekistan",
                   StartDate = new DateTime(2024, 8, 25),
                   EndDate = new DateTime(2024, 8, 31),
                   QualifyingStartDate = new DateTime(2024, 8, 23),
                   QualifyingEndDate = new DateTime(2024, 8, 24),
                   Surface = "Hard",
                   Category = TournamentCategory.ITF10K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 183,
                   Name = "Wuhan ITF10K",
                   Location = "China",
                   StartDate = new DateTime(2024, 8, 25),
                   EndDate = new DateTime(2024, 8, 31),
                   QualifyingStartDate = new DateTime(2024, 8, 23),
                   QualifyingEndDate = new DateTime(2024, 8, 24),
                   Surface = "Hard",
                   Category = TournamentCategory.ITF10K,
                   QualifyingRounds = 2
               },
               //Week 36
               new Tournament
               {
                   Id = 184,
                   Name = "US Open 125k",
                   Location = "USA",
                   StartDate = new DateTime(2024, 9, 1),
                   EndDate = new DateTime(2024, 9, 8),
                   QualifyingStartDate = new DateTime(2024, 8, 30),
                   QualifyingEndDate = new DateTime(2024, 8, 31),
                   Surface = "Hard",
                   Category = TournamentCategory.Challenger,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 185,
                   Name = "Guadalajara Open ITF100K",
                   Location = "Mexico",
                   StartDate = new DateTime(2024, 9, 1),
                   EndDate = new DateTime(2024, 9, 7),
                   QualifyingStartDate = new DateTime(2024, 8, 30),
                   QualifyingEndDate = new DateTime(2024, 8, 31),
                   Surface = "Hard",
                   Category = TournamentCategory.ITF100K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 186,
                   Name = "Montreux ITF100K",
                   Location = "Switzerland",
                   StartDate = new DateTime(2024, 9, 1),
                   EndDate = new DateTime(2024, 9, 7),
                   QualifyingStartDate = new DateTime(2024, 8, 30),
                   QualifyingEndDate = new DateTime(2024, 8, 31),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF100K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 187,
                   Name = "Punta Cana ITF25K",
                   Location = "Dominican Republic",
                   StartDate = new DateTime(2024, 9, 1),
                   EndDate = new DateTime(2024, 9, 7),
                   QualifyingStartDate = new DateTime(2024, 8, 30),
                   QualifyingEndDate = new DateTime(2024, 8, 31),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF25K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 188,
                   Name = "Piracicaba ITF10K",
                   Location = "Brazil",
                   StartDate = new DateTime(2024, 9, 1),
                   EndDate = new DateTime(2024, 9, 7),
                   QualifyingStartDate = new DateTime(2024, 8, 30),
                   QualifyingEndDate = new DateTime(2024, 8, 31),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF10K,
                   QualifyingRounds = 2
               },
               //Week 37
               new Tournament
               {
                   Id = 189,
                   Name = "Guadalajara Open Masters500",
                   Location = "Mexico",
                   StartDate = new DateTime(2024, 9, 22),
                   EndDate = new DateTime(2024, 9, 28),
                   QualifyingStartDate = new DateTime(2024, 9, 20),
                   QualifyingEndDate = new DateTime(2024, 9, 21),
                   Surface = "Hard",
                   Category = TournamentCategory.Masters500,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 190,
                   Name = "Monastir Masters250",
                   Location = "Tunisia",
                   StartDate = new DateTime(2024, 9, 22),
                   EndDate = new DateTime(2024, 9, 28),
                   QualifyingStartDate = new DateTime(2024, 9, 20),
                   QualifyingEndDate = new DateTime(2024, 9, 21),
                   Surface = "Hard",
                   Category = TournamentCategory.Masters250,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 191,
                   Name = "Tiriac Open ITF100K",
                   Location = "Romania",
                   StartDate = new DateTime(2024, 9, 22),
                   EndDate = new DateTime(2024, 9, 28),
                   QualifyingStartDate = new DateTime(2024, 9, 20),
                   QualifyingEndDate = new DateTime(2024, 9, 21),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF100K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 192,
                   Name = "Zavarovalnica Open ITF100K",
                   Location = "Slovenia",
                   StartDate = new DateTime(2024, 9, 22),
                   EndDate = new DateTime(2024, 9, 28),
                   QualifyingStartDate = new DateTime(2024, 9, 20),
                   QualifyingEndDate = new DateTime(2024, 9, 21),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF100K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 193,
                   Name = "Punta Cana2 ITF25K",
                   Location = "Dominican Republic",
                   StartDate = new DateTime(2024, 9, 22),
                   EndDate = new DateTime(2024, 9, 28),
                   QualifyingStartDate = new DateTime(2024, 9, 20),
                   QualifyingEndDate = new DateTime(2024, 9, 21),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF25K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 194,
                   Name = "Guiyang ITF25K",
                   Location = "China",
                   StartDate = new DateTime(2024, 9, 22),
                   EndDate = new DateTime(2024, 9, 28),
                   QualifyingStartDate = new DateTime(2024, 9, 20),
                   QualifyingEndDate = new DateTime(2024, 9, 21),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF25K,
                   QualifyingRounds = 2
               },
               //Week 38
               new Tournament
               {
                   Id = 195,
                   Name = "Korea Open Masters500",
                   Location = "South Korea",
                   StartDate = new DateTime(2024, 9, 29),
                   EndDate = new DateTime(2024, 10, 5),
                   QualifyingStartDate = new DateTime(2024, 9, 27),
                   QualifyingEndDate = new DateTime(2024, 9, 28),
                   Surface = "Hard",
                   Category = TournamentCategory.Masters500,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 196,
                   Name = "Hua Hin2 Masters250",
                   Location = "Thailand",
                   StartDate = new DateTime(2024, 9, 29),
                   EndDate = new DateTime(2024, 10, 5),
                   QualifyingStartDate = new DateTime(2024, 9, 27),
                   QualifyingEndDate = new DateTime(2024, 9, 28),
                   Surface = "Hard",
                   Category = TournamentCategory.Masters250,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 197,
                   Name = "Pazardzhik ITF50K",
                   Location = "Bulgaria",
                   StartDate = new DateTime(2024, 9, 29),
                   EndDate = new DateTime(2024, 10, 5),
                   QualifyingStartDate = new DateTime(2024, 9, 27),
                   QualifyingEndDate = new DateTime(2024, 9, 28),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF50K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 198,
                   Name = "Fuzhou ITF50K",
                   Location = "China",
                   StartDate = new DateTime(2024, 9, 29),
                   EndDate = new DateTime(2024, 10, 5),
                   QualifyingStartDate = new DateTime(2024, 9, 27),
                   QualifyingEndDate = new DateTime(2024, 9, 28),
                   Surface = "Hard",
                   Category = TournamentCategory.ITF50K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 199,
                   Name = "Kyoto ITF10K",
                   Location = "Japan",
                   StartDate = new DateTime(2024, 9, 29),
                   EndDate = new DateTime(2024, 10, 5),
                   QualifyingStartDate = new DateTime(2024, 9, 27),
                   QualifyingEndDate = new DateTime(2024, 9, 28),
                   Surface = "Hard",
                   Category = TournamentCategory.ITF10K,
                   QualifyingRounds = 2
               },

               //Week 39
               new Tournament
               {
                   Id = 200,
                   Name = "China Open Masters1000",
                   Location = "China",
                   StartDate = new DateTime(2024, 10, 6),
                   EndDate = new DateTime(2024, 10, 12),
                   QualifyingStartDate = new DateTime(2024, 10, 4),
                   QualifyingEndDate = new DateTime(2024, 10, 5),
                   Surface = "Hard",
                   Category = TournamentCategory.Masters1000,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 201,
                   Name = "Nanao ITF100K",
                   Location = "Japan",
                   StartDate = new DateTime(2024, 10, 6),
                   EndDate = new DateTime(2024, 10, 12),
                   QualifyingStartDate = new DateTime(2024, 10, 4),
                   QualifyingEndDate = new DateTime(2024, 10, 5),
                   Surface = "Hard Indoor",
                   Category = TournamentCategory.ITF100K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 202,
                   Name = "Berkley ITF50K",
                   Location = "USA",
                   StartDate = new DateTime(2024, 10, 6),
                   EndDate = new DateTime(2024, 10, 12),
                   QualifyingStartDate = new DateTime(2024, 10, 4),
                   QualifyingEndDate = new DateTime(2024, 10, 5),
                   Surface = "Hard",
                   Category = TournamentCategory.ITF50K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 203,
                   Name = "Yeongwol1 ITF25K",
                   Location = "South Korea",
                   StartDate = new DateTime(2024, 10, 6),
                   EndDate = new DateTime(2024, 10, 12),
                   QualifyingStartDate = new DateTime(2024, 10, 4),
                   QualifyingEndDate = new DateTime(2024, 10, 5),
                   Surface = "Hard",
                   Category = TournamentCategory.ITF25K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 204,
                   Name = "Varna ITF10K",
                   Location = "Bulgaria",
                   StartDate = new DateTime(2024, 10, 6),
                   EndDate = new DateTime(2024, 10, 12),
                   QualifyingStartDate = new DateTime(2024, 10, 4),
                   QualifyingEndDate = new DateTime(2024, 10, 5),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF10K,
                   QualifyingRounds = 2
               },

               new Tournament
               {
                   Id = 205,
                   Name = "China Open 125k",
                   Location = "China",
                   StartDate = new DateTime(2024, 10, 13),
                   EndDate = new DateTime(2024, 10, 19),
                   QualifyingStartDate = new DateTime(2024, 10, 11),
                   QualifyingEndDate = new DateTime(2024, 10, 12),
                   Surface = "Hard",
                   Category = TournamentCategory.Challenger,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 206,
                   Name = "Hong Kong ITF100K",
                   Location = "China",
                   StartDate = new DateTime(2024, 10, 13),
                   EndDate = new DateTime(2024, 10, 19),
                   QualifyingStartDate = new DateTime(2024, 10, 11),
                   QualifyingEndDate = new DateTime(2024, 10, 12),
                   Surface = "Hard",
                   Category = TournamentCategory.ITF100K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 207,
                   Name = "Rancho Santa ITF100K",
                   Location = "USA",
                   StartDate = new DateTime(2024, 10, 13),
                   EndDate = new DateTime(2024, 10, 19),
                   QualifyingStartDate = new DateTime(2024, 10, 11),
                   QualifyingEndDate = new DateTime(2024, 10, 12),
                   Surface = "Hard Indoor",
                   Category = TournamentCategory.ITF100K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 208,
                   Name = "Redding ITF50K",
                   Location = "USA",
                   StartDate = new DateTime(2024, 10, 13),
                   EndDate = new DateTime(2024, 10, 19),
                   QualifyingStartDate = new DateTime(2024, 10, 11),
                   QualifyingEndDate = new DateTime(2024, 10, 12),
                   Surface = "Hard",
                   Category = TournamentCategory.ITF50K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 209,
                   Name = "Yeongwol2 ITF25K",
                   Location = "South Korea",
                   StartDate = new DateTime(2024, 10, 13),
                   EndDate = new DateTime(2024, 10, 19),
                   QualifyingStartDate = new DateTime(2024, 10, 11),
                   QualifyingEndDate = new DateTime(2024, 10, 12),
                   Surface = "Hard",
                   Category = TournamentCategory.ITF25K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 210,
                   Name = "Sharm ElSheikh1 ITF10K",
                   Location = "Egypt",
                   StartDate = new DateTime(2024, 10, 13),
                   EndDate = new DateTime(2024, 10, 19),
                   QualifyingStartDate = new DateTime(2024, 10, 11),
                   QualifyingEndDate = new DateTime(2024, 10, 12),
                   Surface = "Hard",
                   Category = TournamentCategory.ITF10K,
                   QualifyingRounds = 2
               },
               //Week 41
               new Tournament
               {
                   Id = 211,
                   Name = "Wuhan Masters1000",
                   Location = "China",
                   StartDate = new DateTime(2024, 10, 20),
                   EndDate = new DateTime(2024, 10, 26),
                   QualifyingStartDate = new DateTime(2024, 10, 18),
                   QualifyingEndDate = new DateTime(2024, 10, 19),
                   Surface = "Hard",
                   Category = TournamentCategory.Masters1000,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 212,
                   Name = "Cornella de Llobregat ITF100K",
                   Location = "Spain",
                   StartDate = new DateTime(2024, 10, 20),
                   EndDate = new DateTime(2024, 10, 26),
                   QualifyingStartDate = new DateTime(2024, 10, 18),
                   QualifyingEndDate = new DateTime(2024, 10, 19),
                   Surface = "Hard",
                   Category = TournamentCategory.ITF100K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 213,
                   Name = "Bratislava ITF50K",
                   Location = "Slovakia",
                   StartDate = new DateTime(2024, 10, 20),
                   EndDate = new DateTime(2024, 10, 26),
                   QualifyingStartDate = new DateTime(2024, 10, 18),
                   QualifyingEndDate = new DateTime(2024, 10, 19),
                   Surface = "Hard Indoor",
                   Category = TournamentCategory.ITF50K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 214,
                   Name = "Edmonton ITF25K",
                   Location = "Canada",
                   StartDate = new DateTime(2024, 10, 20),
                   EndDate = new DateTime(2024, 10, 26),
                   QualifyingStartDate = new DateTime(2024, 10, 18),
                   QualifyingEndDate = new DateTime(2024, 10, 19),
                   Surface = "Hard Indoor",
                   Category = TournamentCategory.ITF25K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 215,
                   Name = "Sharm ElSheikh2 ITF10K",
                   Location = "Egypt",
                   StartDate = new DateTime(2024, 10, 20),
                   EndDate = new DateTime(2024, 10, 26),
                   QualifyingStartDate = new DateTime(2024, 10, 18),
                   QualifyingEndDate = new DateTime(2024, 10, 19),
                   Surface = "Hard",
                   Category = TournamentCategory.ITF10K,
                   QualifyingRounds = 2
               },
               //Week 42
               new Tournament
               {
                   Id = 216,
                   Name = "Ningbo Open Masters500",
                   Location = "China",
                   StartDate = new DateTime(2024, 10, 27),
                   EndDate = new DateTime(2024, 11, 2),
                   QualifyingStartDate = new DateTime(2024, 10, 25),
                   QualifyingEndDate = new DateTime(2024, 10, 26),
                   Surface = "Hard",
                   Category = TournamentCategory.Masters500,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 217,
                   Name = "Japan Open Masters250",
                   Location = "Japan",
                   StartDate = new DateTime(2024, 10, 27),
                   EndDate = new DateTime(2024, 11, 2),
                   QualifyingStartDate = new DateTime(2024, 10, 25),
                   QualifyingEndDate = new DateTime(2024, 10, 26),
                   Surface = "Hard",
                   Category = TournamentCategory.Masters250,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 218,
                   Name = "Shrewsbury ITF100K",
                   Location = "Great Britain",
                   StartDate = new DateTime(2024, 10, 27),
                   EndDate = new DateTime(2024, 11, 2),
                   QualifyingStartDate = new DateTime(2024, 10, 25),
                   QualifyingEndDate = new DateTime(2024, 10, 26),
                   Surface = "Hard Indoor", 
                   Category = TournamentCategory.ITF100K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 219,
                   Name = "Kayseri1 ITF50K",
                   Location = "Turkey",
                   StartDate = new DateTime(2024, 10, 27),
                   EndDate = new DateTime(2024, 11, 2),
                   QualifyingStartDate = new DateTime(2024, 10, 25),
                   QualifyingEndDate = new DateTime(2024, 10, 26),
                   Surface = "Hard Indoor",
                   Category = TournamentCategory.ITF50K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 220,
                   Name = "Huzhou ITF25K",
                   Location = "China",
                   StartDate = new DateTime(2024, 10, 27),
                   EndDate = new DateTime(2024, 11, 2),
                   QualifyingStartDate = new DateTime(2024, 10, 25),
                   QualifyingEndDate = new DateTime(2024, 10, 26),
                   Surface = "Hard",
                   Category = TournamentCategory.ITF25K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 221,
                   Name = "Sharm ElSheikh3 ITF10K",
                   Location = "Egypt",
                   StartDate = new DateTime(2024, 10, 27),
                   EndDate = new DateTime(2024, 11, 2),
                   QualifyingStartDate = new DateTime(2024, 10, 25),
                   QualifyingEndDate = new DateTime(2024, 10, 26),
                   Surface = "Hard",
                   Category = TournamentCategory.ITF10K,
                   QualifyingRounds = 2
               },
               //Week 43
               new Tournament
               {
                   Id = 222,
                   Name = "Pan Pacific Open Masters500",
                   Location = "Japan",
                   StartDate = new DateTime(2024, 11, 3),
                   EndDate = new DateTime(2024, 11, 9),
                   QualifyingStartDate = new DateTime(2024, 11, 1),
                   QualifyingEndDate = new DateTime(2024, 11, 2),
                   Surface = "Hard",
                   Category = TournamentCategory.Masters500,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 223,
                   Name = "Guangzhou Open Masters250",
                   Location = "China",
                   StartDate = new DateTime(2024, 11, 3),
                   EndDate = new DateTime(2024, 11, 9),
                   QualifyingStartDate = new DateTime(2024, 11, 1),
                   QualifyingEndDate = new DateTime(2024, 11, 2),
                   Surface = "Hard",
                   Category = TournamentCategory.Masters250,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 224,
                   Name = "Abierto Tampico ITF100K",
                   Location = "Mexico",
                   StartDate = new DateTime(2024, 11, 3),
                   EndDate = new DateTime(2024, 11, 9),
                   QualifyingStartDate = new DateTime(2024, 11, 1),
                   QualifyingEndDate = new DateTime(2024, 11, 2),
                   Surface = "Hard",
                   Category = TournamentCategory.ITF100K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 225,
                   Name = "Glasgow ITF100K",
                   Location = "Great Britain",
                   StartDate = new DateTime(2024, 11, 3),
                   EndDate = new DateTime(2024, 11, 9),
                   QualifyingStartDate = new DateTime(2024, 11, 1),
                   QualifyingEndDate = new DateTime(2024, 11, 2),
                   Surface = "Hard Indoor",
                   Category = TournamentCategory.ITF100K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 226,
                   Name = "Kayseri2 ITF50K",
                   Location = "Turkey",
                   StartDate = new DateTime(2024, 11, 3),
                   EndDate = new DateTime(2024, 11, 9),
                   QualifyingStartDate = new DateTime(2024, 11, 1),
                   QualifyingEndDate = new DateTime(2024, 11, 2),
                   Surface = "Hard Indoor",
                   Category = TournamentCategory.ITF50K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 227,
                   Name = "Qian Daohu ITF25K",
                   Location = "China",
                   StartDate = new DateTime(2024, 11, 3),
                   EndDate = new DateTime(2024, 11, 9),
                   QualifyingStartDate = new DateTime(2024, 11, 1),
                   QualifyingEndDate = new DateTime(2024, 11, 2),
                   Surface = "Hard",
                   Category = TournamentCategory.ITF25K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 228,
                   Name = "Sharm ElSheikh4 ITF10K",
                   Location = "Egypt",
                   StartDate = new DateTime(2024, 11, 3),
                   EndDate = new DateTime(2024, 11, 9),
                   QualifyingStartDate = new DateTime(2024, 11, 1),
                   QualifyingEndDate = new DateTime(2024, 11, 2),
                   Surface = "Hard",
                   Category = TournamentCategory.ITF10K,
                   QualifyingRounds = 2
               },
               //Week 44
               new Tournament
               {
                   Id = 229,
                   Name = "Jiangxi Open Masters250",
                   Location = "China",
                   StartDate = new DateTime(2024, 11, 10),
                   EndDate = new DateTime(2024, 11, 16),
                   QualifyingStartDate = new DateTime(2024, 11, 8),
                   QualifyingEndDate = new DateTime(2024, 11, 9),
                   Surface = "Hard",
                   Category = TournamentCategory.Masters250,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 230,
                   Name = "Merida Open Masters250",
                   Location = "Mexico",
                   StartDate = new DateTime(2024, 11, 10),
                   EndDate = new DateTime(2024, 11, 16),
                   QualifyingStartDate = new DateTime(2024, 11, 8),
                   QualifyingEndDate = new DateTime(2024, 11, 9),
                   Surface = "Hard",
                   Category = TournamentCategory.Masters250,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 231,
                   Name = "Hong Kong Open Masters250",
                   Location = "China",
                   StartDate = new DateTime(2024, 11, 10),
                   EndDate = new DateTime(2024, 11, 16),
                   QualifyingStartDate = new DateTime(2024, 11, 8),
                   QualifyingEndDate = new DateTime(2024, 11, 9),
                   Surface = "Hard",
                   Category = TournamentCategory.Masters250,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 232,
                   Name = "Bolivia Open ITF100K",
                   Location = "Bolivia",
                   StartDate = new DateTime(2024, 11, 10),
                   EndDate = new DateTime(2024, 11, 16),
                   QualifyingStartDate = new DateTime(2024, 11, 8),
                   QualifyingEndDate = new DateTime(2024, 11, 9),
                   Surface = "Clay",
                   Category = TournamentCategory.ITF100K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 233,
                   Name = "Nantes ITF50K",
                   Location = "France",
                   StartDate = new DateTime(2024, 11, 10),
                   EndDate = new DateTime(2024, 11, 16),
                   QualifyingStartDate = new DateTime(2024, 11, 8),
                   QualifyingEndDate = new DateTime(2024, 11, 9),
                   Surface = "Hard Indoor",
                   Category = TournamentCategory.ITF50K,
                   QualifyingRounds = 2
               },
               new Tournament
               {
                   Id = 234,
                   Name = "Makinohara ITF10K",
                   Location = "Japan",
                   StartDate = new DateTime(2024, 11, 10),
                   EndDate = new DateTime(2024, 11, 16),
                   QualifyingStartDate = new DateTime(2024, 11, 8),
                   QualifyingEndDate = new DateTime(2024, 11, 9),
                   Surface = "Carpet",
                   Category = TournamentCategory.ITF10K,
                   QualifyingRounds = 2
               }
               );
        }
    }

}
