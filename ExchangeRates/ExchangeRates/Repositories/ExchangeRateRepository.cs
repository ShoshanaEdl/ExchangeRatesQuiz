using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using System.Text.Json;

namespace ExchangeRates.Repositories
{
    public class ExchangeRateRepository : IExchangeRateRepository
    {

        public async Task<RestResponse> GetExchaneRatesAsync()
        {
            //has to be taken from config
            var client = new RestClient($"https://boi.org.il/PublicApi/GetExchangeRates?asXML=true");
            var request = new RestRequest("", Method.Get);
            var response = await client.ExecuteGetAsync(request);

            if (!response.IsSuccessful)
            {
                return null;
            }
            return response; 
        }
    }
}
