using Newtonsoft.Json;
namespace Jorkol.GameDataApi.TrackerNetworkClient.Models
{
    public class IsActive
    {
        [JsonProperty("value")]
        public bool Value { get; set; }

        [JsonProperty("displayValue")]
        public string DisplayValue { get; set; }
    }
}