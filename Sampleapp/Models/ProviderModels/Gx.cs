using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace SampleApp.Models.ProviderModels
{
    public class Gx
    {
        [JsonProperty("maxAge")]
        [JsonPropertyName("maxAge")]
        public int? MaxAge { get; set; }

        [JsonProperty("minAge")]
        [JsonPropertyName("minAge")]
        public int? MinAge { get; set; }
    }
}
