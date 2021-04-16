using Newtonsoft.Json;
namespace GameDataApi.TrackerNetworkClient.Models
{
    public partial class MatchStats
    {
        [JsonProperty("level")]
        public RankScore Level { get; set; }

        [JsonProperty("specific2", NullValueHandling = NullValueHandling.Ignore)]
        public RankScore Specific2 { get; set; }

        [JsonProperty("specific3", NullValueHandling = NullValueHandling.Ignore)]
        public RankScore Specific3 { get; set; }

        [JsonProperty("rankScore")]
        public StatsRankScore RankScore { get; set; }

        [JsonProperty("rankScoreChange")]
        public RankScore RankScoreChange { get; set; }

        [JsonProperty("eyeEnemiesScanned", NullValueHandling = NullValueHandling.Ignore)]
        public RankScore EyeEnemiesScanned { get; set; }

        [JsonProperty("eyeTrapsScanned", NullValueHandling = NullValueHandling.Ignore)]
        public RankScore EyeTrapsScanned { get; set; }

        [JsonProperty("smokeGrenadeEnemiesHit", NullValueHandling = NullValueHandling.Ignore)]
        public RankScore SmokeGrenadeEnemiesHit { get; set; }

        [JsonProperty("revives", NullValueHandling = NullValueHandling.Ignore)]
        public RankScore Revives { get; set; }

        [JsonProperty("domeDamageBlocked", NullValueHandling = NullValueHandling.Ignore)]
        public RankScore DomeDamageBlocked { get; set; }

        [JsonProperty("specific1", NullValueHandling = NullValueHandling.Ignore)]
        public RankScore Specific1 { get; set; }

        [JsonProperty("riftsSquadmatesPhased", NullValueHandling = NullValueHandling.Ignore)]
        public RankScore RiftsSquadmatesPhased { get; set; }
    }
}