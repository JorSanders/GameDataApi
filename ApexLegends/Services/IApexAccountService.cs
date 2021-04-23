using System.Collections.Generic;
using System.Threading.Tasks;
using Jorkol.GameDataApi.ApexLegends.Models;
using Jorkol.GameDataApi.Core;
using Jorkol.GameDataApi.TrackerNetworkClient.Models;

namespace Jorkol.GameDataApi.ApexLegends.Services
{
    public interface IApexAccountService : IBaseService<ApexAccount>
    {
        IEnumerable<ApexAccount> WithMatches();
    }
}