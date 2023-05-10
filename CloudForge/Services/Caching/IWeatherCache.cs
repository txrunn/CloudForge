using CloudForge.DataContracts;
using System.Collections.Immutable;

namespace CloudForge.Services.Caching
{
    public interface IWeatherCache
    {
        ValueTask<IImmutableList<WeatherForecast>> GetForecast(CancellationToken token);
    }
}