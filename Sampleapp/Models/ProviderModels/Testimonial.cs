using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace SampleApp.Models.ProviderModels
{
    public class Testimonial
    {
        [JsonProperty("body")]
        [JsonPropertyName("body")]
        public string Body { get; set; } = string.Empty;

        [JsonProperty("rating")]
        [JsonPropertyName("rating")]
        public int Rating { get; set; }

        [JsonProperty("date")]
        [JsonPropertyName("date")]
        public string Date { get; set; } = string.Empty;
    }
}
