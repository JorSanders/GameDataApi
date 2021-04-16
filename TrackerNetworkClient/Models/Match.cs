using Newtonsoft.Json;
namespace GameDataApi.TrackerNetworkClient.Models
{
    public partial class Match
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("metadata")]
        public MatchMetadata Metadata { get; set; }

        [JsonProperty("stats")]
        public MatchStats Stats { get; set; }
    }
}