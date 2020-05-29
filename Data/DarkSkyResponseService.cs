using System;
using System.Linq;
using System.Threading.Tasks;
// Reference Newtonsoft
using Newtonsoft.Json;

using System.Net.Http;

namespace BlazorServerWeatherApp.Data
{
    public class DarkSkyResponseService
    {
        static readonly HttpClient client = new HttpClient();
        public async Task<DarkSkyResponse> GetDarkSkyResponseAsync(double lat, double lng)
        {
            string baseUrl = "https://api.darksky.net/forecast/";
            string key = "f9ad5296ab06eac220a16bb515fc507a";
            string flags = "?exclude=minutely,alerts,flags";

            string request = String.Concat(baseUrl, key, "/", lat, ",", lng, flags);

            try
            {
                HttpResponseMessage response = await client.GetAsync(request);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

                return JsonConvert.DeserializeObject<DarkSkyResponse>(responseBody);
            }
            catch(HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");	
                Console.WriteLine("Message :{0} ",e.Message);

                // This block works
                DarkSkyResponse darkSkyResponse = new DarkSkyResponse();
                Currently currently = new Currently();
                currently.Summary = "weather sux";
                currently.Temperature = 69.0;
                darkSkyResponse.Currently = currently;
                //return Task.FromResult(darkSkyResponse);  // works when function is NOT async
                return darkSkyResponse;
            }
        }
    }
}
