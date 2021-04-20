using System;
using System.ComponentModel.DataAnnotations;

namespace Jorkol.GameDataApi.ApexLegends
{
    public class ApexCharacter
    {
        [Key]
        public Guid Id { get; set; }
        public long ApexId { get; set; }
        public string Name { get; set; }
    }
}