using System.Collections.Generic;
using System.Linq;

using Jorkol.GameDataApi.ApexLegends.Db;
using Jorkol.GameDataApi.ApexLegends.Models;
using Microsoft.Extensions.Logging;

namespace Jorkol.GameDataApi.ApexLegends.Repositories
{
    public class ApexMatchRepository : ApexBaseRepository<ApexMatch>, IApexMatchRepository
    {
        public ApexMatchRepository(ApexDbContext apexDbContext) : base(apexDbContext)
        {
        }
    }
}