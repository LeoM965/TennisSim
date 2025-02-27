using TennisSim.Models;

public class MatchSimulation
{
    private readonly Random _random;
    private static readonly Dictionary<string, double> AttributeWeights = new()
    {
        ["Forehand"] = 1.2,
        ["Backhand"] = 1.1,
        ["Speed"] = 0.9,
        ["Stamina"] = 0.8,
        ["Mental"] = 1.0,
        ["Volley"] = 0.7
    };

    public MatchSimulation(Random random) => _random = random;

    public record MatchResult(List<SetResult> Sets, bool WinnerIsPlayer1);
    public record SetResult(int P1Score, int P2Score, List<GameResult> Games, TiebreakResult? Tiebreak);
    public record GameResult(bool WinnerIsPlayer1, List<PointResult> Points);
    public record TiebreakResult(bool WinnerIsPlayer1, List<PointResult> Points, int FinalP1Score, int FinalP2Score);
    public record PointResult(bool WinnerIsPlayer1, string P1ScoreDisplay, string P2ScoreDisplay);

    public MatchResult SimulateMatch(IEnumerable<PlayerAttribute> p1Attributes, IEnumerable<PlayerAttribute> p2Attributes)
    {
        double p1Strength = CalculatePlayerScore(p1Attributes);
        double p2Strength = CalculatePlayerScore(p2Attributes);
        double winProbability = p1Strength / (p1Strength + p2Strength);

        var sets = new List<SetResult>();
        int p1Sets = 0, p2Sets = 0;

        while (Math.Max(p1Sets, p2Sets) < 2)
        {
            var set = SimulateSet(winProbability);
            sets.Add(set);
            if (set.P1Score > set.P2Score) p1Sets++; else p2Sets++;
        }

        return new MatchResult(sets, p1Sets > p2Sets);
    }

    private SetResult SimulateSet(double winProbability)
    {
        var games = new List<GameResult>();
        int p1Games = 0, p2Games = 0;

        while (!IsSetFinished(p1Games, p2Games))
        {
            if (p1Games == 6 && p2Games == 6)
            {
                var tiebreak = SimulateTiebreak(winProbability);
                games.Add(new GameResult(tiebreak.WinnerIsPlayer1, tiebreak.Points));

                if (tiebreak.WinnerIsPlayer1)
                    p1Games++;
                else
                    p2Games++;

                return new SetResult(p1Games, p2Games, games, tiebreak);
            }

            var game = SimulateGame(winProbability);
            games.Add(game);

            if (game.WinnerIsPlayer1) p1Games++; else p2Games++;
        }

        return new SetResult(p1Games, p2Games, games, null);
    }

    private static bool IsSetFinished(int p1Games, int p2Games)
    {
        if (p1Games == 6 && p2Games == 6) return false;
        if (Math.Max(p1Games, p2Games) < 6) return false;
        return Math.Abs(p1Games - p2Games) >= 2;
    }

    private TiebreakResult SimulateTiebreak(double winProbability)
    {
        var points = new List<PointResult>();
        int p1Score = 0, p2Score = 0;

        while (!IsTiebreakFinished(p1Score, p2Score))
        {
            bool p1WinsPoint = _random.NextDouble() < winProbability;

            if (p1WinsPoint)
                p1Score++;
            else
                p2Score++;

            points.Add(new PointResult(
                p1WinsPoint,
                $"{p1Score}",
                $"{p2Score}"
            ));
        }

        bool p1Wins = p1Score > p2Score;

        points.Add(new PointResult(
            p1Wins,
            p1Wins ? "Win" : p1Score.ToString(),
            p1Wins ? p2Score.ToString() : "Win"
        ));

        return new TiebreakResult(p1Wins, points, p1Score, p2Score);
    }

    private static bool IsTiebreakFinished(int p1Score, int p2Score)
    {
        return (Math.Max(p1Score, p2Score) >= 7) && (Math.Abs(p1Score - p2Score) >= 2);
    }

    private GameResult SimulateGame(double winProbability)
    {
        var points = new List<PointResult>();
        var score = new GameScore();
        string lastP1Score = "";
        string lastP2Score = "";

        while (!score.IsGameFinished())
        {
            bool p1WinsPoint = _random.NextDouble() < winProbability;
            score.AddPoint(p1WinsPoint);

            string currentP1Score = score.GetDisplayScore(true);
            string currentP2Score = score.GetDisplayScore(false);

            if (currentP1Score != lastP1Score || currentP2Score != lastP2Score)
            {
                points.Add(new PointResult(
                    p1WinsPoint,
                    currentP1Score,
                    currentP2Score
                ));

                lastP1Score = currentP1Score;
                lastP2Score = currentP2Score;
            }
        }

        bool p1Wins = score.GetWinner();
        points.Add(new PointResult(
            p1Wins,
            p1Wins ? "Game" : lastP1Score,
            p1Wins ? lastP2Score : "Game"
        ));

        return new GameResult(p1Wins, points);
    }

    private class GameScore
    {
        private int p1Points = 0;
        private int p2Points = 0;
        private bool isDeuce = false;
        private int? advantagePlayer = null;

        public void AddPoint(bool p1WinsPoint)
        {
            if (isDeuce)
            {
                HandleDeucePoint(p1WinsPoint);
                return;
            }

            if (p1WinsPoint) p1Points++; else p2Points++;

            if (p1Points >= 3 && p2Points >= 3 && p1Points == p2Points)
            {
                isDeuce = true;
                advantagePlayer = null;
            }
        }

        private void HandleDeucePoint(bool p1WinsPoint)
        {
            if (advantagePlayer == null)
            {
                advantagePlayer = p1WinsPoint ? 1 : 2;
            }
            else if ((advantagePlayer == 1 && p1WinsPoint) || (advantagePlayer == 2 && !p1WinsPoint))
            {
                if (p1WinsPoint) p1Points++; else p2Points++;
            }
            else
            {
                advantagePlayer = null;
            }
        }

        public bool IsGameFinished()
        {
            if (!isDeuce)
            {
                return (p1Points >= 4 && p1Points >= p2Points + 2) ||
                       (p2Points >= 4 && p2Points >= p1Points + 2);
            }

            return (advantagePlayer == 1 && p1Points > p2Points) ||
                   (advantagePlayer == 2 && p2Points > p1Points);
        }

        public bool GetWinner() => p1Points > p2Points;

        public string GetDisplayScore(bool forP1)
        {
            if (!isDeuce)
            {
                return (forP1 ? p1Points : p2Points) switch
                {
                    0 => "0",
                    1 => "15",
                    2 => "30",
                    _ => "40"
                };
            }

            if (advantagePlayer == null)
            {
                return "40";
            }

            if (forP1)
            {
                return advantagePlayer == 1 ? "Ad" : "40";
            }
            else
            {
                return advantagePlayer == 2 ? "Ad" : "40";
            }
        }
    }

    private static double CalculatePlayerScore(IEnumerable<PlayerAttribute> attributes)
    {
        double totalScore = 0;

        foreach (var attribute in attributes)
        {
            double attributeValue = attribute.Value;

            string attributeType = attribute.AttributeType;

            double attributeWeight;

            if (AttributeWeights.TryGetValue(attributeType, out var weight))
            {
                attributeWeight = weight; 
            }
            else
            {
                attributeWeight = 1.0; 
            }

            double weightedAttributeScore = attributeValue * attributeWeight;
            totalScore += weightedAttributeScore;
        }

        return totalScore;
    }
}