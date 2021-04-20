using Newtonsoft.Json;
namespace GameDataApi.TrackerNetworkClient.Models
{
    public class ProfileSessionsResponseData
    {
        [JsonProperty("expiryDate")]
        public string ExpiryDate { get; set; }

        [JsonProperty("items")]
        public Session[] Items { get; set; }
    }
}