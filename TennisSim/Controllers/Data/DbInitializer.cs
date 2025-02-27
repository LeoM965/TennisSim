using Microsoft.EntityFrameworkCore;
using TennisSim.Models;

namespace TennisSim.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Player> Players { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<PlayerAttribute> PlayerAttributes { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Ranking> Rankings { get; set; }
        public DbSet<PointDistribution> PointDistributions { get; set; }
        public DbSet<UserName> UserNames { get; set; }
        public DbSet<UserEntryList> UserEntryLists { get; set; }
        public DbSet<EntryList> EntryLists { get; set; }

        public DbSet<Draw> Draws { get; set; }
        public DbSet<DrawMatch> DrawMatches { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<ScheduleMatch> ScheduleMatches { get; set; }

        // Metoda OnModelCreating optimizată
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            SeedData(modelBuilder);

            ConfigureTypeConversions(modelBuilder);

            ConfigurePlayerRelationships(modelBuilder);
            ConfigureMatchRelationships(modelBuilder);
            ConfigureTournamentRelationships(modelBuilder);
            ConfigureDrawRelationships(modelBuilder);
            ConfigureScheduleRelationships(modelBuilder);
        }

        private static void SeedData(ModelBuilder modelBuilder)
        {
            NationalitySeedData.SeedNationalities(modelBuilder);
            PointDistributionSeedData.SeedPointDistributions(modelBuilder);
            TournamentSeedData.SeedTournaments(modelBuilder);
            PlayerSeedData.SeedPlayers(modelBuilder);
            RankingSeedData.SeedRankings(modelBuilder);
            PlayerAttributeSeedData.SeedPlayerAttributes(modelBuilder);
        }

        private static void ConfigureTypeConversions(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tournament>()
                .Property(t => t.Category)
                .HasConversion<string>();

            modelBuilder.Entity<ScheduleMatch>()
                .Property(sm => sm.Status)
                .HasConversion<string>();
        }

        private static void ConfigurePlayerRelationships(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>()
                .HasOne(p => p.Nationality)
                .WithMany(n => n.Players)
                .HasForeignKey(p => p.NationalityId)
                .OnDelete(DeleteBehavior.Restrict);
        }

        private static void ConfigureMatchRelationships(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Match>()
                .HasOne(m => m.Player1)
                .WithMany(p => p.MatchesAsPlayer1)
                .HasForeignKey(m => m.Player1Id)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Match>()
                .HasOne(m => m.Player2)
                .WithMany(p => p.MatchesAsPlayer2)
                .HasForeignKey(m => m.Player2Id)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Match>()
                .HasOne(m => m.Winner)
                .WithMany()
                .HasForeignKey(m => m.WinnerId)
                .OnDelete(DeleteBehavior.Restrict);

        }

        private static void ConfigureTournamentRelationships(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tournament>()
                .HasMany(t => t.PointDistributions)
                .WithOne()
                .HasForeignKey("TournamentId");

            modelBuilder.Entity<UserEntryList>()
                .HasOne(ue => ue.Tournament)
                .WithMany(t => t.UserEntryLists)
                .HasForeignKey(ue => ue.TournamentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<UserEntryList>()
                .HasOne(ue => ue.User)
                .WithMany(u => u.UserEntryLists)
                .HasForeignKey(ue => ue.UserNameId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<EntryList>()
                .HasOne(e => e.UserEntryList)
                .WithMany(ue => ue.EntryList)
                .HasForeignKey(e => e.UserEntryListId)
                .OnDelete(DeleteBehavior.Cascade);
        }

        private static void ConfigureDrawRelationships(ModelBuilder modelBuilder)
        {
            // Relația între Draw și Tournament
            modelBuilder.Entity<Draw>()
                .HasOne(d => d.Tournament)
                .WithMany(t => t.Draws)
                .HasForeignKey(d => d.TournamentId)
                .OnDelete(DeleteBehavior.Restrict);

            // Relația între Draw și UserName
            modelBuilder.Entity<Draw>()
                .HasOne(d => d.User)
                .WithMany(u => u.Draws)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // Relația între DrawMatch și Draw
            modelBuilder.Entity<DrawMatch>()
                .HasOne(dm => dm.Draw)
                .WithMany(d => d.DrawMatches)
                .HasForeignKey(dm => dm.DrawId)
                .OnDelete(DeleteBehavior.Cascade);

            // Relația între DrawMatch și Player1
            modelBuilder.Entity<DrawMatch>()
                .HasOne(dm => dm.Player1)
                .WithMany()
                .HasForeignKey(dm => dm.Player1Id)
                .OnDelete(DeleteBehavior.Restrict);

            // Relația între DrawMatch și Player2
            modelBuilder.Entity<DrawMatch>()
                .HasOne(dm => dm.Player2)
                .WithMany()
                .HasForeignKey(dm => dm.Player2Id)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DrawMatch>()
                .HasOne(dm => dm.Winner)
                .WithMany()
                .HasForeignKey(dm => dm.WinnerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
        private static void ConfigureScheduleRelationships(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Schedule>()
                .HasOne(s => s.Draw)
                .WithMany(d => d.Schedules)
                .HasForeignKey(s => s.DrawId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ScheduleMatch>()
                .HasOne(sm => sm.Schedule)
                .WithMany(s => s.ScheduledMatches)
                .HasForeignKey(sm => sm.ScheduleId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ScheduleMatch>()
                .HasOne(sm => sm.DrawMatch)
                .WithMany()
                .HasForeignKey(sm => sm.DrawMatchId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
