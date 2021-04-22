using System.Collections.Generic;
using Jorkol.GameDataApi.ApexLegends.Models;

namespace Jorkol.GameDataApi.Dtos
{
    public class ApexMatchesResponse
    {
        public long Total { get; set; }
        public IEnumerable<ApexMatch> ApexMatches { get; set; }
    }
}