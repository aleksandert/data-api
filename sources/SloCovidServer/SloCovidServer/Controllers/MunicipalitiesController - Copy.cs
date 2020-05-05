﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SloCovidServer.Models;
using SloCovidServer.Services.Abstract;
using System.Collections.Immutable;
using System.Threading.Tasks;

namespace SloCovidServer.Controllers
{
    [ApiController]
    [Route("api/health-centers")]
    public class HealthCentersController : MetricsController<HealthCentersController>
    {
        public HealthCentersController(ILogger<HealthCentersController> logger, ICommunicator communicator) : base(logger, communicator)
        {
        }
        [HttpGet]
        public async Task<ActionResult<ImmutableArray<HealthCentersDay>?>> Get()
        {
            return await ProcessRequestAsync(communicator.GetHealthCentersAsync);
        }
    }
}