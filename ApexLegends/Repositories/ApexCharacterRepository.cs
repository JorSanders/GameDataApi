using System.Collections.Generic;
using System.Linq;

using Jorkol.GameDataApi.ApexLegends.Db;
using Jorkol.GameDataApi.ApexLegends.Models;
using Microsoft.Extensions.Logging;

namespace Jorkol.GameDataApi.ApexLegends.Repositories
{
    public class ApexCharacterRepository : ApexBaseRepository, IApexCharacterRepository
    {
        public ApexCharacterRepository(ILogger<ApexCharacterRepository> logger, ApexDbContext apexDbContext) : base(logger, apexDbContext)
        {
        }

        public ApexCharacter CreateOrUpdate(ApexCharacter apexCharacter)
        {
            ApexCharacter result = apexDbContext.ApexCharacter.Find(apexCharacter.ApexId);
            if (result == null)
            {
                result = apexDbContext.ApexCharacter.Add(apexCharacter).Entity;
            }
            return result;
        }
    }
}