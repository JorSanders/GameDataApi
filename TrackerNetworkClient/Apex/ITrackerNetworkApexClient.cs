using System.Text.Json;
using System.Threading.Tasks;
using Jorkol.GameDataApi.TrackerNetworkClient.Models;

namespace Jorkol.GameDataApi.TrackerNetworkClient
{
    public interface ITrackerNetworkApexClient
    {
        Task<ProfileResponseData> Profile(string Platform, string PlatformUserIdentifier);
        Task<ProfileSessionsResponseData> ProfileSessions(string Platform, string PlatformUserIdentifier);
    }
}