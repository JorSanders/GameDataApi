using System.Collections.Generic;
using Jorkol.GameDataApi.Models;
using Newtonsoft.Json;

namespace GameDataApi.Dtos
{
    public class ApexMatchesResponse
    {
        public long total { get; set; }
        public List<ApexMatch> apexMatches { get; set; }
    }
}