using System.Collections.Generic;
using System.Reflection;
using GameDataApi.Models;
using GameDataApi.TrackerNetworkClient.Models;

namespace GameDataApi.Mappers
{
    public class ApexMapper : IApexMapper
    {
        public List<ApexMatch> ApexMatchListFromProfileSessions(ProfileSessionsResponseData profileSessionsResponseData)
        {
            List<ApexMatch> ApexMatchList = new List<ApexMatch>();


            foreach (Session session in profileSessionsResponseData.Items)
            {
                ApexMatchList.AddRange(ApexMatchListFromSession(session));
            }

            return ApexMatchList;
        }

        public List<ApexMatch> ApexMatchListFromSession(Session session)
        {
            List<ApexMatch> apexMatchList = new List<ApexMatch>();

            foreach (Match match in session.Matches)
            {
                ApexMatch apexMatch = new ApexMatch();

                apexMatch.ApexMatchId = match?.Id;
                apexMatch.EndDateTime = match?.Metadata?.EndDate?.Value;
                apexMatch.Character = ApexCharacterFromCharacter(match?.Metadata?.Character);
                apexMatch.PlayerLevel = match.Stats?.Level?.Value;
                apexMatch.Kills = match.Stats?.Kills?.Value;
                apexMatch.Damage = match.Stats?.Damage?.Value;
                apexMatch.Headshots = match.Stats?.Headshots?.Value;
                apexMatch.Revives = match.Stats?.Revives?.Value;
                apexMatch.RankScore = match.Stats?.RankScore?.Value;
                apexMatch.RankScoreChange = match.Stats?.RankScoreChange?.Value;
                apexMatch.EyeEnemiesScanned = match.Stats?.EyeEnemiesScanned?.Value;
                apexMatch.SmokeGrenadeEnemiesHit = match.Stats?.SmokeGrenadeEnemiesHit?.Value;
                apexMatch.DomeDamageBlocked = match.Stats?.DomeDamageBlocked?.Value;
                apexMatch.RiftsSquadmatesPhased = match.Stats?.RiftsSquadmatesPhased?.Value;

                apexMatchList.Add(apexMatch);
            }

            return apexMatchList;
        }

        public ApexCharacter ApexCharacterFromCharacter(Character character)
        {
            return new ApexCharacter { ApexId = character.Value, Name = character.DisplayValue };
        }
    }
}