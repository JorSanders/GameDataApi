using System.Collections.Generic;
using System.Linq;

using Jorkol.GameDataApi.ApexLegends.Db;
using Jorkol.GameDataApi.ApexLegends.Models;
using Jorkol.GameDataApi.Core;

namespace Jorkol.GameDataApi.ApexLegends.Repositories
{
    public class ApexAccountRepository : BaseRepository<ApexAccount>, IApexAccountRepository
    {
        public ApexAccountRepository(ApexDbContext apexDbContext) : base(apexDbContext)
        {
        }

        public ApexAccount Find(string name, string platform)
        {
            return DbSet().Where(a => a.Name == name && a.Platform == platform).FirstOrDefault();
        }

        public IEnumerable<ApexAccount> WithMatches()
        {
            return DbSet().Where(a => a.ApexMatches.Any()).ToList();
        }
    }
}