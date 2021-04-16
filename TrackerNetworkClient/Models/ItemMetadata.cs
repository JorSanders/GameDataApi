using Newtonsoft.Json;
namespace GameDataApi.TrackerNetworkClient.Models
{

    public partial class ItemMetadata
    {
        [JsonProperty("startDate")]
        public Duration StartDate { get; set; }

        [JsonProperty("endDate")]
        public Duration EndDate { get; set; }

        [JsonProperty("duration")]
        public Duration Duration { get; set; }

        [JsonProperty("isActive")]
        public IsActive IsActive { get; set; }
    }
}