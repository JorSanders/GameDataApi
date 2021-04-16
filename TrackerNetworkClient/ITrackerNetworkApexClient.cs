using System.Text.Json;
using System.Threading.Tasks;
using GameDataApi.TrackerNetworkClient.Models;

namespace GameDataApi.TrackerNetworkClient
{
    public interface ITrackerNetworkApexClient
    {
        Task<ProfileResponse> Profile(string Platform, string PlatformUserIdentifier);
        Task<ProfileSessionsResponse> ProfileSessions(string Platform, string PlatformUserIdentifier);

    }
}