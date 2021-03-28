using System;
using System.Threading.Tasks;
using Gwergilius.Calculator.Core.Samples.Data;
using Microsoft.AspNetCore.Components;

namespace Gwergilius.Calculator.Components.Samples
{
    public class FetchDataCode : ComponentBase
    {
        [Inject] public WeatherForecastService ForecastService { get; set; }

        protected WeatherForecast[] forecasts;

        protected override async Task OnInitializedAsync()
        {
            forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
        }
    }
}