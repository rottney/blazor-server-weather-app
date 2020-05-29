using System;

namespace BlazorServerWeatherApp.Data
{
    public class Currently
    {
        public string Summary { get; set; }
        public double Temperature { get; set; }
        public int Time { get; set; }
    }
}
