using Newtonsoft.Json;
namespace GameDataApi.TrackerNetworkClient.Models
{


    public partial class SegmentMetadata
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("imageUrl", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ImageUrl { get; set; }

        [JsonProperty("tallImageUrl", NullValueHandling = NullValueHandling.Ignore)]
        public Uri TallImageUrl { get; set; }

        [JsonProperty("bgImageUrl", NullValueHandling = NullValueHandling.Ignore)]
        public Uri BgImageUrl { get; set; }

        [JsonProperty("isActive", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsActive { get; set; }
    }
}