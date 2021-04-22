using System.Collections.Generic;
using System.Linq;
using Jorkol.GameDataApi.ApexLegends.Db;
using Jorkol.GameDataApi.ApexLegends.Models;
using Microsoft.EntityFrameworkCore;

namespace Jorkol.GameDataApi.ApexLegends.Repositories
{
    public class ApexMatchRepository : ApexBaseRepository<ApexMatch>, IApexMatchRepository
    {
        public ApexMatchRepository(ApexDbContext apexDbContext) : base(apexDbContext)
        {

        }
        public override ApexMatch Find(ApexMatch item)
        {
            return DbSet().Where(m => m.TrnId == item.TrnId).FirstOrDefault();
        }

        public IEnumerable<ApexMatch> FindByAccount(ApexAccount account)
        {
            return DbSet().Where(m => m.Account == account).Include(a => a.Character);
        }
    }
}