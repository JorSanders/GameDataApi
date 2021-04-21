using System.Collections.Generic;
using System.Linq;

using Jorkol.GameDataApi.ApexLegends.Db;
using Jorkol.GameDataApi.ApexLegends.Models;
using Microsoft.Extensions.Logging;

namespace Jorkol.GameDataApi.ApexLegends.Repositories
{
    public class ApexCharacterRepository : ApexBaseRepository<ApexCharacter>, IApexCharacterRepository
    {
        public ApexCharacterRepository(ApexDbContext apexDbContext) : base(apexDbContext)
        {
        }
    }
}