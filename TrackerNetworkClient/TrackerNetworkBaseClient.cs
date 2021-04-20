using System;
using System.Net.Http;

namespace Jorkol.GameDataApi.TrackerNetworkClient
{
    public abstract class TrackerNetworkBaseClient : ITrackerNetworkBaseClient
    {
        protected readonly HttpClient httpClient;

        public TrackerNetworkBaseClient(String apiKey)
        {
            this.httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("TRN-Api-Key", apiKey);
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
        }

    }
}
