using System.Collections.Generic;
using Jorkol.GameDataApi.TrackerNetworkClient.Models;

namespace Jorkol.GameDataApi.ApexLegends
{
    public interface IApexMapper
    {
        List<ApexMatch> ApexMatchListFromProfileSessions(ProfileSessionsResponseData profileSessionsResponseData);

        List<ApexMatch> ApexMatchListFromSession(Session session);

        ApexCharacter ApexCharacterFromCharacter(Character character);
    }
}