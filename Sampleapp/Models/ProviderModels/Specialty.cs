using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace SampleApp.Models.ProviderModels
{
    public class Specialty
    {
        [JsonProperty("specialty")]
        [JsonPropertyName("specialty")]
        public string SpecialtyName { get; set; } = string.Empty;

        [JsonProperty("subspecialty")]
        [JsonPropertyName("subspecialty")]
        public IEnumerable<string>? Subspecialty { get; set; }
    }
}
