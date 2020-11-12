using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestSystem.Models;

namespace TestSystem.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<DbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<OpenQuestion> OpenQuestions { get; set; }
        public DbSet<CloseQuestion> CloseQuestions { get; set; }
    }
}
