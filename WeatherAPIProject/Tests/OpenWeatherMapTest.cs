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

        //Test for weather list 
        [Test]
        public void OpenWeatherMapListDT()
        {
            //check the Dt length
            int dt = openWeatherMapForcast.openWeatherMapDTO.openWeatherMap.list[0].dt.ToString().Length;
            Assert.AreEqual(openWeatherMapForcast.openWeatherMapDTO.openWeatherMap.list[0].dt.ToString().Length, dt);
        }

        [Test]
        public void OpenWeatherMapListTempCompare()
        {
            //compare Temp with Temp min
            double temp = openWeatherMapForcast.openWeatherMapDTO.openWeatherMap.list[0].main.temp;
            double tempmin = openWeatherMapForcast.openWeatherMapDTO.openWeatherMap.list[0].main.temp_min;
            Assert.AreEqual(temp, tempmin);
        }

        [Test]
        public void OpenWeatherMapListTemp_Min()
        {
            double kelvin = openWeatherMapForcast.openWeatherMapDTO.openWeatherMap.list[0].main.temp_max;
            double kelvin2 = 283.13099999999997;
            Assert.That(kelvin2, Is.EqualTo(kelvin));

        }

        [Test]
        public void OpenWeatherMapListPressureCompareWithSeaLevel()
        {
            //Compare pressure with SeaLevel
            double pressure = openWeatherMapForcast.openWeatherMapDTO.openWeatherMap.list[0].main.pressure;
            double sealevel = openWeatherMapForcast.openWeatherMapDTO.openWeatherMap.list[0].main.sea_level;
            Assert.AreEqual(pressure, sealevel);
        }

        [Test]
        public void OpenWeatherMapListGrnd_Level()
        {
            Assert.GreaterOrEqual(openWeatherMapForcast.openWeatherMapDTO.openWeatherMap.list[0].main.grnd_level, 1000);
        }

        [Test]
        public void OpenWeatherMapListMainHumditiy()
        {
            Assert.AreEqual(openWeatherMapForcast.openWeatherMapDTO.openWeatherMap.list[0].main.humidity.GetType(), typeof(int));
        }

        [Test]
        public void OpenWeatherMapListTemp_Kf()
        {
            Assert.That(openWeatherMapForcast.openWeatherMapDTO.openWeatherMap.list[0].main.temp_kf, Is.LessThan(0.0));
        }

        [Test]
        public void OpenWeatherMapListWeatherID()
        {
            //list for ID for weather
            var rain = new List<int>();
            //list for rain id
            rain.AddRange(new[] { 500, 501, 502, 503, 504, 511, 520, 521, 522, 531 });
            //list for cloud id
            rain.AddRange(new[] { 801, 802, 803, 804 });
            //list for thunder id
            rain.AddRange(new[] { 200, 201, 202, 201, 211, 212, 221, 230, 231, 232 });
            //list for clear 
            rain.AddRange(new[] { 800 }); 
            //list for drizzle, snow, atmposhere

            Assert.Contains(openWeatherMapForcast.openWeatherMapDTO.openWeatherMap.list[0].weather[0].id, rain);
        }

        [Test]
        public void OpenWeatherMapListWeatherName()
        {
            var rainname = new List<string>();
            rainname.AddRange(new[] { "Clouds", "Clear", "Rain", "Atmosphere", "Snow", "Drizzle", "ThunderStorm" });
            Assert.Contains(openWeatherMapForcast.openWeatherMapDTO.openWeatherMap.list[0].weather[0].main, rainname);
        }

        [Test]
        public void OpenWeatherMapListCloud()
        {
            Assert.AreEqual(openWeatherMapForcast.openWeatherMapDTO.openWeatherMap.list[0].clouds.all.GetType(), typeof(int));
        }

        [Test]
        public void OpenWeatherMapListWindSpeed()
        {
            Assert.AreEqual(openWeatherMapForcast.openWeatherMapDTO.openWeatherMap.list[0].wind.speed.GetType(), typeof(double));
        }

        [Test]
        public void OpenWeatherMapListWindDeg()
        {
            Assert.AreEqual(openWeatherMapForcast.openWeatherMapDTO.openWeatherMap.list[0].wind.deg.GetType(), typeof(double));
        }

        [Test]
        public void OpenWeatherMapListRain()
        {
            Assert.GreaterOrEqual(openWeatherMapForcast.openWeatherMapDTO.openWeatherMap.list[0].rain.three, 0);
        }

        [Test]
        public void OpenWeatherMapListSys()
        {

            Assert.AreEqual(1, openWeatherMapForcast.openWeatherMapDTO.openWeatherMap.list[0].sys.pod.Length);
        }

        [Test]
        public void OpenWeatherMapListDT_Text()
        {
            Assert.AreEqual(19, openWeatherMapForcast.openWeatherMapDTO.openWeatherMap.list[0].dt_txt.Length);
        }

        //Test for City 
        [Test]
        public void OpenWeatherMapCityID()
        {
            //testing if the city id matches with api city id 
            Assert.AreEqual(2643743, openWeatherMapForcast.openWeatherMapDTO.openWeatherMap.city.id);
        }

        [Test]
        public void OpenWeatherMapCityName()
        {
            //testing if the city name matches with api city name 
            Assert.AreEqual("London", openWeatherMapForcast.openWeatherMapDTO.openWeatherMap.city.name);
        }

        [Test]
        public void OpenWeatherMapCityTimezone()
        {
            var offset = TimeZoneInfo.Local.GetUtcOffset(DateTime.UtcNow).TotalSeconds;
            int timezone = openWeatherMapForcast.openWeatherMapDTO.openWeatherMap.city.timezone;
            Assert.That(offset, Is.EqualTo(timezone));
        }

        [Test]
        public void OpenWeatherMapCityCoordLat()
        {
            //test if the latitude type is double
            Assert.AreEqual(openWeatherMapForcast.openWeatherMapDTO.openWeatherMap.city.coord.lat.GetType(), typeof(double));
        }

        [Test]
        public void OpenWeatherMapCityCoordLon()
        {
            //test if the longitude type is double
            Assert.AreEqual(openWeatherMapForcast.openWeatherMapDTO.openWeatherMap.city.coord.lat.GetType(), typeof(double));
        }

        [Test]
        public void OpenWeatherMapCountryName()
        {
            //testing if the city name matches with api country name 
            Assert.AreEqual("GB", openWeatherMapForcast.openWeatherMapDTO.openWeatherMap.city.country);
        }

        [Test]
        public void OpenWeatherMapCityPopulation()
        {
            //test if population is not empty
            Assert.IsNotNull(openWeatherMapForcast.openWeatherMapDTO.openWeatherMap.city.population);
        }

        [Test]
        public void OpenWeatherMapCitySunriseORSunset()
        {
            //test if the sunrise/sunset type is int
            Assert.AreEqual(openWeatherMapForcast.openWeatherMapDTO.openWeatherMap.city.sunrise.GetType(), typeof(int));
        }

        [Test]
        public void OpenWeatherMapCitySunriseORSunsetLength()
        {
            //test if the sunrise/sunset length 
            int sun = openWeatherMapForcast.openWeatherMapDTO.openWeatherMap.city.sunrise.ToString().Length;
            Assert.AreEqual(openWeatherMapForcast.openWeatherMapDTO.openWeatherMap.city.sunrise.ToString().Length, sun);
        }
    }
}
