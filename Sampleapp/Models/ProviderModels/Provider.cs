using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace SampleApp.Models.ProviderModels
{
    public class Provider
    {
        [JsonProperty("content")]
        [JsonPropertyName("content")]
        public Content? Content { get; set; }
    }
}
