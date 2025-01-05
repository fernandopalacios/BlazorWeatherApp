public class Forecast
{
    public double Temp_C { get; set; }
    public double Temp_F { get; set; }
    public double FeelsLike_C { get; set; }
    public double FeelsLike_F { get; set; }
    public Condition Condition { get; set; }
    public double Wind_Kph { get; set; }
    public double Humidity { get; set; }
    public double UV { get; set; }
    public double Pressure_Mb { get; set; }

}

public class Condition
{
    public string Text { get; set; }
    public string Icon { get; set; }
}