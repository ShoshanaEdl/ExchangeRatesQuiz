using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace ExchangeRates.Repositories
{
    public interface IExchangeRateRepository
    {
        Task<RestResponse> GetExchaneRatesAsync();
    }
}
