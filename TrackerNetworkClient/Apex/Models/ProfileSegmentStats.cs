using Newtonsoft.Json;
namespace GameDataApi.TrackerNetworkClient.Models
{
    public class ProfileSegmentStats
    {
        [JsonProperty("value")]
        public string[] Value { get; set; }

        [JsonProperty("displayValue")]
        public string DisplayValue { get; set; }
    }

}