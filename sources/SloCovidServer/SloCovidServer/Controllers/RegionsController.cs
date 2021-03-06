﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SloCovidServer.Models;
using SloCovidServer.Services.Abstract;
using System;
using System.Collections.Immutable;
using System.Threading.Tasks;

namespace SloCovidServer.Controllers
{
    [ApiController]
    [Route("api")]
    public class RegionsController : MetricsController<RegionsController>
    {
        public RegionsController(ILogger<RegionsController> logger, ICommunicator communicator) : base(logger, communicator)
        {
        }

        [HttpGet]
        [Route("regions")]
        public async Task<ActionResult<ImmutableArray<RegionsDay>?>> Get(DateTime? from, DateTime? to)
        {
            return await ProcessRequestAsync(communicator.GetRegionsAsync, new DataFilter(from, to));
        }
    }
}
