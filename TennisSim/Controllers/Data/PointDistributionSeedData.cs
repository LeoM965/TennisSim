using Microsoft.EntityFrameworkCore;
using TennisSim.Models;

namespace TennisSim.Data
{
    public static class PointDistributionSeedData
    {
        public static void SeedPointDistributions(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PointDistribution>().HasData(
                // Grand Slam (128S, 128Q)
                new PointDistribution { Id = 1, Category = TournamentCategory.GrandSlam, Round = "Winner", Points = 2000 },
                new PointDistribution { Id = 2, Category = TournamentCategory.GrandSlam, Round = "Final", Points = 1300 },
                new PointDistribution { Id = 3, Category = TournamentCategory.GrandSlam, Round = "Semi-Final", Points = 780 },
                new PointDistribution { Id = 4, Category = TournamentCategory.GrandSlam, Round = "Quarter-Final", Points = 430 },
                new PointDistribution { Id = 5, Category = TournamentCategory.GrandSlam, Round = "Round 4", Points = 240 },
                new PointDistribution { Id = 6, Category = TournamentCategory.GrandSlam, Round = "Round 3", Points = 130 },
                new PointDistribution { Id = 7, Category = TournamentCategory.GrandSlam, Round = "Round 2", Points = 70 },
                new PointDistribution { Id = 8, Category = TournamentCategory.GrandSlam, Round = "Round 1", Points = 10 },
                new PointDistribution { Id = 9, Category = TournamentCategory.GrandSlam, Round = "Q", Points = 40 },
                new PointDistribution { Id = 10, Category = TournamentCategory.GrandSlam, Round = "Q1", Points = 10 },
                new PointDistribution { Id = 11, Category = TournamentCategory.GrandSlam, Round = "Q2", Points = 20 },
                new PointDistribution { Id = 12, Category = TournamentCategory.GrandSlam, Round = "Q3", Points = 30 },

                // Masters1000 (96S, 48Q)
                new PointDistribution { Id = 13, Category = TournamentCategory.Masters1000, Round = "Winner", Points = 1000 },
                new PointDistribution { Id = 14, Category = TournamentCategory.Masters1000, Round = "Final", Points = 650 },
                new PointDistribution { Id = 15, Category = TournamentCategory.Masters1000, Round = "Semi-Final", Points = 390 },
                new PointDistribution { Id = 16, Category = TournamentCategory.Masters1000, Round = "Quarter-Final", Points = 215 },
                new PointDistribution { Id = 17, Category = TournamentCategory.Masters1000, Round = "Round 4", Points = 120 },
                new PointDistribution { Id = 18, Category = TournamentCategory.Masters1000, Round = "Round 3", Points = 65 },
                new PointDistribution { Id = 19, Category = TournamentCategory.Masters1000, Round = "Round 2", Points = 35 },
                new PointDistribution { Id = 20, Category = TournamentCategory.Masters1000, Round = "Round 1", Points = 10 },
                new PointDistribution { Id = 21, Category = TournamentCategory.Masters1000, Round = "Q", Points = 30 },
                new PointDistribution { Id = 22, Category = TournamentCategory.Masters1000, Round = "Q1", Points = 10 },
                new PointDistribution { Id = 23, Category = TournamentCategory.Masters1000, Round = "Q2", Points = 20 },                 
                // Masters500 (48S, 24Q)
                new PointDistribution { Id = 24, Category = TournamentCategory.Masters500, Round = "Winner", Points = 500 },
                new PointDistribution { Id = 25, Category = TournamentCategory.Masters500, Round = "Final", Points = 325 },
                new PointDistribution { Id = 26, Category = TournamentCategory.Masters500, Round = "Semi-Final", Points = 195 },
                new PointDistribution { Id = 27, Category = TournamentCategory.Masters500, Round = "Quarter-Final", Points = 108 },
                new PointDistribution { Id = 28, Category = TournamentCategory.Masters500, Round = "Round 3", Points = 60 },
                new PointDistribution { Id = 29, Category = TournamentCategory.Masters500, Round = "Round 2", Points = 32 },
                new PointDistribution { Id = 30, Category = TournamentCategory.Masters500, Round = "Round 1", Points = 1 },
                new PointDistribution { Id = 31, Category = TournamentCategory.Masters500, Round = "Q", Points = 25 },
                new PointDistribution { Id = 32, Category = TournamentCategory.Masters500, Round = "Q1", Points = 13 },
                new PointDistribution { Id = 33, Category = TournamentCategory.Masters500, Round = "Q2", Points = 18 },

                // Masters250 (32S, 16Q)
                new PointDistribution { Id = 34, Category = TournamentCategory.Masters250, Round = "Winner", Points = 250 },
                new PointDistribution { Id = 35, Category = TournamentCategory.Masters250, Round = "Final", Points = 163 },
                new PointDistribution { Id = 36, Category = TournamentCategory.Masters250, Round = "Semi-Final", Points = 98 },
                new PointDistribution { Id = 37, Category = TournamentCategory.Masters250, Round = "Quarter-Final", Points = 54 },
                new PointDistribution { Id = 38, Category = TournamentCategory.Masters250, Round = "Round 2", Points = 30 },
                new PointDistribution { Id = 39, Category = TournamentCategory.Masters250, Round = "Round 1", Points = 1 },
                new PointDistribution { Id = 40, Category = TournamentCategory.Masters250, Round = "Q", Points = 18 },
                new PointDistribution { Id = 41, Category = TournamentCategory.Masters250, Round = "Q1", Points = 12 },
                new PointDistribution { Id = 42, Category = TournamentCategory.Masters250, Round = "Q2", Points = 1 },

                // ITF100K (32S, 24Q) - 3 runde de calificare
                new PointDistribution { Id = 43, Category = TournamentCategory.ITF100K, Round = "Winner", Points = 100 },
                new PointDistribution { Id = 44, Category = TournamentCategory.ITF100K, Round = "Final", Points = 65 },
                new PointDistribution { Id = 45, Category = TournamentCategory.ITF100K, Round = "Semi-Final", Points = 39 },
                new PointDistribution { Id = 46, Category = TournamentCategory.ITF100K, Round = "Quarter-Final", Points = 21 },
                new PointDistribution { Id = 47, Category = TournamentCategory.ITF100K, Round = "Round 2", Points = 12 },
                new PointDistribution { Id = 48, Category = TournamentCategory.ITF100K, Round = "Round 1", Points = 7 },
                new PointDistribution { Id = 49, Category = TournamentCategory.ITF100K, Round = "Q", Points = 5 },
                new PointDistribution { Id = 50, Category = TournamentCategory.ITF100K, Round = "Q1", Points = 3 },
                new PointDistribution { Id = 51, Category = TournamentCategory.ITF100K, Round = "Q2", Points = 5 },
                // ITF50K (32S, 32Q) - 3 runde de calificare
                new PointDistribution { Id = 52, Category = TournamentCategory.ITF50K, Round = "Winner", Points = 50 },
                new PointDistribution { Id = 53, Category = TournamentCategory.ITF50K, Round = "Final", Points = 33 },
                new PointDistribution { Id = 54, Category = TournamentCategory.ITF50K, Round = "Semi-Final", Points = 20 },
                new PointDistribution { Id = 55, Category = TournamentCategory.ITF50K, Round = "Quarter-Final", Points = 11 },
                new PointDistribution { Id = 56, Category = TournamentCategory.ITF50K, Round = "Round 2", Points = 6 },
                new PointDistribution { Id = 57, Category = TournamentCategory.ITF50K, Round = "Round 1", Points = 3 },
                new PointDistribution { Id = 58, Category = TournamentCategory.ITF50K, Round = "Q", Points = 2 },
                new PointDistribution { Id = 59, Category = TournamentCategory.ITF50K, Round = "Q1", Points = 1 },
                new PointDistribution { Id = 60, Category = TournamentCategory.ITF50K, Round = "Q2", Points = 2 },
                // ITF25K (32S, 32Q) - 3 runde de calificare
                new PointDistribution { Id = 61, Category = TournamentCategory.ITF25K, Round = "Winner", Points = 25 },
                new PointDistribution { Id = 62, Category = TournamentCategory.ITF25K, Round = "Final", Points = 16 },
                new PointDistribution { Id = 63, Category = TournamentCategory.ITF25K, Round = "Semi-Final", Points = 9 },
                new PointDistribution { Id = 64, Category = TournamentCategory.ITF25K, Round = "Quarter-Final", Points = 5 },
                new PointDistribution { Id = 65, Category = TournamentCategory.ITF25K, Round = "Round 2", Points = 3 },
                new PointDistribution { Id = 66, Category = TournamentCategory.ITF25K, Round = "Round 1", Points = 2 },
                new PointDistribution { Id = 67, Category = TournamentCategory.ITF25K, Round = "Q", Points = 1 },
                new PointDistribution { Id = 68, Category = TournamentCategory.ITF25K, Round = "Q1", Points = 1 },
                new PointDistribution { Id = 69, Category = TournamentCategory.ITF25K, Round = "Q2", Points = 2 },
                // ITF10K (32S, 32Q) - 3 runde de calificare
                new PointDistribution { Id = 70, Category = TournamentCategory.ITF10K, Round = "Winner", Points = 10 },
                new PointDistribution { Id = 71, Category = TournamentCategory.ITF10K, Round = "Final", Points = 6 },
                new PointDistribution { Id = 72, Category = TournamentCategory.ITF10K, Round = "Semi-Final", Points = 4 },
                new PointDistribution { Id = 73, Category = TournamentCategory.ITF10K, Round = "Quarter-Final", Points = 2 },
                new PointDistribution { Id = 74, Category = TournamentCategory.ITF10K, Round = "Round 2", Points = 1 },
                new PointDistribution { Id = 75, Category = TournamentCategory.ITF10K, Round = "Round 1", Points = 1 },
                new PointDistribution { Id = 76, Category = TournamentCategory.ITF10K, Round = "Q", Points = 1 },
                new PointDistribution { Id = 77, Category = TournamentCategory.ITF10K, Round = "Q1", Points = 1 },
                new PointDistribution { Id = 78, Category = TournamentCategory.ITF10K, Round = "Q2", Points = 1 },
                // Challenger
                new PointDistribution { Id = 79, Category = TournamentCategory.Challenger, Round = "Winner", Points = 150 },
                new PointDistribution { Id = 80, Category = TournamentCategory.Challenger, Round = "Final", Points = 90 },
                new PointDistribution { Id = 81, Category = TournamentCategory.Challenger, Round = "Semi-Final", Points = 55 },
                new PointDistribution { Id = 82, Category = TournamentCategory.Challenger, Round = "Quarter-Final", Points = 30 },
                new PointDistribution { Id = 83, Category = TournamentCategory.Challenger, Round = "Round 2", Points = 15 },
                new PointDistribution { Id = 84, Category = TournamentCategory.Challenger, Round = "Round 1", Points = 7 },
                new PointDistribution { Id = 85, Category = TournamentCategory.Challenger, Round = "Q", Points = 4 },
                new PointDistribution { Id = 86, Category = TournamentCategory.Challenger, Round = "Q1", Points = 2 },
                new PointDistribution { Id = 87, Category = TournamentCategory.Challenger, Round = "Q2", Points = 3 }


            );
        }
    }
}
