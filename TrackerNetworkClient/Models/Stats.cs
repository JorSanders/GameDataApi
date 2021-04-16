using Newtonsoft.Json;
namespace GameDataApi.TrackerNetworkClient.Models
{
    public partial class Stats
    {
        [JsonProperty("value")]
        public string[] Value { get; set; }

        [JsonProperty("displayValue")]
        public string DisplayValue { get; set; }
    }
    public partial class Stats
    {
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public BeastOfTheHuntKills Level { get; set; }

        [JsonProperty("kills")]
        public BeastOfTheHuntKills Kills { get; set; }

        [JsonProperty("killsPerMatch", NullValueHandling = NullValueHandling.Ignore)]
        public BeastOfTheHuntKills KillsPerMatch { get; set; }

        [JsonProperty("winningKills", NullValueHandling = NullValueHandling.Ignore)]
        public BeastOfTheHuntKills WinningKills { get; set; }

        [JsonProperty("killsAsKillLeader", NullValueHandling = NullValueHandling.Ignore)]
        public BeastOfTheHuntKills KillsAsKillLeader { get; set; }

        [JsonProperty("damage", NullValueHandling = NullValueHandling.Ignore)]
        public BeastOfTheHuntKills Damage { get; set; }

        [JsonProperty("matchesPlayed", NullValueHandling = NullValueHandling.Ignore)]
        public BeastOfTheHuntKills MatchesPlayed { get; set; }

        [JsonProperty("revives", NullValueHandling = NullValueHandling.Ignore)]
        public BeastOfTheHuntKills Revives { get; set; }

        [JsonProperty("sniperKills", NullValueHandling = NullValueHandling.Ignore)]
        public BeastOfTheHuntKills SniperKills { get; set; }

        [JsonProperty("rankScore", NullValueHandling = NullValueHandling.Ignore)]
        public RankScore RankScore { get; set; }

        [JsonProperty("beastOfTheHuntKills", NullValueHandling = NullValueHandling.Ignore)]
        public BeastOfTheHuntKills BeastOfTheHuntKills { get; set; }

        [JsonProperty("grappleTravelDistance", NullValueHandling = NullValueHandling.Ignore)]
        public BeastOfTheHuntKills GrappleTravelDistance { get; set; }

        [JsonProperty("voicesWarningsHeard", NullValueHandling = NullValueHandling.Ignore)]
        public BeastOfTheHuntKills VoicesWarningsHeard { get; set; }
    }
}