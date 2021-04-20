using System.Collections.Generic;
using Jorkol.GameDataApi.ApexLegends;

namespace Jorkol.GameDataApi.Dtos
{
    public class ApexMatchesResponse
    {
        public long total { get; set; }
        public List<ApexMatch> apexMatches { get; set; }
    }
}