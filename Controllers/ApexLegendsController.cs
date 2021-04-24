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
    [Route("")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly ILogger<MainController> logger;
        public MainController(ILogger<MainController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        [Route("[action]")]
        public bool Health()
        {
            return true;
        }
    }
}