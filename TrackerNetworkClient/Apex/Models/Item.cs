using Newtonsoft.Json;
namespace GameDataApi.TrackerNetworkClient.Models
{
    public class Session
    {
        [JsonProperty("metadata")]
        public ItemMetadata Metadata { get; set; }

        [JsonProperty("matches")]
        public Match[] Matches { get; set; }

        [JsonProperty("stats")]
        public ItemStats Stats { get; set; }

        [JsonProperty("playlists")]
        public object[] Playlists { get; set; }
    }
}