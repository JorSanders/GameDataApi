using System.Collections.Generic;
using System.Reflection;
using GameDataApi.Models;
using GameDataApi.TrackerNetworkClient.Models;

namespace GameDataApi.Mappers
{
    public interface IApexMapper
    {
        List<ApexMatch> ApexMatchListFromProfileSessions(ProfileSessionsResponseData profileSessionsResponseData);

        List<ApexMatch> ApexMatchListFromSession(Session session);

        ApexCharacter ApexCharacterFromCharacter(Character character);
    }
}