using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jorkol.GameDataApi.ApexLegends.Mappers;
using Jorkol.GameDataApi.ApexLegends.Models;
using Jorkol.GameDataApi.ApexLegends.Repositories;
using Jorkol.GameDataApi.Core;
using Jorkol.GameDataApi.TrackerNetworkClient;
using Jorkol.GameDataApi.TrackerNetworkClient.Models;
using Microsoft.Extensions.Logging;

namespace Jorkol.GameDataApi.ApexLegends.Services
{
    public class ApexMatchService : BaseService<IApexMatchRepository, ApexMatch>, IApexMatchService
    {
        private readonly ILogger<ApexMatchService> logger;
        private readonly IApexMapper apexMapper;
        private readonly ITrackerNetworkApexClient trackerNetworkApexClient;

        public ApexMatchService(
            ILogger<ApexMatchService> logger,
            IApexMapper apexMapper,
            ITrackerNetworkApexClient trackerNetworkApexClient,
            IApexMatchRepository repository) : base(repository)
        {
            this.logger = logger;
            this.apexMapper = apexMapper;
            this.trackerNetworkApexClient = trackerNetworkApexClient;
        }

        public async Task<IEnumerable<ApexMatch>> FromTrnAndDbAsync(ApexAccount account)
        {
            List<ApexMatch> apexMatches = new List<ApexMatch>();
            var apexMatchesTrnTask = this.FromTrnAsync(account);
            apexMatches.AddRange(this.FindByAccount(account));
            var apexMatchesTrn = await apexMatchesTrnTask;

            // apexMatchesTrn overwrites apexMatches
            return apexMatchesTrn.Concat(apexMatches).GroupBy(a => a.TrnId).Select(g => g.First());
        }

        public IEnumerable<ApexMatch> FindByAccount(ApexAccount account)
        {
            return this.repository.FindByAccount(account);
        }

        public async Task<IEnumerable<ApexMatch>> FromTrnAsync(ApexAccount account)
        {
            Task<ProfileSessionsResponseData> profileSessionsResponseTask = trackerNetworkApexClient.ProfileSessions(account.Platform, account.Name);

            var profileSessionsResponse = await profileSessionsResponseTask;

            bool hasActiveSession = profileSessionsResponse.Items.Where(s => s.Metadata.IsActive.Value).Any();

            if (hasActiveSession)
            {
                logger.LogInformation($"Account '{account.Name}' has an active session");
            }

            IEnumerable<ApexMatch> apexMatches = this.apexMapper.ApexMatchesFromProfileSessions(await profileSessionsResponseTask, account);

            return this.repository.CreateOrUpdate(apexMatches);
        }

        public async Task<IEnumerable<ApexMatch>> FromTrnAsync(IEnumerable<ApexAccount> accounts)
        {
            List<ApexMatch> matches = new List<ApexMatch>();
            foreach (var account in accounts)
            {
                matches.AddRange(await this.FromTrnAsync(account));
            }
            return matches;
        }

    }
}