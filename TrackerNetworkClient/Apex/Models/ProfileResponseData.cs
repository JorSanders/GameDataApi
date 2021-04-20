using Jorkol.GameDataApi.TrackerNetworkClient.Models;
using Newtonsoft.Json;
namespace Jorkol.GameDataApi.TrackerNetworkClient.Models
{

    public class ProfileResponseData
    {
        [JsonProperty("platformInfo")]
        public PlatformInfo PlatformInfo { get; set; }

        [JsonProperty("userInfo")]
        public UserInfo UserInfo { get; set; }

        [JsonProperty("metadata")]
        public DataMetadata Metadata { get; set; }

        [JsonProperty("segments")]
        public ProfileSegment[] Segments { get; set; }

        [JsonProperty("availableSegments")]
        public AvailableSegment[] AvailableSegments { get; set; }

        [JsonProperty("expiryDate")]
        public string ExpiryDate { get; set; }
    }
}