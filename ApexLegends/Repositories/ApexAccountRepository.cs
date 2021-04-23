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

        public ApexAccount FindOrCreate(string name, string platform)
        {
            ApexAccount account = DbSet().Where(a => a.Name == name && a.Platform == platform).FirstOrDefault();
            if (account == null)
            {
                account = new ApexAccount { Name = name, Platform = platform };
                account = CreateOrUpdate(account);
            }
            return account;
        }

        public IEnumerable<ApexAccount> WithMatches()
        {
            return DbSet().Where(a => a.ApexMatches.Any()).ToList();
        }
    }
}