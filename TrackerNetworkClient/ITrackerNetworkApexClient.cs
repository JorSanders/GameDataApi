using System.Text.Json;
using System.Threading.Tasks;
using QuickType;

namespace GameDataApi.TrackerNetworkClient
{
    public interface ITrackerNetworkApexClient
    {
        Task<ProfileResponse> Profile(string Platform, string PlatformUserIdentifier);
    }
}