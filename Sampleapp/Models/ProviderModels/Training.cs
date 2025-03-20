using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace SampleApp.Models.ProviderModels
{
    public class Training
    {
        [JsonProperty("city")]
        [JsonPropertyName("city")]
        public string City { get; set; } = string.Empty;

        [JsonProperty("country")]
        [JsonPropertyName("country")]
        public string Country { get; set; } = string.Empty;

        [JsonProperty("fieldOfStudy")]
        [JsonPropertyName("fieldOfStudy")]
        public string FieldOfStudy { get; set; } = string.Empty;

        [JsonProperty("graduationDate")]
        [JsonPropertyName("graduationDate")]
        public string GraduationDate { get; set; } = string.Empty;

        [JsonProperty("graduationYear")]
        [JsonPropertyName("graduationYear")]
        public string GraduationYear { get; set; } = string.Empty;

        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonProperty("rank")]
        [JsonPropertyName("rank")]
        public string Rank { get; set; } = string.Empty;

        [JsonProperty("state")]
        [JsonPropertyName("state")]
        public string State { get; set; } = string.Empty;

        [JsonProperty("street1")]
        [JsonPropertyName("street1")]
        public string Street1 { get; set; } = string.Empty;

        [JsonProperty("street2")]
        [JsonPropertyName("street2")]
        public string Street2 { get; set; } = string.Empty;

        [JsonProperty("type")]
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        [JsonProperty("zip")]
        [JsonPropertyName("zip")]
        public string Zip { get; set; } = string.Empty;
    }
}
