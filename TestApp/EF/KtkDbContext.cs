namespace Fadeev.PostgresEfTest.Ef
{
    using Microsoft.EntityFrameworkCore;
    using Fadeev.PostgresEfTest.Ef.Entities;
    
    /// <summary> Database context </summary>
    public partial class KtkDbContext : DbContext
    {
        private string connectionString;
        
        /// <summary> Accounts </summary>
        public DbSet<Account> Accounts { get; set; }
        
        /// <summary> DefectCategories </summary>
        public DbSet<DefectCategory> DefectCategories { get; set; }
        
        /// <summary> DefectTypes </summary>
        public DbSet<DefectType> DefectTypes { get; set; }
        
        /// <summary> InitialStates </summary>
        public DbSet<InitialState> InitialStates { get; set; }
        
        /// <summary> Scenarios </summary>
        public DbSet<Scenario> Scenarios { get; set; }
        
        /// <summary> ScenarioAutoSaves </summary>
        public DbSet<ScenarioAutoSave> ScenarioAutoSaves { get; set; }
        
        /// <summary> ScenarioCommonHistories </summary>
        public DbSet<ScenarioCommonHistory> ScenarioCommonHistories { get; set; }
        
        /// <summary> ScenarioHistories </summary>
        public DbSet<ScenarioHistory> ScenarioHistories { get; set; }
        
        /// <summary> Stands </summary>
        public DbSet<Stand> Stands { get; set; }
        
        /// <summary> TrainingJournals </summary>
        public DbSet<TrainingJournal> TrainingJournals { get; set; }
        
        /// <summary> Trends </summary>
        public DbSet<Trend> Trends { get; set; }
        
        /// <summary> Database context constructor </summary>
        public KtkDbContext(string connectionString)
        {
            this.connectionString = connectionString;
        }
        
        /// <summary> On model creating </summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ScenarioAutoSave>().HasKey(x => new { x.AccountId, x.ScenarioId });
            modelBuilder.Entity<Trend>().HasKey(x => new { x.Tag, x.TrainingJournalId });
        }
        
        /// <summary> On configuring </summary>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(this.connectionString);
        }
    }
}
