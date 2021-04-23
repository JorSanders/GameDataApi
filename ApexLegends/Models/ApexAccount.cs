using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Jorkol.GameDataApi.Core;

namespace Jorkol.GameDataApi.ApexLegends.Models
{
    public class ApexAccount : EntityBase
    {
        public string Platform { get; set; }
        public string Name { get; set; }

        public IEnumerable<ApexMatch> ApexMatches { get; set; }
    }
}