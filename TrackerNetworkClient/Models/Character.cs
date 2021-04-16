using Newtonsoft.Json;
namespace GameDataApi.TrackerNetworkClient.Models
{
    public partial class Character
    {
        [JsonProperty("value")]
        public long Value { get; set; }

        [JsonProperty("displayValue")]
        public string DisplayValue { get; set; }
    }
}