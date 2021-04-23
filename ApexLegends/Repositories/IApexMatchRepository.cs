using System.Collections.Generic;
using Jorkol.GameDataApi.ApexLegends.Models;
using Jorkol.GameDataApi.Core;

namespace Jorkol.GameDataApi.ApexLegends.Repositories
{
    public interface IApexMatchRepository : IBaseRepository<ApexMatch>
    {
        IEnumerable<ApexMatch> FindByAccount(ApexAccount account);
    }
}