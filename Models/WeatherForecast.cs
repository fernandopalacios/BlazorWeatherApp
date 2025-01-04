public class WeatherForecast
{
    public Location Location { get; set; }
    public Forecast Current { get; set; }
    public ForecastDay Forecast { get; set; }

}

public class ForecastDay
{
    public WeatherForecastDay[] Forecastday { get; set; }
}

public class WeatherForecastDay
{
    public Day Day { get; set; }
    public string Date { get; set; }

    public string FullDate
    {
        get
        {
            DateTime dateTime = DateTime.Parse(Date);
            string fullDate = dateTime.ToString("MMM d");
            return fullDate;
        }
    }

}

public class Day
{
    public double MaxTemp_C {get;set;}
    public double MaxTemp_F {get;set;}
    public double MinTemp_C {get;set;}
    public double MinTemp_F {get;set;}
    public Condition Condition { get; set; }
}