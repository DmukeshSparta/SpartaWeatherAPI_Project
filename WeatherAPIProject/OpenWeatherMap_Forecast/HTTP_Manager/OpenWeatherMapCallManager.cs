using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPIProject.OpenWeatherMap_Forecast.HTTP_Manager
{
    class OpenWeatherMapCallManager
    {
        readonly IRestClient client;

        public OpenWeatherMapCallManager()
        {
            client = new RestClient(WeatherConfig.baseUrl);
        }

        public string GetLatestWeatherReport()
        {
            var request = new RestRequest("/latest" + WeatherConfig.ApiUrlMod + WeatherConfig.ApiKey);
            var response = client.Execute(request, Method.GET);
            return response.Content;
        }
    }
}
