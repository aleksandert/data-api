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
    public class PatientsController : MetricsController<PatientsController>
    {
        public PatientsController(ILogger<PatientsController> logger, ICommunicator communicator) : base(logger, communicator)
        {
        }

        [HttpGet]
        public async Task<ActionResult<ImmutableArray<PatientsDay>?>> Get()
        {
            return await ProcessRequestAsync(communicator.GetPatientsAsync);
        }
    }
}
