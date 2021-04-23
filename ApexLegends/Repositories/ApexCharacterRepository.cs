using System.Collections.Generic;
using System.Linq;
using Jorkol.GameDataApi.ApexLegends.Db;
using Jorkol.GameDataApi.ApexLegends.Models;
using Jorkol.GameDataApi.Core;

namespace Jorkol.GameDataApi.ApexLegends.Repositories
{
    public class ApexCharacterRepository : BaseRepository<ApexCharacter>, IApexCharacterRepository
    {
        public ApexCharacterRepository(ApexDbContext apexDbContext) : base(apexDbContext)
        {
        }

        public ApexCharacter Find(string name)
        {
            return DbSet().Where(c => c.Name == name).FirstOrDefault();
        }
    }
}