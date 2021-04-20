using Newtonsoft.Json;
namespace Jorkol.GameDataApi.TrackerNetworkClient.Models
{
    public class Stats
    {
        [JsonProperty("value")]
        public string[] Value { get; set; }

        [JsonProperty("displayValue")]
        public string DisplayValue { get; set; }

        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public Stat Level { get; set; }

        [JsonProperty("kills")]
        public Stat Kills { get; set; }

        [JsonProperty("killsPerMatch", NullValueHandling = NullValueHandling.Ignore)]
        public Stat KillsPerMatch { get; set; }

        [JsonProperty("winningKills", NullValueHandling = NullValueHandling.Ignore)]
        public Stat WinningKills { get; set; }

        [JsonProperty("killsAsKillLeader", NullValueHandling = NullValueHandling.Ignore)]
        public Stat KillsAsKillLeader { get; set; }

        [JsonProperty("damage", NullValueHandling = NullValueHandling.Ignore)]
        public Stat Damage { get; set; }

        [JsonProperty("matchesPlayed", NullValueHandling = NullValueHandling.Ignore)]
        public Stat MatchesPlayed { get; set; }

        [JsonProperty("revives", NullValueHandling = NullValueHandling.Ignore)]
        public Stat Revives { get; set; }

        [JsonProperty("sniperKills", NullValueHandling = NullValueHandling.Ignore)]
        public Stat SniperKills { get; set; }

        [JsonProperty("rankScore", NullValueHandling = NullValueHandling.Ignore)]
        public RankScore RankScore { get; set; }

        [JsonProperty("beastOfTheHuntKills", NullValueHandling = NullValueHandling.Ignore)]
        public Stat BeastOfTheHuntKills { get; set; }

        [JsonProperty("grappleTravelDistance", NullValueHandling = NullValueHandling.Ignore)]
        public Stat GrappleTravelDistance { get; set; }

        [JsonProperty("voicesWarningsHeard", NullValueHandling = NullValueHandling.Ignore)]
        public Stat VoicesWarningsHeard { get; set; }
    }
}