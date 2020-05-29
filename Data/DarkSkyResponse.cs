using System;

namespace BlazorServerWeatherApp.Data
{
    public class DarkSkyResponse
    {
        public Currently Currently { get; set; }

        public Daily Daily { get; set; }

        public Hourly Hourly { get; set; }
    }
}
