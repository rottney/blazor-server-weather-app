using System;
using System.Linq;
using System.Threading.Tasks;
// Reference Newtonsoft
using Newtonsoft.Json;

using System.Net.Http;

namespace BlazorServerWeatherApp.Data
{
    public class ZipCodeResponseService
    {
        static readonly HttpClient client = new HttpClient();
        public static async Task<ZipCodeResponse> GetZipCodeResponseAsync(int zip) // static, really?
        {
            string baseUrl = "https://www.zipcodeapi.com/rest/";
            string key = "oMynInP0e36th2TV8VO1HiyW7SzQwMOpCXndHofT1D1DbqdcYqfBRH5uN2TIi5L1";

            string request = String.Concat(baseUrl, key, "/info.json/", zip, "/degrees");

            try
            {
                HttpResponseMessage response = await client.GetAsync(request);
                Console.WriteLine("You just used an API call, lol");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                
                return JsonConvert.DeserializeObject<ZipCodeResponse>(responseBody);

                // Mock data b/c API calls are limited
                /*ZipCodeResponse zipCodeResponse = new ZipCodeResponse();
                zipCodeResponse.Zip_Code = "90005";
                zipCodeResponse.City = "Los Angeles";
                zipCodeResponse.State = "CA";
                zipCodeResponse.Lat = 34.05919;
                zipCodeResponse.Lng = -118.306625;

                return zipCodeResponse;*/
            }
            catch(HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");	
                Console.WriteLine("Message :{0} ",e.Message);

                ZipCodeResponse zipCodeResponse = new ZipCodeResponse();
                zipCodeResponse.Zip_Code = "90005";
                zipCodeResponse.City = "Los Angeles";
                zipCodeResponse.State = "CA";
                zipCodeResponse.Lat = 34.05919;
                zipCodeResponse.Lng = -118.306625;

                // well this is fucky...
                //return ZipCodeResponse;
                Console.WriteLine("app is about to break, u probably ran out of API calls");
                return new ZipCodeResponse();
            }
        }
    }
}