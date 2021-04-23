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

        public override ApexAccount Find(ApexAccount item)
        {
            return DbSet().Where(a => a.Name == item.Name && a.Platform == item.Platform).FirstOrDefault();
        }

        public override IEnumerable<ApexAccount> All()
        {
            return DbSet().Where(a => a.ApexMatches.Any());
        }
    }
}