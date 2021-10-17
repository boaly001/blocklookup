
using BlockApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BlockApp.Data
{
    public class EthereumDbContext : DbContext
    {
        public EthereumDbContext(
            DbContextOptions<EthereumDbContext> options)
            : base(options)
        {
        }

        public DbSet<BlockApp.Models.EthereumTransaction> EthereumTransaction { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Set up keys
            modelBuilder.Entity<EthereumTransaction>().HasKey(c => new { c.BlockHash, c.BlockNumber });
        }
    }
}


