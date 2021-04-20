using System.Collections.Generic;
using System.Threading.Tasks;
using Jorkol.GameDataApi.ApexLegends.Models;
using Jorkol.GameDataApi.TrackerNetworkClient.Models;

namespace Jorkol.GameDataApi.ApexLegends.Repositories
{
    public interface IApexCharacterRepository
    {
        ApexCharacter CreateOrUpdate(ApexCharacter apexCharacter);
    }
}