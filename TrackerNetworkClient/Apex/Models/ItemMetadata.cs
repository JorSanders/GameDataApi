using Newtonsoft.Json;
namespace Jorkol.GameDataApi.TrackerNetworkClient.Models
{
    public class ItemMetadata
    {
        [JsonProperty("startDate")]
        public MetaDataValue StartDate { get; set; }

        [JsonProperty("endDate")]
        public MetaDataValue EndDate { get; set; }

        [JsonProperty("duration")]
        public MetaDataValue Duration { get; set; }

        [JsonProperty("isActive")]
        public IsActive IsActive { get; set; }
    }
}