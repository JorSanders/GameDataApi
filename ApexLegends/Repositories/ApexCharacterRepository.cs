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

        public ApexCharacter FindOrCreate(string name, long trnId)
        {
            ApexCharacter character = DbSet().Where(c => c.Name == name && c.TrnId == trnId).FirstOrDefault();
            if (character == null)
            {
                character = new ApexCharacter { Name = name, TrnId = trnId };
                character = CreateOrUpdate(character);
            }
            return character;
        }
    }
}