using TennisSim.Models;

namespace TennisSim.Services
{
    public class ScheduleGenerator
    {
        private readonly Tournament _tournament;
        private readonly HashSet<int> _scheduledMatchIds;

        public ScheduleGenerator(Tournament tournament)
        {
            _tournament = tournament;
            _scheduledMatchIds = new HashSet<int>();
        }

        public List<Schedule> GenerateSchedule(Draw draw)
        {
            Console.WriteLine($"[ScheduleGenerator] Generating schedule for DrawId={draw.Id}");
            List<Schedule> schedules = new List<Schedule>();
            (List<string> Names, int MatchesPerCourt) courts = GetCourtConfiguration();
            Dictionary<int, List<DrawMatch>> matchesByRound = GroupMatchesByRound(draw.DrawMatches);
            int totalRounds = GetTotalRounds();

            Dictionary<int, int> daysPerRound = _tournament.Category switch
            {
                TournamentCategory.GrandSlam or TournamentCategory.Masters1000 => new Dictionary<int, int>
                {
                    { 1, 2 }, { 2, 2 }, { 3, 2 }, { 4, 2 }, { 5, 2 }, { 6, 2 }, { 7, 1 }
                },
                TournamentCategory.Masters500 => new Dictionary<int, int>
                {
                    { 1, 2 }, { 2, 1 }, { 3, 1 }, { 4, 1 }, { 5, 1 }, { 6, 1 }
                },
                _ => new Dictionary<int, int>
                {
                    { 1, 2 }, { 2, 2 }, { 3, 1 }, { 4, 1 }, { 5, 1 }
                }
            };

            DateTime currentDate = _tournament.StartDate;

            for (int round = 1; round <= totalRounds && currentDate <= _tournament.EndDate; round++)
            {
                if (!matchesByRound.ContainsKey(round)) continue;

                Console.WriteLine($"[ScheduleGenerator] Processing Round={round}");

                List<DrawMatch> unscheduledMatches = matchesByRound[round]
                    .Where(m => !_scheduledMatchIds.Contains(m.Id))
                    .OrderBy(m => Math.Min(GetPlayerBestRank(m.Player1), GetPlayerBestRank(m.Player2)))
                    .ToList();

                if (unscheduledMatches.Count == 0) continue;

                ProcessRoundEvenly(round, unscheduledMatches, daysPerRound[round], currentDate, courts, schedules, draw);

                currentDate = currentDate.AddDays(daysPerRound[round]);

                if ((_tournament.Category == TournamentCategory.GrandSlam || _tournament.Category == TournamentCategory.Masters1000) &&
                    round == 6)
                {
                    currentDate = currentDate.AddDays(1);
                }
            }

            Console.WriteLine($"[ScheduleGenerator] Generated {schedules.Count} daily schedules.");
            return schedules;
        }

        private void ProcessRoundEvenly(int round, List<DrawMatch> matches, int days, DateTime startDate,
                                        (List<string> Names, int MatchesPerCourt) courts,
                                        List<Schedule> schedules, Draw draw)
        {
            DateTime currentDate = startDate;
            int matchesPerDay = (int)Math.Ceiling(matches.Count / (double)days);
            int matchIndex = 0;

            for (int day = 0; day < days && matchIndex < matches.Count; day++, currentDate = currentDate.AddDays(1))
            {
                Schedule dailySchedule = new Schedule
                {
                    DrawId = draw.Id,
                    Date = currentDate,
                    Draw = draw,
                    ScheduledMatches = new List<ScheduleMatch>()
                };

                int matchesForThisDay = Math.Min(matchesPerDay, matches.Count - matchIndex);

                for (int i = 0; i < matchesForThisDay; i++)
                {
                    int courtIndex = i % courts.Names.Count;
                    int slotIndex = i / courts.Names.Count;
                    DrawMatch match = matches[matchIndex++];
                    DateTime startTime = currentDate.Date.AddHours(11).AddMinutes(120 * slotIndex);

                    Console.WriteLine($"[ScheduleGenerator] Scheduling MatchId={match.Id} on {courts.Names[courtIndex]} at {startTime}");

                    dailySchedule.ScheduledMatches.Add(new ScheduleMatch
                    {
                        DrawMatchId = match.Id,
                        DrawMatch = match,
                        Court = courts.Names[courtIndex],
                        StartTime = startTime,
                        Status = MatchStatus.Scheduled,
                        Round = GetRoundString(round)
                    });

                    _scheduledMatchIds.Add(match.Id);
                }

                schedules.Add(dailySchedule);
            }
        }

        private int GetTotalRounds()
        {
            return _tournament.Category switch
            {
                TournamentCategory.GrandSlam => 7,
                TournamentCategory.Masters1000 => 7,
                TournamentCategory.Masters500 => 6,
                _ => 5
            };
        }

        private static int GetPlayerBestRank(Player player)
        {
            return player?.Rankings?.OrderByDescending(r => r.Date).FirstOrDefault()?.Rank ?? int.MaxValue;
        }

        private (List<string> Names, int MatchesPerCourt) GetCourtConfiguration()
        {
            (int courtCount, int matchesPerCourt) = _tournament.Category switch
            {
                TournamentCategory.GrandSlam => (7, 5),
                TournamentCategory.Masters1000 => (6, 3),
                TournamentCategory.Masters500 => (6, 3),
                _ => (3, 3)
            };

            List<string> courtNames = new List<string> { "Centre Court" };
            for (int i = 2; i <= courtCount; i++)
            {
                courtNames.Add(i == 2 && _tournament.Category == TournamentCategory.GrandSlam ? "Court 1" : $"Court {i - 1}");
            }

            return (courtNames, matchesPerCourt);
        }

        private static Dictionary<int, List<DrawMatch>> GroupMatchesByRound(IEnumerable<DrawMatch> matches)
        {
            return matches.Where(m => !m.IsBye && m.Player1Id.HasValue && m.Player2Id.HasValue)
                          .GroupBy(m => m.Round)
                          .ToDictionary(g => g.Key, g => g.ToList());
        }

        private string GetRoundString(int round)
        {
            return _tournament.Category switch
            {
                TournamentCategory.GrandSlam or TournamentCategory.Masters1000 => round switch
                {
                    1 => "Round 1",
                    2 => "Round 2",
                    3 => "Round 3",
                    4 => "Round 4",
                    5 => "Quarter-Final",
                    6 => "Semi-Final",
                    7 => "Final",
                    _ => $"Round {round}"
                },
                TournamentCategory.Masters500 => round switch
                {
                    1 => "Round 1",
                    2 => "Round 2",
                    3 => "Round 3",
                    4 => "Quarter-Final",
                    5 => "Semi-Final",
                    6 => "Final",
                    _ => $"Round {round}"
                },
                _ => round switch
                {
                    1 => "Round 1",
                    2 => "Round 2",
                    3 => "Quarter-Final",
                    4 => "Semi-Final",
                    5 => "Final",
                    _ => $"Round {round}"
                }
            };
        }
    }
}