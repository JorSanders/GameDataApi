using System;
using System.ComponentModel.DataAnnotations;

namespace Jorkol.GameDataApi.ApexLegends.Models
{
    public class ApexCharacter : ApexBaseModel
    {
        [Key]
        public long ApexId { get; set; }
        public string Name { get; set; }
    }
}