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
        public OpenWeatherMapDTO openWeatherMapDTO = new OpenWeatherMapDTO();
        //We need Call Manager
        public OpenWeatherMapCallManager openWeatherMapCall = new OpenWeatherMapCallManager();
        //Json Object 
        public JObject OpenWeatherMapJson;

        public OpenWeatherMapService()
        {
            openWeatherMapDTO.DeserializeOpenWeatherMap(openWeatherMapCall.GetOpenWeatherMap());
            OpenWeatherMapJson = JObject.Parse(openWeatherMapCall.GetOpenWeatherMap());
        }
    }
}
