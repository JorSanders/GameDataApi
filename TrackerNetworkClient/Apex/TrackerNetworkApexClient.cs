using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using GameDataApi.TrackerNetworkClient.Models;
using GameDataApi.TrackerNetworkClient.Responses;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace GameDataApi.TrackerNetworkClient
{
    public class TrackerNetworkApexClient : TrackerNetworkBaseClient, ITrackerNetworkApexClient
    {
        public TrackerNetworkApexClient(String apiKey) : base(apiKey)
        {

        }

        public async Task<ProfileResponseData> Profile(String platform, String platformUserIdentifier)
        {
            var response = await httpClient.GetAsync($"https://public-api.tracker.gg/v2/apex/standard/profile/{platform}/{platformUserIdentifier}");
            string content = await response.Content.ReadAsStringAsync();
            response.EnsureSuccessStatusCode();

            return JsonConvert.DeserializeObject<ProfileResponse>(content).Data;
        }
        public async Task<ProfileSessionsResponseData> ProfileSessions(String platform, String platformUserIdentifier)
        {
            var response = await httpClient.GetAsync($"https://public-api.tracker.gg/v2/apex/standard/profile/{platform}/{platformUserIdentifier}/sessions");
            string content = await response.Content.ReadAsStringAsync();
            response.EnsureSuccessStatusCode();

            return JsonConvert.DeserializeObject<ProfileSessionsResponse>(content).Data;
        }
    }
}
