using MediatR;
using Ravi.Learn.MediatR.Api.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Ravi.Learn.MediatR.Api.Handlers
{
    public class AllWeatherHandler : IRequestHandler<AllWeatherForecastRequest, IEnumerable<WeatherForecastResponse>>
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public async Task<IEnumerable<WeatherForecastResponse>> Handle(AllWeatherForecastRequest request, CancellationToken cancellationToken)
        {
            var rng = new Random();
            var weatherData = Enumerable.Range(1, 5).Select(index => new WeatherForecastResponse
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray();
            return await Task.FromResult<IEnumerable<WeatherForecastResponse>>(weatherData);
        }
    }
}
