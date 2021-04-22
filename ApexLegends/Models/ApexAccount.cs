using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Jorkol.GameDataApi.ApexLegends.Models
{
    public class ApexAccount : ApexBaseModel
    {
        public string Platform { get; set; }
        public string Name { get; set; }

        public IEnumerable<ApexMatch> ApexMatches { get; set; }
    }
}