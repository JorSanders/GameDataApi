using System;
using System.ComponentModel.DataAnnotations;

namespace Jorkol.GameDataApi.ApexLegends.Models
{
    public class ApexCharacter : ApexBaseModel
    {
        public long TrnId { get; set; }
        public string Name { get; set; }
    }
}