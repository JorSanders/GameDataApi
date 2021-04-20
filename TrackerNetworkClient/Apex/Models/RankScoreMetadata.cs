using System;
using Newtonsoft.Json;
namespace Jorkol.GameDataApi.TrackerNetworkClient.Models
{
    public partial class RankScoreMetadata
    {
        [JsonProperty("iconUrl")]
        public Uri IconUrl { get; set; }

        [JsonProperty("rankName")]
        public string RankName { get; set; }
    }

    public partial class RankScoreMetadata
    {
        [JsonProperty("rankScoreInfo")]
        public RankScoreInfo RankScoreInfo { get; set; }
    }
}