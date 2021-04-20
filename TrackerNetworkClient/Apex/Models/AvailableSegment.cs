using Newtonsoft.Json;
namespace GameDataApi.TrackerNetworkClient.Models
{
    public class AvailableSegment
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("attributes")]
        public MetadataClass Attributes { get; set; }

        [JsonProperty("metadata")]
        public MetadataClass Metadata { get; set; }
    }
}