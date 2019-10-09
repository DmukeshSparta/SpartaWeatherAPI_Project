using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherAPIProject.OpenWeatherMap_Forecast.Data_Handling;
using WeatherAPIProject.OpenWeatherMap_Forecast.HTTP_Manager;

namespace WeatherAPIProject.OpenWeatherMap_Forecast
{
    class OpenWeatherMapService
    {
        //we need DTO
        public OpenWeatherMapDTO latestDTO = new OpenWeatherMapDTO();
        //We need Call Manager
        public OpenWeatherMapCallManager latestCallManager = new OpenWeatherMapCallManager();
        //Json Object 
        public JObject latestRatesJson;

        public OpenWeatherMapService()
        {
            latestDTO.DeserializeLatestWeatherReport(latestCallManager.GetLatestWeatherReport());
            latestRatesJson = JObject.Parse(latestCallManager.GetLatestWeatherReport());
        }

        public int GetTotalRates()
        {
            int count = 0;
            foreach (var item in latestRatesJson["rates"])
            {
                count += 1;
            }
            return count;
        }
    }
}
