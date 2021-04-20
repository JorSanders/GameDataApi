using System.Collections.Generic;
using System.Reflection;
using Jorkol.GameDataApi.Models;
using Jorkol.GameDataApi.TrackerNetworkClient.Models;

namespace Jorkol.GameDataApi.Mappers
{
    public interface IApexMapper
    {
        List<ApexMatch> ApexMatchListFromProfileSessions(ProfileSessionsResponseData profileSessionsResponseData);

        List<ApexMatch> ApexMatchListFromSession(Session session);

        ApexCharacter ApexCharacterFromCharacter(Character character);
    }
}