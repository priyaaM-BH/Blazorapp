using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace SampleApp.Models.ProviderModels
{
    public class Content
    {
        [JsonProperty("status")]
        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;

        [JsonProperty("results")]
        [JsonPropertyName("results")]
        public IEnumerable<Result>? Results { get; set; }
    }
}
