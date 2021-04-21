using System.Collections.Generic;
using System.Threading.Tasks;
using Jorkol.GameDataApi.ApexLegends.Models;
using Jorkol.GameDataApi.TrackerNetworkClient.Models;

namespace Jorkol.GameDataApi.ApexLegends.Services
{
    public interface IApexMatchService
    {
        Task<IEnumerable<ApexMatch>> ApexMatchesFromTrnAsync(ApexAccount account);
        IEnumerable<ApexMatch> ApexMatchesFromDb(ApexAccount account);
        Task<IEnumerable<ApexMatch>> ApexMatchesAsync(ApexAccount account);
    }
}