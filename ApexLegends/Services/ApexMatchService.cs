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

        public ApexMatchService(ILogger<ApexMatchService> logger, IApexMapper apexMapper, IApexMatchRepository apexMatchRepository, ITrackerNetworkApexClient trackerNetworkApexClient)
        {
            this.logger = logger;
            this.apexMapper = apexMapper;
            this.apexMatchRepository = apexMatchRepository;
            this.trackerNetworkApexClient = trackerNetworkApexClient;
        }

        public async Task<IEnumerable<ApexMatch>> ApexMatchesAsync(string platform, string platformUserIdentifier)
        {
            List<ApexMatch> apexMatches = new List<ApexMatch>();
            var apexMatchesTrnTask = this.ApexMatchesFromTrnAsync(platform, platformUserIdentifier);
            apexMatches.AddRange(this.ApexMatchesFromDb(platform, platformUserIdentifier));
            var apexMatchesTrn = (await apexMatchesTrnTask).ToList<ApexMatch>();

            return apexMatchesTrn.Concat(apexMatches).GroupBy(a => a.ApexMatchId).Select(g => g.First());
        }

        public IEnumerable<ApexMatch> ApexMatchesFromDb(string platform, string platformUserIdentifier)
        {
            return this.apexMatchRepository.All();
        }

        public async Task<IEnumerable<ApexMatch>> ApexMatchesFromTrnAsync(string platform, string platformUserIdentifier)
        {
            Task<ProfileSessionsResponseData> profileSessionsResponseTask = trackerNetworkApexClient.ProfileSessions(platform, platformUserIdentifier);
            IEnumerable<ApexMatch> apexMatches = this.apexMapper.ApexMatchesFromProfileSessions(await profileSessionsResponseTask);
            return this.apexMatchRepository.CreateOrUpdate(apexMatches);
        }
    }
}