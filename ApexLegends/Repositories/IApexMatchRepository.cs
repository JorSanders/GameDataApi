using System.Collections.Generic;
using Jorkol.GameDataApi.ApexLegends.Models;

namespace Jorkol.GameDataApi.ApexLegends.Repositories
{
    public interface IApexMatchRepository : IApexBaseRepository<ApexMatch>
    {
        IEnumerable<ApexMatch> FindByAccount(ApexAccount account);
    }
}