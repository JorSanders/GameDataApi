using System;
using System.Collections.Generic;
using System.Linq;
using Jorkol.GameDataApi.ApexLegends.Db;
using Jorkol.GameDataApi.ApexLegends.Models;
using Jorkol.GameDataApi.Core;
using Microsoft.EntityFrameworkCore;

namespace Jorkol.GameDataApi.ApexLegends.Repositories
{
    public class ApexMatchRepository : BaseRepository<ApexMatch>, IApexMatchRepository
    {
        public ApexMatchRepository(ApexDbContext apexDbContext) : base(apexDbContext)
        {

        }
        public ApexMatch FindByTrnId(Guid trnId)
        {
            return DbSet().Where(m => m.TrnId == trnId).FirstOrDefault();
        }

        public IEnumerable<ApexMatch> FindByAccount(ApexAccount account)
        {
            return DbSet().Where(m => m.Account == account).Include(a => a.Character);
        }
    }
}