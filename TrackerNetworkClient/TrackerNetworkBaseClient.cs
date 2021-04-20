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
