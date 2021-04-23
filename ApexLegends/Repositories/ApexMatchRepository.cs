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
        public IEnumerable<ApexMatch> FindByAccount(ApexAccount account)
        {
            return DbSet().Where(m => m.Account == account).Include(a => a.Character);
        }

        public override ApexMatch CreateOrUpdate(ApexMatch match, bool save = true)
        {
            var result = DbSet().Where(m => m.TrnId == match.TrnId && m.Account == match.Account).FirstOrDefault();
            if (result != null)
            {
                match.Id = result.Id;

            }
            return base.CreateOrUpdate(match, save);
        }
    }
}