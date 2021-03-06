using Newtonsoft.Json;
namespace Jorkol.GameDataApi.TrackerNetworkClient.Models
{
    public class Stat
    {
        [JsonProperty("rank")]
        public long? Rank { get; set; }

        [JsonProperty("percentile")]
        public double Percentile { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("displayCategory")]
        public string DisplayCategory { get; set; }

        [JsonProperty("category")]
        public object Category { get; set; }

        [JsonProperty("metadata")]
        public MetadataClass Metadata { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("displayValue")]
        public string DisplayValue { get; set; }

        [JsonProperty("displayType")]
        public string DisplayType { get; set; }
    }
}