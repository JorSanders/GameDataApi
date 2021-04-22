using System.Collections.Generic;
using Jorkol.GameDataApi.ApexLegends.Models;

namespace Jorkol.GameDataApi.Dtos
{
    public class ApexAccountsResponse
    {
        public long Total { get; set; }
        public IEnumerable<ApexAccount> ApexAccounts { get; set; }
    }
}