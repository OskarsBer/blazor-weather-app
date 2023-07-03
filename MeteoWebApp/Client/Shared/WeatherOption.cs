public class WeatherOption
    {
        public WeatherOption(string displayName, string stationId)
        {
            DisplayName = displayName;
            StationId = stationId;
        }
        public string DisplayName { get; set; }
        public string StationId { get; set; }
    }