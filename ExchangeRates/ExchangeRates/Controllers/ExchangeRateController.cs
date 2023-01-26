using ExchangeRates.Services;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System.Net;

namespace ExchangeRates.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExchangRateController : ControllerBase
    {       

        private readonly IExchangeRateService exchangeRateService;

        public ExchangRateController(IExchangeRateService exchangeRateService)
        {
            this.exchangeRateService = exchangeRateService;
        }



        [HttpGet]
        public async Task<ActionResult<List<ExchangeRateResponseDTO>>> GetRates()
        {
            try
            {
                var result = await exchangeRateService.GetExchangeRates();
                return result;
            }
            catch (Exception ex)
            {
                //write to log ex
                return BadRequest(ex);
            }
            
        }
    }
}