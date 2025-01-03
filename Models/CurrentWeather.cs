    public class CurrentWeather
    {
        public double Temp_C { get; set; }
        public double Temp_F { get; set; }
        public double MaxTemp_C {get;set;}
        public double MaxTemp_F {get;set;}
        public double MinTemp_C {get;set;}
        public double MinTemp_F {get;set;}
        public double FeelsLike_C {get;set;}
        public double FeelsLike_F {get;set;}
        public Condition condition {get;set;}
        
    }

    public class Condition 
    {
        public string Text {get; set;}
        public string Icon {get; set;}
    }