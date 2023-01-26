using ExchangeRates.Repositories;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using System.Text.Json.Nodes;
using System.Xml;

namespace ExchangeRates.Services
{
    public class ExchangeRateService : IExchangeRateService
    {
        private readonly IExchangeRateRepository exchangeRateRepository;

        public ExchangeRateService(IExchangeRateRepository exchangeRateRepository)
        {
            this.exchangeRateRepository = exchangeRateRepository;
        }

        public async Task<ActionResult<List<ExchangeRateResponseDTO>>> GetExchangeRates()
        {
            Root myDeserializedClass = null;
            var response = await exchangeRateRepository.GetExchaneRatesAsync();
            if(response != null)
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(response.Content);
                string json = JsonConvert.SerializeXmlNode(doc, Newtonsoft.Json.Formatting.None, false);
                if (!String.IsNullOrEmpty(json))
                {
                    myDeserializedClass = JsonConvert.DeserializeObject<Root>(json);
                }
            }
            else
            {
                return null;
            }
            return myDeserializedClass?.ExchangeRatesResponseCollectioDTO?.ExchangeRates?.ExchangeRateResponseDTO;
        }

    }

}
