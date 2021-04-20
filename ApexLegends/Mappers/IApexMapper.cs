using System.Collections.Generic;
using Jorkol.GameDataApi.ApexLegends.Models;
using Jorkol.GameDataApi.TrackerNetworkClient.Models;

namespace Jorkol.GameDataApi.ApexLegends.Mappers
{
    public interface IApexMapper
    {
        IEnumerable<ApexMatch> ApexMatchesFromProfileSessions(ProfileSessionsResponseData profileSessionsResponseData);

        IEnumerable<ApexMatch> ApexMatchesFromSession(Session session);

        ApexCharacter ApexCharacterFromCharacter(Character character);
    }
}