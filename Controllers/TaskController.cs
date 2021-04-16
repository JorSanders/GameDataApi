using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using GameDataApi.TrackerNetworkClient;
using GameDataApi.TrackerNetworkClient.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GameDataApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {

        private readonly ILogger<TaskController> logger;
        private readonly ITrackerNetworkApexClient trackerNetworkApexClient;

        public TaskController(ILogger<TaskController> logger, ITrackerNetworkApexClient trackerNetworkApexClient)
        {
            this.logger = logger;
            this.trackerNetworkApexClient = trackerNetworkApexClient;
        }

        [HttpGet]
        [Route("[action]")]
        public String Health()
        {
            return "Healthy";
        }

        [HttpGet]
        [Route("[action]")]
        public String Status()
        {
            return "Ok";
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ProfileResponse> ApexProfileAsync([FromQuery(Name = "platform")] string platform, [FromQuery(Name = "platformUserIdentifier")] string platformUserIdentifier)
        {
            return await trackerNetworkApexClient.Profile(platform, platformUserIdentifier);
        }


        [HttpGet]
        [Route("[action]")]
        public async Task<ProfileSessionsResponse> ApexProfileSessionsAsync([FromQuery(Name = "platform")] string platform, [FromQuery(Name = "platformUserIdentifier")] string platformUserIdentifier)
        {
            return await trackerNetworkApexClient.ProfileSessions(platform, platformUserIdentifier);
        }
    }
}