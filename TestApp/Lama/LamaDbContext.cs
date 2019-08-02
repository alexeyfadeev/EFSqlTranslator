namespace Lama.ContractorPortal.Sql
{
    using Microsoft.EntityFrameworkCore;
    using Lama.ContractorPortal.Sql.Entities;
    
    /// <summary> Database context </summary>
    public partial class LamaDbContext : DbContext
    {
        private string connectionString;
        
        /// <summary> CategoryLists </summary>
        public DbSet<CategoryList> CategoryLists { get; set; }
        
        /// <summary> Contacts </summary>
        public DbSet<Contact> Contacts { get; set; }
        
        /// <summary> ContractLists </summary>
        public DbSet<ContractList> ContractLists { get; set; }
        
        /// <summary> Messages </summary>
        public DbSet<Message> Messages { get; set; }
        
        /// <summary> Offers </summary>
        public DbSet<Offer> Offers { get; set; }
        
        /// <summary> OfferLines </summary>
        public DbSet<OfferLine> OfferLines { get; set; }
        
        /// <summary> Partners </summary>
        public DbSet<Partner> Partners { get; set; }
        
        /// <summary> Products </summary>
        public DbSet<Product> Products { get; set; }
        
        /// <summary> Regions </summary>
        public DbSet<Region> Regions { get; set; }
        
        /// <summary> Database context constructor </summary>
        public LamaDbContext(string connectionString)
        {
            this.connectionString = connectionString;
        }
        
        /// <summary> On model creating </summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Offer>().HasKey(x => new { x.Id, x.Version });
            modelBuilder.Entity<OfferLine>().HasKey(x => new { x.OfferId, x.ProductCode, x.RegionId, x.Version });
            modelBuilder.Entity<Product>().HasKey(x => new { x.PartnerId, x.ProductCode, x.Version });
        }
        
        /// <summary> On configuring </summary>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.connectionString);
        }
    }
}
