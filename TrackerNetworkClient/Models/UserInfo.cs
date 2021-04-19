using Newtonsoft.Json;
namespace GameDataApi.TrackerNetworkClient.Models
{
    public partial class UserInfo
    {
        [JsonProperty("userId")]
        public object UserId { get; set; }

        [JsonProperty("isPremium")]
        public bool IsPremium { get; set; }

        [JsonProperty("isVerified")]
        public bool IsVerified { get; set; }

        [JsonProperty("isInfluencer")]
        public bool IsInfluencer { get; set; }

        [JsonProperty("isPartner")]
        public bool IsPartner { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("customAvatarUrl")]
        public object CustomAvatarUrl { get; set; }

        [JsonProperty("customHeroUrl")]
        public object CustomHeroUrl { get; set; }

        [JsonProperty("socialAccounts")]
        public SocialAccount[] SocialAccounts { get; set; }

        [JsonProperty("pageviews")]
        public long Pageviews { get; set; }

        [JsonProperty("isSuspicious")]
        public object IsSuspicious { get; set; }
    }
}