using Microsoft.EntityFrameworkCore;
using WhatsAppScrapper.Models.DataModels;
namespace WhatsappScrapper.DataAccess.Context
{
    public class WhatsappDBContext : DbContext
    {
        public WhatsappDBContext(DbContextOptions<WhatsappDBContext> options)
            : base(options)
        {
        }

        public DbSet<RegisterNumber> RegisterNumbers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RegisterNumber>()
                .HasKey(r => r.Id);
        }
    }

}
