using System.Threading.Tasks;

namespace GameDataApi.TrackerNetworkClient
{
    public interface ITrackerNetworkApexClient
    {
        Task<string> Profile(string Platform, string PlatformUserIdentifier);
    }
}