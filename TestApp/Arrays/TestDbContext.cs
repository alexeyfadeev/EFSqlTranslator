namespace RedAlliance.Orm.Sql
{
    using Microsoft.EntityFrameworkCore;
    using RedAlliance.Orm.Sql.Entities;
    
    /// <summary> Database context </summary>
    public partial class TestDbContext : DbContext
    {
        private string connectionString;
        
        /// <summary> NumberArrays </summary>
        public DbSet<NumberArray> NumberArrays { get; set; }
        
        /// <summary> TextArrays </summary>
        public DbSet<TextArray> TextArrays { get; set; }
        
        /// <summary> TextRecords </summary>
        public DbSet<TextRecord> TextRecords { get; set; }
        
        /// <summary> Database context constructor </summary>
        public TestDbContext(string connectionString)
        {
            this.connectionString = connectionString;
        }
        
        /// <summary> On configuring </summary>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(this.connectionString);
        }
    }
}
