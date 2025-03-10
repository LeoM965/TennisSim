﻿using Microsoft.EntityFrameworkCore;
using TennisSim.Data;
using TennisSim.Models;

namespace TennisSim.Services
{
    public class TournamentService : ITournamentService
    {
        private readonly ApplicationDbContext _context;

        public TournamentService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Tournament> GetAllTournaments()
        {
            return _context.Tournaments
                .OrderBy(t => t.StartDate)
                .ToList();
        }

        public Tournament GetTournamentById(int id)
        {
            Tournament? tournament = _context.Tournaments
                .Include(t => t.PointDistributions)
                .FirstOrDefault(t => t.Id == id);

            if (tournament == null)
            {
                throw new KeyNotFoundException($"Tournament with ID {id} not found.");
            }

            return tournament;
        }

        public List<PointDistribution> GetPointDistributions(TournamentCategory category)
        {
            return _context.PointDistributions
                .Where(pd => pd.Category == category)
                .ToList();
        }

        public List<Schedule> GenerateTournamentSchedule(int tournamentId, Draw draw)
        {
            Tournament? tournament = _context.Tournaments
                .FirstOrDefault(t => t.Id == tournamentId);

            if (tournament == null) return new List<Schedule>();

            List<Schedule> existingSchedules = _context.Schedules
                .Where(s => s.DrawId == draw.Id)
                .ToList();

            ScheduleGenerator scheduleGenerator = new ScheduleGenerator(tournament);
            List<Schedule> schedules = scheduleGenerator.GenerateSchedule(draw);

            foreach (Schedule schedule in schedules)
            {
                if (!existingSchedules.Any(s => s.Date == schedule.Date))
                {
                    _context.Schedules.Add(schedule);
                }
            }

            _context.SaveChanges();
            return schedules;
        }

        public async Task<bool> HasUnplayedMatches(int tournamentId)
        {
            List<int> drawIds = await _context.Draws
                .Where(d => d.TournamentId == tournamentId)
                .Select(d => d.Id)
                .ToListAsync();

            return await _context.Schedules
                .Where(s => drawIds.Contains(s.DrawId))
                .SelectMany(s => s.ScheduledMatches)
                .AnyAsync(m => m.Status == MatchStatus.Scheduled);
        }

        public async Task<ScheduleMatch> GetNextUnplayedMatch(int tournamentId)
        {
            List<int> drawIds = await _context.Draws
                .Where(d => d.TournamentId == tournamentId)
                .Select(d => d.Id)
                .ToListAsync();

            ScheduleMatch? match = await _context.Schedules
                .Where(s => drawIds.Contains(s.DrawId))
                .SelectMany(s => s.ScheduledMatches)
                .Include(m => m.DrawMatch)
                    .ThenInclude(dm => dm.Player1)
                .Include(m => m.DrawMatch)
                    .ThenInclude(dm => dm.Player2)
                .Where(m => m.Status == MatchStatus.Scheduled)
                .OrderBy(m => m.StartTime)
                .FirstOrDefaultAsync();

            if (match == null)
            {
                throw new InvalidOperationException("No unplayed matches found for the specified tournament.");
            }

            return match;
        }

        public List<DateTime> GetAvailableDates(int tournamentId, DateTime startDate, DateTime currentDate)
        {
            List<DateTime> dates = new List<DateTime>();
            DateTime date = startDate.Date;

            while (date <= currentDate.Date)
            {
                dates.Add(date);
                date = date.AddDays(1);
            }

            return dates;
        }

        public List<Schedule> GetTournamentScheduleForDate(int tournamentId, Draw draw, DateTime requestedDate)
        {
            Tournament? tournament = _context.Tournaments
                .FirstOrDefault(t => t.Id == tournamentId);

            if (tournament == null)
                return new List<Schedule>();

            List<Schedule> existingSchedule = _context.Schedules
                .Where(s => s.DrawId == draw.Id && s.Date.Date == requestedDate.Date)
                .Include(s => s.ScheduledMatches)
                    .ThenInclude(m => m.DrawMatch)
                        .ThenInclude(dm => dm.Match)
                .Include(s => s.ScheduledMatches)
                    .ThenInclude(m => m.DrawMatch)
                        .ThenInclude(dm => dm.Player1)
                .Include(s => s.ScheduledMatches)
                    .ThenInclude(m => m.DrawMatch)
                        .ThenInclude(dm => dm.Player2)
                .ToList();

            if (existingSchedule.Count > 0)
                return existingSchedule;

            ScheduleGenerator scheduleGenerator = new ScheduleGenerator(tournament);
            List<Schedule> allSchedules = scheduleGenerator.GenerateSchedule(draw);

            List<Schedule> requestedDateSchedule = allSchedules
                .Where(s => s.Date.Date == requestedDate.Date)
                .ToList();

            foreach (Schedule schedule in requestedDateSchedule)
            {
                _context.Schedules.Add(schedule);
            }
            _context.SaveChanges();

            return requestedDateSchedule;
        }
    }
}