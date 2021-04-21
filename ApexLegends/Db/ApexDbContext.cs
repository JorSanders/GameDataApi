using System.Configuration;
using System.Reflection;
using Jorkol.GameDataApi.ApexLegends.Models;
using Microsoft.EntityFrameworkCore;

namespace Jorkol.GameDataApi.ApexLegends.Db
{

    public class ApexDbContext : DbContext
    {
        public DbSet<ApexMatch> ApexMatches { get; set; }
        public DbSet<ApexCharacter> ApexCharacter { get; set; }
        public DbSet<ApexAccount> ApexAccount { get; set; }

        public ApexDbContext(DbContextOptions<ApexDbContext> options) : base(options)
        {
        }
    }
}
