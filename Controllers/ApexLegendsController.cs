using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using GameDataApi.Migrations;
using Jorkol.GameDataApi.ApexLegends.Db;
using Jorkol.GameDataApi.ApexLegends.Models;
using Jorkol.GameDataApi.ApexLegends.Services;
using Jorkol.GameDataApi.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Jorkol.GameDataApi.Controllers
{
    [Route("")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly ILogger<MainController> logger;
        private readonly ApexDbContext dbContext;
        public MainController(ILogger<MainController> logger, ApexDbContext dbContext)
        {
            this.logger = logger;
            this.dbContext = dbContext;
        }

        [HttpGet]
        [Route("[action]")]
        public bool Health()
        {
            return true;
        }

        [HttpGet]
        [Route("[action]")]
        public void Migrate()
        {
            var db = dbContext.Database;
            db.Migrate();
        }
    }
}