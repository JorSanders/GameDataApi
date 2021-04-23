using System.Collections.Generic;
using System.Linq;
using Jorkol.GameDataApi.ApexLegends.Models;
using Jorkol.GameDataApi.ApexLegends.Repositories;
using Jorkol.GameDataApi.Core;
using Microsoft.Extensions.Logging;

namespace Jorkol.GameDataApi.ApexLegends.Services
{
    public class ApexAccountService : BaseService<IApexAccountRepository, ApexAccount>, IApexAccountService
    {
        private readonly ILogger<ApexAccountService> logger;
        private readonly IApexAccountRepository apexAccountRepository;

        public ApexAccountService(
            ILogger<ApexAccountService> logger,
            IApexAccountRepository apexAccountRepository) : base(apexAccountRepository)
        {
            this.logger = logger;
            this.apexAccountRepository = apexAccountRepository;
        }

        public IEnumerable<ApexAccount> WithMatches()
        {
            return apexAccountRepository.WithMatches();
        }
    }
}