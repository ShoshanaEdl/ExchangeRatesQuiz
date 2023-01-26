// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
using Newtonsoft.Json;

public class ExchangeRateResponseDTO
{
    public Double CurrentChange { get; set; }
    public Double CurrentExchangeRate { get; set; }
    public string Key { get; set; }
    public DateTime LastUpdate { get; set; }
    public string Unit { get; set; }
}

public class ExchangeRateResponse
{
    public List<ExchangeRateResponseDTO> ExchangeRateResponseDTO { get; set; }
}

public class ExchangeRatesResponseCollectioDTO
{
    [JsonProperty("@xmlns:i")]
    public string xmlnsi { get; set; }

    [JsonProperty("@xmlns")]
    public string xmlns { get; set; }
    public ExchangeRateResponse ExchangeRates { get; set; }
}

public class Root
{
    public ExchangeRatesResponseCollectioDTO ExchangeRatesResponseCollectioDTO { get; set; }
}