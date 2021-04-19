using Newtonsoft.Json;
namespace GameDataApi.TrackerNetworkClient.Models
{
    public class ProfileSegmentAttributes
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }
    }
}