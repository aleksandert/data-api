﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SloCovidServer.Models;
using SloCovidServer.Services.Abstract;
using System.Collections.Immutable;
using System.Threading.Tasks;

namespace SloCovidServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HospitalsController : MetricsController<HospitalsController>
    {
        public HospitalsController(ILogger<HospitalsController> logger, ICommunicator communicator) : base(logger, communicator)
        {
        }

        [HttpGet]
        public async Task<ActionResult<ImmutableArray<HospitalsDay>?>> Get()
        {
            return await ProcessRequestAsync(communicator.GetHospitalsAsync);
        }
    }
}
