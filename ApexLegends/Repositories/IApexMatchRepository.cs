using System.Collections.Generic;
using System.Threading.Tasks;
using Jorkol.GameDataApi.ApexLegends.Models;
using Jorkol.GameDataApi.TrackerNetworkClient.Models;

namespace Jorkol.GameDataApi.ApexLegends.Repositories
{
    public interface IApexMatchRepository
    {
        IEnumerable<ApexMatch> All();
        IEnumerable<ApexMatch> CreateOrUpdate(IEnumerable<ApexMatch> apexMatches);
        ApexMatch CreateOrUpdate(ApexMatch apexMatches, bool save);
    }
}