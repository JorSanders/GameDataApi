using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jorkol.GameDataApi.ApexLegends.Mappers;
using Jorkol.GameDataApi.ApexLegends.Models;
using Jorkol.GameDataApi.ApexLegends.Repositories;
using Jorkol.GameDataApi.TrackerNetworkClient;
using Jorkol.GameDataApi.TrackerNetworkClient.Models;
using Microsoft.Extensions.Logging;

namespace Jorkol.GameDataApi.ApexLegends.Services
{
    public class ApexMatchService : IApexMatchService
    {
        private readonly ILogger<ApexMatchService> logger;
        private readonly IApexMapper apexMapper;
        private readonly IApexMatchRepository apexMatchRepository;
        private readonly ITrackerNetworkApexClient trackerNetworkApexClient;

        public ApexMatchService(
            ILogger<ApexMatchService> logger,
            IApexMapper apexMapper,
            IApexMatchRepository apexMatchRepository,
            IApexAccountRepository apexAccountRepository,
            ITrackerNetworkApexClient trackerNetworkApexClient)
        {
            this.logger = logger;
            this.apexMapper = apexMapper;
            this.apexMatchRepository = apexMatchRepository;
            this.trackerNetworkApexClient = trackerNetworkApexClient;
        }

        public async Task<IEnumerable<ApexMatch>> ApexMatchesAsync(ApexAccount account)
        {
            List<ApexMatch> apexMatches = new List<ApexMatch>();
            var apexMatchesTrnTask = this.ApexMatchesFromTrnAsync(account);
            apexMatches.AddRange(this.ApexMatchesFromDb(account));
            var apexMatchesTrn = (await apexMatchesTrnTask).ToList<ApexMatch>();

            // apexMatchesTrn overwrites apexMatches
            return apexMatchesTrn.Concat(apexMatches).GroupBy(a => a.TrnId).Select(g => g.First());
        }

        public IEnumerable<ApexMatch> ApexMatchesFromDb(ApexAccount account)
        {
            return this.apexMatchRepository.FindByAccount(account);
        }

        public async Task<IEnumerable<ApexMatch>> ApexMatchesFromTrnAsync(ApexAccount account)
        {
            Task<ProfileSessionsResponseData> profileSessionsResponseTask = trackerNetworkApexClient.ProfileSessions(account.Platform, account.Name);

            IEnumerable<ApexMatch> apexMatches = this.apexMapper.ApexMatchesFromProfileSessions(await profileSessionsResponseTask, account);

            return this.apexMatchRepository.CreateOrUpdate(apexMatches);
        }
    }
}