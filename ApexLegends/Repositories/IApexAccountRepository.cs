using System.Collections.Generic;
using Jorkol.GameDataApi.ApexLegends.Models;
using Jorkol.GameDataApi.Core;

namespace Jorkol.GameDataApi.ApexLegends.Repositories
{
    public interface IApexAccountRepository : IBaseRepository<ApexAccount>
    {
        IEnumerable<ApexAccount> WithMatches();
    }
}