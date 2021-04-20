using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Jorkol.GameDataApi.ApexLegends
{

    public class ApexDbContext : DbContext
    {
        public DbSet<ApexMatch> ApexMatches { get; set; }
        public DbSet<ApexCharacter> ApexCharacter { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=dbname;user=dbuser;password=dbpass");
        }
    }
}
