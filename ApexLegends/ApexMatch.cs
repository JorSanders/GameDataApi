using System;

namespace Jorkol.GameDataApi.ApexLegends
{
    public class ApexMatch
    {
        public Guid ApexMatchId { get; set; }
        public DateTime EndDateTime { get; set; }
        public ApexCharacter Character { get; set; }
        public long? PlayerLevel { get; set; }
        public long? Kills { get; set; }
        public long? Damage { get; set; }
        public long? Headshots { get; set; }
        public long? Revives { get; set; }
        public long? RankScore { get; set; }
        public long? RankScoreChange { get; set; }
        public long? EyeEnemiesScanned { get; set; }
        public long? SmokeGrenadeEnemiesHit { get; set; }
        public long? DomeDamageBlocked { get; set; }
        public long? RiftsSquadmatesPhased { get; set; }
    }
}