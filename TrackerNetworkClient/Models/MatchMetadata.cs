using Newtonsoft.Json;
namespace GameDataApi.TrackerNetworkClient.Models
{
    public partial class MatchMetadata
    {
        [JsonProperty("result")]
        public Duration Result { get; set; }

        [JsonProperty("endDate")]
        public Duration EndDate { get; set; }

        [JsonProperty("character")]
        public Character Character { get; set; }

        [JsonProperty("characterIconUrl")]
        public Duration CharacterIconUrl { get; set; }

        [JsonProperty("characterStats")]
        public Stats CharacterStats { get; set; }

        [JsonProperty("legend")]
        public Character Legend { get; set; }

        [JsonProperty("legendBigImageUrl")]
        public Duration LegendBigImageUrl { get; set; }

        [JsonProperty("legendStats")]
        public Stats LegendStats { get; set; }
    }
}