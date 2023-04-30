using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatsAppScrapper.Models.DataModels;

namespace WhatsappScrapper.DataAccess.Context
{
    public class UserDBContext : DbContext
    {
        public UserDBContext(DbContextOptions<UserDBContext> options)
           : base(options)
        {
        }

        public DbSet<Zone> Zones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Zone>()
                .HasKey(r => r.Id);
            modelBuilder.Entity<Zone>().HasIndex(p => new { p.UserId, p.Code,p.Name }).IsUnique();
        }
    }
}
