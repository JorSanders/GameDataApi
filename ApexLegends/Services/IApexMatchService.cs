using System.Collections.Generic;
using System.Threading.Tasks;
using Jorkol.GameDataApi.ApexLegends.Models;
using Jorkol.GameDataApi.Core;
using Jorkol.GameDataApi.TrackerNetworkClient.Models;

namespace Jorkol.GameDataApi.ApexLegends.Services
{
    public interface IApexMatchService : IBaseService<ApexMatch>
    {
        Task<IEnumerable<ApexMatch>> FromTrnAsync(ApexAccount account);
        Task<IEnumerable<ApexMatch>> FromTrnAsync(IEnumerable<ApexAccount> accounts);
        IEnumerable<ApexMatch> FindByAccount(ApexAccount account);
        Task<IEnumerable<ApexMatch>> FromTrnAndDbAsync(ApexAccount account);
    }
}