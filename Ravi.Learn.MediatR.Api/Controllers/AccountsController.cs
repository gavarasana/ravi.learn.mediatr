using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ravi.Learn.MediatR.Api.Messages;

namespace Ravi.Learn.MediatR.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<AccountsController> _logger;

        public AccountsController(IMediator mediator, ILogger<AccountsController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<AccountsResponse>> GetAllAccountsAsync()
        {
            _logger.LogTrace("Trace: Retrieving all accounts data");
            _logger.LogDebug("Debug: Retrieving all accounts data");
            _logger.LogInformation("Retrieving all accounts data at {Time}", DateTime.Now);
            _logger.LogWarning("Retrieving all accounts data");
            return await _mediator.Send(new AccountsRequest());
        }
    }
}