using System;
using Microsoft.EntityFrameworkCore;
using WeddingPlanner.Models;
namespace WeddingPlanner.Models
{
    public class WeddingContext : DbContext {
        public WeddingContext(DbContextOptions options) : base(options) { }

        public DbSet<RegUser> Users {get;set;}

        public DbSet<Wedding> Weddings {get;set;}

        public DbSet<Guests> Guests {get;set;}

        public void Create(Wedding w) {
            Weddings.Add(w);
            SaveChanges();
        }
    }
}