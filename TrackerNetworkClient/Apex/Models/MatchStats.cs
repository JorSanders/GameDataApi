using Newtonsoft.Json;
namespace GameDataApi.TrackerNetworkClient.Models
{
    public class MatchStats
    {
        [JsonProperty("level")]
        public MatchStat Level { get; set; }

        [JsonProperty("kills", NullValueHandling = NullValueHandling.Ignore)]
        public MatchStat Kills { get; set; }

        [JsonProperty("headshots", NullValueHandling = NullValueHandling.Ignore)]
        public MatchStat Headshots { get; set; }

        [JsonProperty("rankScore")]
        public RankScore RankScore { get; set; }

        [JsonProperty("rankScoreChange")]
        public MatchStat RankScoreChange { get; set; }

        [JsonProperty("damage", NullValueHandling = NullValueHandling.Ignore)]
        public MatchStat Damage { get; set; }

        [JsonProperty("specific2", NullValueHandling = NullValueHandling.Ignore)]
        public MatchStat Specific2 { get; set; }

        [JsonProperty("eyeEnemiesScanned", NullValueHandling = NullValueHandling.Ignore)]
        public MatchStat EyeEnemiesScanned { get; set; }

        [JsonProperty("specific3", NullValueHandling = NullValueHandling.Ignore)]
        public MatchStat Specific3 { get; set; }

        [JsonProperty("eyeTrapsScanned", NullValueHandling = NullValueHandling.Ignore)]
        public MatchStat EyeTrapsScanned { get; set; }

        [JsonProperty("smokeGrenadeEnemiesHit", NullValueHandling = NullValueHandling.Ignore)]
        public MatchStat SmokeGrenadeEnemiesHit { get; set; }

        [JsonProperty("revives", NullValueHandling = NullValueHandling.Ignore)]
        public MatchStat Revives { get; set; }

        [JsonProperty("domeDamageBlocked", NullValueHandling = NullValueHandling.Ignore)]
        public MatchStat DomeDamageBlocked { get; set; }

        [JsonProperty("specific1", NullValueHandling = NullValueHandling.Ignore)]
        public MatchStat Specific1 { get; set; }

        [JsonProperty("riftsSquadmatesPhased", NullValueHandling = NullValueHandling.Ignore)]
        public MatchStat RiftsSquadmatesPhased { get; set; }
    }
}