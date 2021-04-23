using System;
using System.Collections.Generic;
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
    public class ApexLegendsController : ControllerBase
    {
        private readonly ILogger<ApexLegendsController> logger;
        private readonly IApexMatchService matchService;
        private readonly IApexAccountService accountService;

        public ApexLegendsController(ILogger<ApexLegendsController> logger, IApexMatchService apexMatchService, IApexAccountService apexAccountService)
        {
            this.logger = logger;
            this.matchService = apexMatchService;
            this.accountService = apexAccountService;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ApexMatchesResponse> MatchesByAccount([FromQuery(Name = "platform")] string platform, [FromQuery(Name = "name")] string name)
        {
            var account = accountService.ByNameAndPlatform(name, platform);
            var apexMatches = await this.matchService.FromTrnAndDbAsync(account);
            return new ApexMatchesResponse { Total = apexMatches.Count(), ApexMatches = apexMatches };
        }

        [HttpGet]
        [Route("[action]")]
        public ApexMatchesResponse MatchesFromDbByAccount([FromQuery(Name = "platform")] string platform, [FromQuery(Name = "name")] string name)
        {
            var account = accountService.ByNameAndPlatform(name, platform);
            var matches = this.matchService.FindByAccount(account);
            return new ApexMatchesResponse { Total = matches.Count(), ApexMatches = matches };
        }

        [HttpGet]
        [Route("[action]")]
        public ApexAccountsResponse Accounts()
        {
            var accounts = accountService.WithMatches();
            return new ApexAccountsResponse { Total = accounts.Count(), ApexAccounts = accounts };
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<ApexMatchesResponse> TrnMatchesOfAllAccounts()
        {
            var accounts = accountService.All();
            var matches = await matchService.FromTrnAsync(accounts);

            return new ApexMatchesResponse { Total = matches.Count(), ApexMatches = matches };
        }

        [HttpGet]
        [Route("[action]")]
        public ApexMatchesResponse AllMatchesFromDb()
        {
            var matches = matchService.All();
            return new ApexMatchesResponse { Total = matches.Count(), ApexMatches = matches };
        }

        [HttpDelete]
        [Route("[action]")]
        public void CleanDb()
        {
            matchService.Delete(matchService.All());
            accountService.Delete(accountService.All());
        }
    }
}