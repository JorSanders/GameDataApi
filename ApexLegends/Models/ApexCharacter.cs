using System;
using System.ComponentModel.DataAnnotations;
using Jorkol.GameDataApi.Core;

namespace Jorkol.GameDataApi.ApexLegends.Models
{
    public class ApexCharacter : EntityBase
    {
        public long TrnId { get; set; }
        public string Name { get; set; }
    }
}