using System;

namespace BlazorServerWeatherApp.Data
{
    public class ZipCodeResponse
    {
        public string Zip_Code { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}