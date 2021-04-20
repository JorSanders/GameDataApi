using Newtonsoft.Json;
namespace Jorkol.GameDataApi.TrackerNetworkClient.Models
{
    public class ItemStats
    {
        [JsonProperty("rankScore")]
        public RankScore RankScore { get; set; }

        [JsonProperty("rankScoreChange")]
        public RankScore RankScoreChange { get; set; }

        [JsonProperty("revives", NullValueHandling = NullValueHandling.Ignore)]
        public RankScore Revives { get; set; }
    }
}