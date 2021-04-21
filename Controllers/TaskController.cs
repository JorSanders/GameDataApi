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

        public TaskController(ILogger<TaskController> logger, IApexMatchService apexMatchService)
        {
            this.logger = logger;
            this.apexMatchService = apexMatchService;
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
            var apexMatches = await this.apexMatchService.ApexMatchesAsync(account);
            return new ApexMatchesResponse { total = apexMatches.Count(), apexMatches = apexMatches };
        }

        [HttpGet]
        [Route("[action]")]
        public ApexMatchesResponse ApexMatchesFromDb([FromQuery(Name = "platform")] string platform, [FromQuery(Name = "name")] string name)
        {
            var account = new ApexAccount { Name = name, Platform = platform };
            var apexMatches = this.apexMatchService.ApexMatchesFromDb(account);
            return new ApexMatchesResponse { total = apexMatches.Count(), apexMatches = apexMatches };
        }
    }
}