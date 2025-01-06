public class RootSettings
{
    public AppSettings AppSettings { get; set; }
}

public class AppSettings
{
    public string WeatherSearchApiUrl { get; set; }
    public string WeatherForecastApiUrl { get; set; }
    public string WeatherApiKey { get; set; }
    public string LocalApiUrl { get; set; }
}