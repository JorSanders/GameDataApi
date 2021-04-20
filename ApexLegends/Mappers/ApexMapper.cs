using System;
using System.Collections.Generic;
using Jorkol.GameDataApi.ApexLegends.Models;
using Jorkol.GameDataApi.ApexLegends.Repositories;
using Jorkol.GameDataApi.TrackerNetworkClient.Models;

namespace Jorkol.GameDataApi.ApexLegends.Mappers
{
    public class ApexMapper : IApexMapper
    {
        private readonly IApexCharacterRepository apexCharacterRepository;

        public ApexMapper(IApexCharacterRepository apexCharacterRepository)
        {
            this.apexCharacterRepository = apexCharacterRepository;
        }

        public IEnumerable<ApexMatch> ApexMatchesFromProfileSessions(ProfileSessionsResponseData profileSessionsResponseData)
        {
            List<ApexMatch> ApexMatchList = new List<ApexMatch>();


            foreach (Session session in profileSessionsResponseData.Items)
            {
                ApexMatchList.AddRange(ApexMatchesFromSession(session));
            }

            return ApexMatchList;
        }

        public IEnumerable<ApexMatch> ApexMatchesFromSession(Session session)
        {
            List<ApexMatch> apexMatchList = new List<ApexMatch>();

            foreach (Match match in session.Matches)
            {
                ApexMatch apexMatch = new ApexMatch();

                apexMatch.ApexMatchId = Guid.Parse(match?.Id);
                apexMatch.EndDateTime = DateTime.Parse(match?.Metadata?.EndDate?.Value);
                apexMatch.Character = this.ApexCharacterFromCharacter(match?.Metadata?.Character);
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
            ApexCharacter apexCharacter = new ApexCharacter { ApexId = character.Value, Name = character.DisplayValue };
            return apexCharacterRepository.CreateOrUpdate(apexCharacter);
        }
    }
}