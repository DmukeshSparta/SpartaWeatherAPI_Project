namespace WeatherAPIProject.OpenWeatherMap_Forecast.Data_Handling
{
    public class OpenWeatherMapList
    {
        public int dt { get; set; }
    }
    public class OpenWeatherMapCity
    {
        public int id { get; set; }
        public string name { get; set; }
        public OpenWeatherMapCityCoord coord { get; set; }
        public string country { get; set; }
        public int population { get; set; }
        public int timezone { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }
    }
    public class OpenWeatherMapCityCoord
    {
        public double lat { get; set; }
        public double lon { get; set; }
    }
    public class OpenWeatherMapRoot
    {
        public string cod { get; set; }
        public double message { get; set; }
        public int cnt { get; set; }
        public OpenWeatherMapCity city { get; set; }
        public OpenWeatherMapList list { get; set; }
    }

}
