using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppUsingReact.Helpers.Configuration;
using WebAppUsingReact.Models;

namespace WebAppUsingReact.Entities
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Test>(new TestConfiguration().Configure);
        }
        public DbSet<Test> Tests { get; set; }
    }
}
