using System.Collections.Generic;
using Jorkol.GameDataApi.ApexLegends.Models;
using Jorkol.GameDataApi.TrackerNetworkClient.Models;

namespace Jorkol.GameDataApi.ApexLegends.Mappers
{
    public interface IApexMapper
    {
        IEnumerable<ApexMatch> ApexMatchesFromProfileSessions(ProfileSessionsResponseData profileSessionsResponseData, ApexAccount account);

        IEnumerable<ApexMatch> ApexMatchesFromSession(Session session, ApexAccount account);

        ApexCharacter ApexCharacterFromCharacter(Character character);
    }
}