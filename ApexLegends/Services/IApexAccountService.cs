using System.Collections.Generic;
using System.Threading.Tasks;
using Jorkol.GameDataApi.ApexLegends.Models;
using Jorkol.GameDataApi.TrackerNetworkClient.Models;

namespace Jorkol.GameDataApi.ApexLegends.Services
{
    public interface IApexAccountService
    {
        IEnumerable<ApexAccount> ApexAccounts();
        ApexAccount FindOrCreate(string name, string platform);
    }
}