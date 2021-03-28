using System;
using System.Linq;
using System.Threading.Tasks;
using Gwergilius.Calculator.Core.Samples.Data;
using Microsoft.Extensions.DependencyInjection;

namespace Gwergilius.Calculator.Core.Samples.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray());
        }
    }
}

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddWheaterForecast(this IServiceCollection services)
        {
            services.AddSingleton<WeatherForecastService>();
            return services;
        }
    }
}