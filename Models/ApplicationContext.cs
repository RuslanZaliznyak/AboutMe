using System;
using Microsoft.EntityFrameworkCore;

namespace AboutMe.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Article> Articles { get; set; } = null!;

        public ApplicationContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=about-me.db");
        }
    }
}
