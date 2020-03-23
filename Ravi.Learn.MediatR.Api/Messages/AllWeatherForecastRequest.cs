using MediatR;
using System.Collections.Generic;

namespace Ravi.Learn.MediatR.Api.Messages
{
    public class AllWeatherForecastRequest : IRequest<IEnumerable<WeatherForecastResponse>>
    {
    }
}
