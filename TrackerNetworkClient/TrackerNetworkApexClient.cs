using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using QuickType;

namespace GameDataApi.TrackerNetworkClient
{
    public class TrackerNetworkApexClient : TrackerNetworkBaseClient, ITrackerNetworkApexClient
    {
        public TrackerNetworkApexClient(String apiKey) : base(apiKey)
        {

        }

        public async Task<ProfileResponse> Profile(String Platform, String PlatformUserIdentifier)
        {
            var response = await httpClient.GetAsync("https://public-api.tracker.gg/v2/apex/standard/profile/origin/jormakker");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            ProfileResponse result = JsonConvert.DeserializeObject<ProfileResponse>(content);

            return result;
        }
    }
}
