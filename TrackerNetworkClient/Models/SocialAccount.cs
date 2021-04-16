using Newtonsoft.Json;
namespace GameDataApi.TrackerNetworkClient.Models
{
    public partial class SocialAccount
    {
        [JsonProperty("platformSlug")]
        public string PlatformSlug { get; set; }

        [JsonProperty("platformUserHandle")]
        public string PlatformUserHandle { get; set; }

        [JsonProperty("platformUserIdentifier")]
        public string PlatformUserIdentifier { get; set; }
    }
}