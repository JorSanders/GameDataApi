using System;
using System.ComponentModel.DataAnnotations;

namespace Jorkol.GameDataApi.ApexLegends.Models
{
    public abstract class ApexBaseModel
    {
        [Key]
        public Guid Id { get; set; }
    }
}