// Generated by https://quicktype.io
//
// To change quicktype's target language, run command:
//
//   "Set quicktype target language"

namespace GameDataApi.TrackerNetworkClient.Models.A
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class ProfileSessionsResponse
    {
        [JsonProperty("data")]
        public Data Data { get; set; }
    }

    public partial class Data
    {
        [JsonProperty("expiryDate")]
        public string ExpiryDate { get; set; }

        [JsonProperty("items")]
        public Item[] Items { get; set; }
    }

    public partial class Item
    {
        [JsonProperty("metadata")]
        public ItemMetadata Metadata { get; set; }

        [JsonProperty("matches")]
        public Match[] Matches { get; set; }

        [JsonProperty("stats")]
        public ItemStats Stats { get; set; }

        [JsonProperty("playlists")]
        public object[] Playlists { get; set; }
    }

    public partial class Match
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("metadata")]
        public MatchMetadata Metadata { get; set; }

        [JsonProperty("stats")]
        public MatchStats Stats { get; set; }
    }

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

    public partial class Character
    {
        [JsonProperty("value")]
        public long Value { get; set; }

        [JsonProperty("displayValue")]
        public string DisplayValue { get; set; }
    }

    public partial class Duration
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("displayValue")]
        public string DisplayValue { get; set; }
    }

    public partial class Stats
    {
        [JsonProperty("value")]
        public string[] Value { get; set; }

        [JsonProperty("displayValue")]
        public string DisplayValue { get; set; }
    }

    public partial class MatchStats
    {
        [JsonProperty("level")]
        public RankScore Level { get; set; }

        [JsonProperty("specific2", NullValueHandling = NullValueHandling.Ignore)]
        public RankScore Specific2 { get; set; }

        [JsonProperty("specific3", NullValueHandling = NullValueHandling.Ignore)]
        public RankScore Specific3 { get; set; }

        [JsonProperty("rankScore")]
        public StatsRankScore RankScore { get; set; }

        [JsonProperty("rankScoreChange")]
        public RankScore RankScoreChange { get; set; }

        [JsonProperty("eyeEnemiesScanned", NullValueHandling = NullValueHandling.Ignore)]
        public RankScore EyeEnemiesScanned { get; set; }

        [JsonProperty("eyeTrapsScanned", NullValueHandling = NullValueHandling.Ignore)]
        public RankScore EyeTrapsScanned { get; set; }

        [JsonProperty("smokeGrenadeEnemiesHit", NullValueHandling = NullValueHandling.Ignore)]
        public RankScore SmokeGrenadeEnemiesHit { get; set; }

        [JsonProperty("revives", NullValueHandling = NullValueHandling.Ignore)]
        public RankScore Revives { get; set; }

        [JsonProperty("domeDamageBlocked", NullValueHandling = NullValueHandling.Ignore)]
        public RankScore DomeDamageBlocked { get; set; }

        [JsonProperty("specific1", NullValueHandling = NullValueHandling.Ignore)]
        public RankScore Specific1 { get; set; }

        [JsonProperty("riftsSquadmatesPhased", NullValueHandling = NullValueHandling.Ignore)]
        public RankScore RiftsSquadmatesPhased { get; set; }
    }

    public partial class RankScore
    {
        [JsonProperty("rank")]
        public object Rank { get; set; }

        [JsonProperty("percentile")]
        public object Percentile { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("displayCategory")]
        public string DisplayCategory { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("metadata")]
        public PurpleMetadata Metadata { get; set; }

        [JsonProperty("value")]
        public long Value { get; set; }

        [JsonProperty("displayValue")]
        public string DisplayValue { get; set; }

        [JsonProperty("displayType")]
        public string DisplayType { get; set; }
    }

    public partial class PurpleMetadata
    {
    }

    public partial class StatsRankScore
    {
        [JsonProperty("rank")]
        public object Rank { get; set; }

        [JsonProperty("percentile")]
        public object Percentile { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("displayCategory")]
        public string DisplayCategory { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("metadata")]
        public RankScoreMetadata Metadata { get; set; }

        [JsonProperty("value")]
        public long Value { get; set; }

        [JsonProperty("displayValue")]
        public string DisplayValue { get; set; }

        [JsonProperty("displayType")]
        public string DisplayType { get; set; }
    }

    public partial class RankScoreMetadata
    {
        [JsonProperty("rankScoreInfo")]
        public RankScoreInfo RankScoreInfo { get; set; }
    }

    public partial class RankScoreInfo
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public Uri Image { get; set; }
    }

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

    public partial class IsActive
    {
        [JsonProperty("value")]
        public bool Value { get; set; }

        [JsonProperty("displayValue")]
        public string DisplayValue { get; set; }
    }

    public partial class ItemStats
    {
        [JsonProperty("rankScore")]
        public RankScore RankScore { get; set; }

        [JsonProperty("rankScoreChange")]
        public RankScore RankScoreChange { get; set; }

        [JsonProperty("revives", NullValueHandling = NullValueHandling.Ignore)]
        public RankScore Revives { get; set; }
    }

    public partial class ProfileSessionsResponse
    {
        public static ProfileSessionsResponse FromJson(string json) => JsonConvert.DeserializeObject<ProfileSessionsResponse>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this ProfileSessionsResponse self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
