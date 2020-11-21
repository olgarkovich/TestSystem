using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestSystem.Data;
using TestSystem.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Configuration;

namespace TestSystem.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<UserAnswer> UserAnswers { get; set; }
        public DbSet<Profile> Profiles { get; set; }
    }

    public class Factory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AppDbContext>();
            builder.UseSqlServer("Server=testsystem.database.windows.net;Database=testsystemdb;Trusted_Connection=false;MultipleActiveResultSets=true;User ID=testsystem;Password=7427Anna;Connection Lifetime=3;Max Pool Size=3;");
            return new AppDbContext(builder.Options);
        }
    }
}


