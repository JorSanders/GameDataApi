using Newtonsoft.Json;
namespace Jorkol.GameDataApi.TrackerNetworkClient.Models
{
    public class MatchMetadata
    {
        [JsonProperty("result")]
        public MetaDataValue Result { get; set; }

        [JsonProperty("endDate")]
        public MetaDataValue EndDate { get; set; }

        [JsonProperty("character")]
        public Character Character { get; set; }

        [JsonProperty("characterIconUrl")]
        public MetaDataValue CharacterIconUrl { get; set; }

        [JsonProperty("characterStats")]
        public Stats CharacterStats { get; set; }

        [JsonProperty("legend")]
        public Character Legend { get; set; }

        [JsonProperty("legendBigImageUrl")]
        public MetaDataValue LegendBigImageUrl { get; set; }

        [JsonProperty("legendStats")]
        public Stats LegendStats { get; set; }
    }
}