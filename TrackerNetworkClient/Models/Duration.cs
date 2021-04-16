using Newtonsoft.Json;
namespace GameDataApi.TrackerNetworkClient.Models
{

    public partial class Duration
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("displayValue")]
        public string DisplayValue { get; set; }
    }
}