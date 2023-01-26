using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace ExchangeRates.Services
{
    public interface IExchangeRateService
    {

        Task<ActionResult<List<ExchangeRateResponseDTO>>> GetExchangeRates();
    }
}
