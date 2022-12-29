using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using GISMO.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace GISMO.Data
{
    public class AppDbContext : IdentityDbContext

    {
        private IConfiguration _configuration;

        public AppDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connectionString = _configuration.GetConnectionString("DefaultConnection");
            options.UseSqlServer(connectionString);
            options.EnableSensitiveDataLogging(true);
        }

        // Cloud Dbase.Tables
        public DbSet<Client> Clientele { get; set; }
        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<Vessels> Vessels { get; set; }
        public DbSet<Onboard> Crews { get; set; }
        public DbSet<Planner> Planner { get; set; }
        public DbSet<SeaService> SeaServices { get; set; }
        public DbSet<VslExperience> svExperience { get; set; }
        public DbSet<Appraisal> Appraisals { get; set; }
        public DbSet<Analytics> OwnerGraph { get; set; }
        public DbSet<AnaClientVessels> svAnaClientVessels { get; set; }
        public DbSet<Circular> Circulars { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<AnaClientEmbarked> svAnaClientEmbarked { get; set; }
    }

   
}
