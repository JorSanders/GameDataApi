using Newtonsoft.Json;
namespace GameDataApi.TrackerNetworkClient.Models
{
    public class DataMetadata
    {
        [JsonProperty("currentSeason")]
        public long CurrentSeason { get; set; }

        [JsonProperty("activeLegend")]
        public string ActiveLegend { get; set; }

        [JsonProperty("activeLegendName")]
        public string ActiveLegendName { get; set; }

        [JsonProperty("activeLegendStats")]
        public string[] ActiveLegendStats { get; set; }
    }

}