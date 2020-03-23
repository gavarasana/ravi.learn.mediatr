using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ravi.Learn.MediatR.Api.Messages;

namespace Ravi.Learn.MediatR.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {      
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IMediator _mediator;

        public WeatherForecastController(IMediator mediator, ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<WeatherForecastResponse>> GetAllAsync()
        {
            _logger.LogInformation("Retrieving all weather data");
            return await _mediator.Send<IEnumerable<WeatherForecastResponse>>(new AllWeatherForecastRequest());
        }
    }
}
