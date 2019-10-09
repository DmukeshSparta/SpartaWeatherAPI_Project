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
            client = new RestClient(OpenWeatherMapConfig.baseUrl);
        }

        public string GetOpenWeatherMap()
        {
            var request = new RestRequest(OpenWeatherMapConfig.ApiCity + "&" + OpenWeatherMapConfig.ApiKey);
            var response = client.Execute(request, Method.GET);
            return response.Content;
        }
    }
}
