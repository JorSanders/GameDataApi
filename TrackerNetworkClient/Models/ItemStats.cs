using Newtonsoft.Json;
namespace GameDataApi.TrackerNetworkClient.Models
{

    public partial class ItemStats
    {
        [JsonProperty("rankScore")]
        public RankScore RankScore { get; set; }

        [JsonProperty("rankScoreChange")]
        public RankScore RankScoreChange { get; set; }

        [JsonProperty("revives", NullValueHandling = NullValueHandling.Ignore)]
        public RankScore Revives { get; set; }
    }
}