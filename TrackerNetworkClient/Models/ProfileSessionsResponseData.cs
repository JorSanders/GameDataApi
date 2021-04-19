using Newtonsoft.Json;
namespace GameDataApi.TrackerNetworkClient.Models
{
    public partial class ProfileSessionsResponseData
    {
        [JsonProperty("expiryDate")]
        public string ExpiryDate { get; set; }

        [JsonProperty("items")]
        public Item[] Items { get; set; }
    }
}