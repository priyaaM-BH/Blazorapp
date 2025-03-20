using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace SampleApp.Models.ProviderModels
{
    public class Name
    {
        [JsonProperty("firstName")]
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; } = string.Empty;

        [JsonProperty("fullName")]
        [JsonPropertyName("fullName")]
        public string FullName { get; set; } = string.Empty;

        [JsonProperty("lastName")]
        [JsonPropertyName("lastName")]
        public string LastName { get; set; } = string.Empty;

        [JsonProperty("middleName")]
        [JsonPropertyName("middleName")]
        public string MiddleName { get; set; } = string.Empty;

        [JsonProperty("suffix")]
        [JsonPropertyName("suffix")]
        public string Suffix { get; set; } = string.Empty;
    }
}
