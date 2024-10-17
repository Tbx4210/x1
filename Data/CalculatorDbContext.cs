using CalculatorApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CalculatorApp.Data
{
    public class CalculatorDbContext : DbContext
    {
        public DbSet<Calculation> Calculations { get; set; }
        public DbSet<UserSettings> UserSettings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=calculator.db");
        }
    }
}
