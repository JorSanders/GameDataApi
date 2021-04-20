using System.Collections.Generic;
using System.Threading.Tasks;
using Jorkol.GameDataApi.ApexLegends.Models;
using Jorkol.GameDataApi.TrackerNetworkClient.Models;

namespace Jorkol.GameDataApi.ApexLegends.Services
{
    public interface IApexMatchService
    {
        Task<IEnumerable<ApexMatch>> ApexMatchesFromTrnAsync(string platform, string platformUserIdentifier);
        IEnumerable<ApexMatch> ApexMatchesFromDb(string platform, string platformUserIdentifier);
        Task<IEnumerable<ApexMatch>> ApexMatchesAsync(string platform, string platformUserIdentifier);
    }
}