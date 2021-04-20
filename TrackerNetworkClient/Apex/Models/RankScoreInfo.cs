using System;
using Newtonsoft.Json;
namespace GameDataApi.TrackerNetworkClient.Models
{

    public class RankScoreInfo
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public Uri Image { get; set; }
    }
}