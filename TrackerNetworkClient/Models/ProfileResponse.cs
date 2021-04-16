namespace GameDataApi.TrackerNetworkClient.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class ProfileResponse
    {
        [JsonProperty("data")]
        public ProfileResponseData Data { get; set; }
    }


    public partial class ProfileResponse
    {
        public static ProfileResponse FromJson(string json) => JsonConvert.DeserializeObject<ProfileResponse>(json, ProfileResponseConverter.Settings);
    }

    // public static class Serialize
    // {
    //     public static string ToJson(this ProfileResponse self) => JsonConvert.SerializeObject(self, ProfileResponseConverter.Settings);
    // }

    internal static class ProfileResponseConverter
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
