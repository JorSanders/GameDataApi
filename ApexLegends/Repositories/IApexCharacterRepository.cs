using Jorkol.GameDataApi.ApexLegends.Models;
using Jorkol.GameDataApi.Core;

namespace Jorkol.GameDataApi.ApexLegends.Repositories
{
    public interface IApexCharacterRepository : IBaseRepository<ApexCharacter>
    {
        ApexCharacter Find(string name);
    }
}