using System.Collections.Generic;
using Newtonsoft.Json;

namespace GameDataApi.Models.Dtos.Responses
{
    public class ApexMatches
    {
        public long total { get; set; }
        public List<ApexMatch> apexMatches { get; set; }
    }
}