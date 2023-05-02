using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
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
        public DbSet<PhoneBook> PhoneBooks { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //string filePath = "../StaticData/countries.json";
            //if (!File.Exists(filePath))
            //    throw new Exception("countries json missings");

            //var countries = new List<Country>();
            //using (StreamReader reader = new StreamReader(filePath))
            //{
            //     string json = reader.ReadToEnd();
            //     countries = JsonConvert.DeserializeObject<List<Country>>(json).ToList();
            //}

                modelBuilder.Entity<Zone>()
                .HasKey(r => r.Id);
            modelBuilder.Entity<Zone>().HasIndex(p => new { p.UserId, p.Code,p.Name }).IsUnique();
            modelBuilder.Entity<Country>().HasKey(c => c.Id);
            //modelBuilder.Entity<Country>().HasData(countries.ToArray());
            modelBuilder.Entity<PhoneBook>().HasKey(p => p.Id);
            modelBuilder.Entity<PhoneBook>().HasIndex(p => new {p.Name,p.LastName,p.Phone,p.UserId});
        }
    }
}
