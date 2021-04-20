namespace GameDataApi.TrackerNetworkClient.Responses
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using GameDataApi.TrackerNetworkClient.Models;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class ProfileSessionsResponse
    {
        [JsonProperty("data")]
        public ProfileSessionsResponseData Data { get; set; }
    }

    public partial class ProfileSessionsResponse
    {
        public static ProfileSessionsResponse FromJson(string json) => JsonConvert.DeserializeObject<ProfileSessionsResponse>(json, ProfileSessionsResponseConverter.Settings);
    }

    // public static class Serialize
    // {
    //     public static string ToJson(this ProfileSessionsResponse self) => JsonConvert.SerializeObject(self, ProfileSessionsResponseConverter.Settings);
    // }

    internal static class ProfileSessionsResponseConverter
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
