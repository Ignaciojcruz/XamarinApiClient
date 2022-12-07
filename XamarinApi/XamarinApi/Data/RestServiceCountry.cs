using Newtonsoft.Json;
using System; 
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinApi.Models;

namespace XamarinApi.Data
{
    public class RestServiceCountry
    {
        string BaseUrl;
        string modelUrl;

        public RestServiceCountry()
        {
            BaseUrl = Constants.webapiUrl;
            modelUrl = "api/Country";
        }

        public async Task<List<Country>> GetCountrysAsync()
        {
            List<Country> countryList = new List<Country>();

            try
            {
                using(var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(this.BaseUrl);
                    client.DefaultRequestHeaders.Clear();

                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.GetAsync(modelUrl);

                    if(response.IsSuccessStatusCode)
                    {
                        var countryResponse = response.Content.ReadAsStringAsync().Result;
                        countryList = JsonConvert.DeserializeObject<List<Country>>(countryResponse);
                    }

                }
            }catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            
            return countryList;
        }
    }
}
