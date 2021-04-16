using Newtonsoft.Json;
namespace GameDataApi.TrackerNetworkClient.Models
{

    public partial class Segment
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("attributes")]
        public SegmentAttributes Attributes { get; set; }

        [JsonProperty("metadata")]
        public SegmentMetadata Metadata { get; set; }

        [JsonProperty("expiryDate")]
        public string ExpiryDate { get; set; }

        [JsonProperty("stats")]
        public Stats Stats { get; set; }
    }
}