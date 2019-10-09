using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Newtonsoft.Json.Linq;
using WeatherAPIProject.OpenWeatherMap_Forecast;

namespace WeatherAPIProject.Tests
{
    [TestFixture]
    public class OpenWeatherMapTest
    {
        private OpenWeatherMapService openWeatherMapForcast = new OpenWeatherMapService();

        [Test]
        public void OpenWeatherMapCod()
        {
            //testing the internal paramter for cod and paramater stay the same. 
            Assert.AreEqual("200", openWeatherMapForcast.openWeatherMapDTO.openWeatherMap.cod);
        }

        [Test]
        public void OpenWeatherMapMessage()
        {
            //internal paramter changes, therefore the test of message will be to check
            //if the messsage is greater than 0.0
            Assert.Greater(openWeatherMapForcast.openWeatherMapDTO.openWeatherMap.message, 0.0);
        }

        [Test]
        public void OpenWeatherMapCnt()
        {
            Assert.AreEqual(40, openWeatherMapForcast.openWeatherMapDTO.openWeatherMap.cnt);
        }

        [Test]
        public void OpenWeatherMapListDT()
        {
        }

        [Test]
        public void OpenWeatherMapListMainHumditiy()
        {
        }

        [Test]
        public void OpenWeatherMapListWeather()
        {
        }

        [Test]
        public void OpenWeatherMapListWind()
        {
        }

        [Test]
        public void OpenWeatherMapListRain()
        {
        }

        [Test]
        public void OpenWeatherMapListSys()
        {
        }

        [Test]
        public void OpenWeatherMapListDT_Text()
        {
        }

        //Test for City 
        [Test]
        public void OpenWeatherMapCityName()
        {
            //testing if the city name matches with api city name 
            Assert.AreEqual("London", openWeatherMapForcast.openWeatherMapDTO.openWeatherMap.city.name);
        }

        [Test]
        public void OpenWeatherMapCityTimezone()
        {
            Assert.AreEqual("London", openWeatherMapForcast.openWeatherMapDTO.openWeatherMap.city.timezone);
        }

        [Test]
        public void OpenWeatherMapCityCoordLat()
        {
            Assert.Greater(50, openWeatherMapForcast.openWeatherMapDTO.openWeatherMap.city.coord.lat);
        }

        //Test for headers
        [Test]
        public void HeaderServer()
        {
        }

        [Test]
        public void HeaderContentLength()
        {
        }
    }
}
