using Newtonsoft.Json;
namespace GameDataApi.TrackerNetworkClient.Models
{
    public class ProfileSegment
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("attributes")]
        public ProfileSegmentAttributes Attributes { get; set; }

        [JsonProperty("metadata")]
        public ProfileSegmentMetadata Metadata { get; set; }

        [JsonProperty("expiryDate")]
        public string ExpiryDate { get; set; }

        [JsonProperty("stats")]
        public ProfileSegmentStats Stats { get; set; }
    }
}