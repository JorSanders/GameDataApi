using Newtonsoft.Json;
namespace GameDataApi.TrackerNetworkClient.Models
{
    public class MetaDataValue
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("displayValue")]
        public string DisplayValue { get; set; }
    }
}