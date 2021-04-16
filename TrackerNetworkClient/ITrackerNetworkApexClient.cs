using System.Text.Json;
using System.Threading.Tasks;
using GameDataApi.TrackerNetworkClient.ProfileResponse;

namespace GameDataApi.TrackerNetworkClient
{
    public interface ITrackerNetworkApexClient
    {
        Task<GameDataApi.TrackerNetworkClient.ProfileResponse.ProfileResponse> Profile(string Platform, string PlatformUserIdentifier);
    }
}