using System;
using System.Linq;
using System.Threading.Tasks;
using Jorkol.GameDataApi.ApexLegends.Models;
using Jorkol.GameDataApi.ApexLegends.Services;
using Jorkol.GameDataApi.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Jorkol.GameDataApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ILogger<TaskController> logger;
        private readonly IApexMatchService apexMatchService;
        private readonly IApexAccountService apexAccountService;

        public TaskController(ILogger<TaskController> logger, IApexMatchService apexMatchService, IApexAccountService apexAccountService)
        {
            this.logger = logger;
            this.apexMatchService = apexMatchService;
            this.apexAccountService = apexAccountService;
        }

        [HttpGet]
        [Route("[action]")]
        public String Health()
        {
            return "Healthy";
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ApexMatchesResponse> ApexMatches([FromQuery(Name = "platform")] string platform, [FromQuery(Name = "name")] string name)
        {
            var account = new ApexAccount { Name = name, Platform = platform };
            var apexMatches = await this.apexMatchService.FromTrnAndDbAsync(account);
            return new ApexMatchesResponse { Total = apexMatches.Count(), ApexMatches = apexMatches };
        }

        [HttpGet]
        [Route("[action]")]
        public ApexMatchesResponse ApexMatchesFromDb([FromQuery(Name = "platform")] string platform, [FromQuery(Name = "name")] string name)
        {
            var account = new ApexAccount { Name = name, Platform = platform };
            var apexMatches = this.apexMatchService.FindByAccount(account);
            return new ApexMatchesResponse { Total = apexMatches.Count(), ApexMatches = apexMatches };
        }

        [HttpGet]
        [Route("[action]")]
        public ApexAccountsResponse ApexAccounts()
        {
            var accounts = apexAccountService.WithMatches();
            return new ApexAccountsResponse { Total = accounts.Count(), ApexAccounts = accounts };
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<int> MatchesForAllAccountsAsync()
        {
            var accounts = apexAccountService.All();

            int totalMatches = 0;
            foreach (var account in accounts)
            {
                totalMatches += (await apexMatchService.FromTrnAsync(account)).Count();
            }
            return totalMatches;
        }
    }
}