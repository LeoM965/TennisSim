using TennisSim.Models;

namespace TennisSim.Utilities
{
    public static class DrawConstants
    {
        public static int GetDrawSize(TournamentCategory category)
        {
            return category switch
            {
                TournamentCategory.GrandSlam => 128,
                TournamentCategory.Masters1000 => 128,
                TournamentCategory.Masters500 => 64,
                TournamentCategory.Masters250 => 32,
                TournamentCategory.Challenger => 32,
                TournamentCategory.ITF100K => 32,
                TournamentCategory.ITF50K => 32,
                TournamentCategory.ITF25K => 32,
                TournamentCategory.ITF10K => 32,
                _ => 32
            };
        }

        public static int GetByeCount(TournamentCategory category)
        {
            return category switch
            {
                TournamentCategory.Masters1000 => 32,
                TournamentCategory.Masters500 => 16,
                _ => 0
            };
        }

        public static int GetSeedCount(TournamentCategory category) => category switch
        {
            TournamentCategory.GrandSlam => 32,
            TournamentCategory.Masters1000 => 32,
            TournamentCategory.Masters500 => 16,
            _ => 8
        };

        public static int GetSeedPosition(int seedNumber, int totalMatches)
        {
            if (totalMatches == 64) // 128 draw size (Grand Slam & Masters 1000)
            {
                return seedNumber switch
                {
                    1 => 0,      // Top section
                    2 => 63,     // Bottom section
                    3 => 31,     // Second quarter
                    4 => 32,     // Third quarter
                    5 => 15,     // Top quarter section 2
                    6 => 48,     // Bottom quarter section 1
                    7 => 47,     // Bottom quarter section 2
                    8 => 16,     // Top quarter section 1
                    9 => 7,      // Further distribution
                    10 => 56,
                    11 => 39,
                    12 => 24,
                    13 => 23,
                    14 => 40,
                    15 => 55,
                    16 => 8,
                    17 => 3,
                    18 => 60,
                    19 => 35,
                    20 => 28,
                    21 => 19,
                    22 => 44,
                    23 => 51,
                    24 => 12,
                    25 => 11,
                    26 => 52,
                    27 => 43,
                    28 => 20,
                    29 => 27,
                    30 => 36,
                    31 => 59,
                    32 => 4,
                    _ => seedNumber - 1
                };
            }
            else if (totalMatches == 32) // 64 draw size
            {
                return seedNumber switch
                {
                    1 => 0,     // Top section
                    2 => 31,    // Bottom section
                    3 => 23,    // Second quarter
                    4 => 8,     // Third quarter
                    5 => 24,    // Top section
                    6 => 16,    // Bottom section
                    7 => 7,     // Second section
                    8 => 15,    // Third section
                    9 => 27,    // Further distribution
                    10 => 4,
                    11 => 19,
                    12 => 12,
                    13 => 20,
                    14 => 11,
                    15 => 3,
                    16 => 28,
                    _ => seedNumber - 1
                };
            }
            else if (totalMatches == 16) // 32 draw size (Masters 250 and others)
            {
                return seedNumber switch
                {
                    1 => 0,     // Top quarter
                    2 => 15,    // Bottom quarter
                    3 => 7,     // Second quarter
                    4 => 8,     // Third quarter
                    5 => 3,     // Top section
                    6 => 12,    // Bottom section
                    7 => 11,    // Second section
                    8 => 4,     // Third section
                    _ => seedNumber - 1
                };
            }

            return seedNumber - 1;
        }
    }
}