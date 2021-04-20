using Newtonsoft.Json;
namespace Jorkol.GameDataApi.TrackerNetworkClient.Models
{
    public class SocialAccount
    {
        [JsonProperty("platformSlug")]
        public string PlatformSlug { get; set; }

        [JsonProperty("platformUserHandle")]
        public string PlatformUserHandle { get; set; }

        [JsonProperty("platformUserIdentifier")]
        public string PlatformUserIdentifier { get; set; }
    }
}