using System.Collections.Generic;
using System.Linq;

using Jorkol.GameDataApi.ApexLegends.Db;
using Jorkol.GameDataApi.ApexLegends.Models;
using Microsoft.Extensions.Logging;

namespace Jorkol.GameDataApi.ApexLegends.Repositories
{
    public abstract class ApexBaseRepository : IApexBaseRepository
    {
        protected readonly ILogger<ApexBaseRepository> logger;
        protected readonly ApexDbContext apexDbContext;

        protected ApexBaseRepository(ILogger<ApexBaseRepository> logger)
        {
            this.logger = logger;
            this.apexDbContext = new ApexDbContext();
        }
    }
}