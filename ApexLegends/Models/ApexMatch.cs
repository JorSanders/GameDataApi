using System;
using System.ComponentModel.DataAnnotations;
using Jorkol.GameDataApi.Core;

namespace Jorkol.GameDataApi.ApexLegends.Models
{
    public class ApexMatch : EntityBase
    {
        public Guid TrnId { get; set; }
        public DateTime EndDateTime { get; set; }
        public virtual ApexCharacter Character { get; set; }
        public virtual ApexAccount Account { get; set; }
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