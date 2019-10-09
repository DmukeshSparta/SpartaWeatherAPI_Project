using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace WeatherAPIProject
{
    class OpenWeatherMapConfig
    {
        public static readonly String baseUrl = ConfigurationManager.AppSettings["base_url"];
        public static readonly String ApiKey = ConfigurationManager.AppSettings["api_key"];
        public static readonly String ApiCity = ConfigurationManager.AppSettings["api_city"];
    }
}
