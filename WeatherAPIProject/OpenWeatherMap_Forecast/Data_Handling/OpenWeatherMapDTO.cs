using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPIProject.OpenWeatherMap_Forecast.Data_Handling
{
    class OpenWeatherMapDTO
    {
        public LatestWeather latestWeather { get; set; }
        public void DeserializeLatestWeatherReport(String LatestRateResponse)
        {
            latestWeather = JsonConvert.DeserializeObject<LatestWeather>(LatestRateResponse);
        }
    }
}
