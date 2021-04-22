using System.Collections.Generic;
using System.Linq;
using Jorkol.GameDataApi.ApexLegends.Models;
using Jorkol.GameDataApi.ApexLegends.Repositories;
using Microsoft.Extensions.Logging;

namespace Jorkol.GameDataApi.ApexLegends.Services
{
    public class ApexAccountService : IApexAccountService
    {
        private readonly ILogger<ApexAccountService> logger;
        private readonly IApexAccountRepository apexAccountRepository;

        public ApexAccountService(
            ILogger<ApexAccountService> logger,
            IApexAccountRepository apexAccountRepository)
        {
            this.logger = logger;
            this.apexAccountRepository = apexAccountRepository;
        }

        public IEnumerable<ApexAccount> ApexAccounts()
        {
            return apexAccountRepository.All();
        }

        public ApexAccount FindOrCreate(string name, string platform)
        {
            return apexAccountRepository.CreateOrUpdate(new ApexAccount { Name = name, Platform = platform });
        }
    }
}