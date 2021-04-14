using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GameDataApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {

        private readonly ILogger<TaskController> _logger;

        public TaskController(ILogger<TaskController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("[action]")]
        public String Health()
        {
            var rng = new Random();
            return "Healthy";
        }

        [HttpGet]
        [Route("[action]")]
        public String Status()
        {
            var rng = new Random();
            return "Ok";
        }
    }
}