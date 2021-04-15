using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace GameDataApi.TrackerNetworkClient
{
    public class TrackerNetworkApexClient : TrackerNetworkBaseClient, ITrackerNetworkApexClient
    {
        public TrackerNetworkApexClient(String apiKey) : base(apiKey)
        {

        }

        public Task<String> Profile(String Platform, String PlatformUserIdentifier)
        {
            return httpClient.GetStringAsync("https://public-api.tracker.gg/v2/apex/standard/profile/origin/jormakker");
        }
    }
}
