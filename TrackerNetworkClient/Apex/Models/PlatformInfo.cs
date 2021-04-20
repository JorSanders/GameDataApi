using Newtonsoft.Json;
namespace Jorkol.GameDataApi.TrackerNetworkClient.Models
{
    public class PlatformInfo
    {
        [JsonProperty("platformSlug")]
        public string PlatformSlug { get; set; }

        [JsonProperty("platformUserId")]
        public string PlatformUserId { get; set; }

        [JsonProperty("platformUserHandle")]
        public string PlatformUserHandle { get; set; }

        [JsonProperty("platformUserIdentifier")]
        public string PlatformUserIdentifier { get; set; }

        [JsonProperty("avatarUrl")]
        public System.Uri AvatarUrl { get; set; }

        [JsonProperty("additionalParameters")]
        public object AdditionalParameters { get; set; }
    }
}