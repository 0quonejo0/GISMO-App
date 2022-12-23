using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using GISMO.Data.Entities;

namespace GISMO.Data
{
    public class AppDbContext : DbContext
    {
        private IConfiguration _configuration;

        public AppDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connectionString = _configuration.GetConnectionString("CloudConnString");
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
    }

    // Bong: Additional DbContext for Agency API
    public class LAppDcontext : DbContext
    {
        private IConfiguration _configurationLocal;
        public LAppDcontext(IConfiguration configuration)
        {
            _configurationLocal = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connectionString = _configurationLocal.GetConnectionString("LocalConnString");
            options.UseSqlServer(connectionString);
            options.EnableSensitiveDataLogging(true);
        }

        // Local Dbase.Tables
        public DbSet<Appraisal> Appraisals { get; set; }
        public DbSet<_LAgencyCrew> Crews { get; set; }
    }
}
