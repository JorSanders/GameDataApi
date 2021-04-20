using System.Text.Json;
using System.Threading.Tasks;
using GameDataApi.TrackerNetworkClient.Models;

namespace GameDataApi.TrackerNetworkClient
{
    public interface ITrackerNetworkApexClient
    {
        Task<ProfileResponseData> Profile(string Platform, string PlatformUserIdentifier);
        Task<ProfileSessionsResponseData> ProfileSessions(string Platform, string PlatformUserIdentifier);
    }
}