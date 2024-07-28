using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FootballLeague.Models;
namespace FootballLeague.Data
{
    internal class FootballLeagueContext : DbContext
    {
        public DbSet<TeamStanding> teamStandings { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-HA8QE3N\\SQLEXPRESS;Database=FootballLeagueDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
