using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GameDataApi.Dtos;
using GameDataApi.Mappers;
using GameDataApi.Models;
using GameDataApi.TrackerNetworkClient;
using GameDataApi.TrackerNetworkClient.Models;
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

        private readonly IApexMapper apexMapper;

        public TaskController(ILogger<TaskController> logger, ITrackerNetworkApexClient trackerNetworkApexClient, IApexMapper apexMapper)
        {
            this.logger = logger;
            this.trackerNetworkApexClient = trackerNetworkApexClient;
            this.apexMapper = apexMapper;
        }

        [HttpGet]
        [Route("[action]")]
        public String Health()
        {
            return "Healthy";
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ProfileResponseData> ApexProfileAsync([FromQuery(Name = "platform")] string platform, [FromQuery(Name = "platformUserIdentifier")] string platformUserIdentifier)
        {
            return await trackerNetworkApexClient.Profile(platform, platformUserIdentifier);
        }


        [HttpGet]
        [Route("[action]")]
        public async Task<ProfileSessionsResponseData> ApexProfileSessionsAsync([FromQuery(Name = "platform")] string platform, [FromQuery(Name = "platformUserIdentifier")] string platformUserIdentifier)
        {
            return await trackerNetworkApexClient.ProfileSessions(platform, platformUserIdentifier);
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ApexMatchesResponse> ApexMatches([FromQuery(Name = "platform")] string platform, [FromQuery(Name = "platformUserIdentifier")] string platformUserIdentifier)
        {
            ProfileSessionsResponseData profileSessionsResponse = await trackerNetworkApexClient.ProfileSessions(platform, platformUserIdentifier);
            List<ApexMatch> apexMatchList = this.apexMapper.ApexMatchListFromProfileSessions(profileSessionsResponse);
            return new ApexMatchesResponse { total = apexMatchList.Count, apexMatches = apexMatchList };
        }
    }
}