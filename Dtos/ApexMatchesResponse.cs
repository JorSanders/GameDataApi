using System.Collections.Generic;
using Jorkol.GameDataApi.ApexLegends.Models;

namespace Jorkol.GameDataApi.Dtos
{
    public class ApexMatchesResponse
    {
        public long total { get; set; }
        public IEnumerable<ApexMatch> apexMatches { get; set; }
    }
}