using System.Configuration;
using System.Reflection;
using Jorkol.GameDataApi.ApexLegends.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Debug;

namespace Jorkol.GameDataApi.ApexLegends.Db
{

    public class ApexDbContext : DbContext
    {
        public DbSet<ApexMatch> ApexMatches { get; set; }
        public DbSet<ApexCharacter> ApexCharacters { get; set; }
        public DbSet<ApexAccount> ApexAccounts { get; set; }
        private readonly ILogger<ApexDbContext> logger;

        public ApexDbContext(DbContextOptions<ApexDbContext> options, ILogger<ApexDbContext> logger) : base(options)
        {
            this.logger = logger;
        }
    }
}
