using System;
using System.ComponentModel.DataAnnotations;

namespace Jorkol.GameDataApi.Core
{
    public abstract class EntityBase
    {
        [Key]
        public Guid Id { get; set; }
    }
}