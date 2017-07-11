using Newtonsoft.Json;

namespace Filter.Common.Structures
{
    public struct CurrencyRate
    {
        [JsonProperty("r030")]
        public int Id { get; set; }

        [JsonProperty("txt")]
        public string Text { get; set; }

        [JsonProperty("rate")]
        public double Rate { get; set; }

        [JsonProperty("cc")]
        public string Cc { get; set; }

        [JsonProperty("exchangedate")]
        public string ExchangeData { get; set; } 
    }
}