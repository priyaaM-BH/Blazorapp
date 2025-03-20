using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace SampleApp.Models.ProviderModels
{
    public class VisitReason
    {
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public string ID { get; set; } = string.Empty;

        [JsonProperty("code")]
        [JsonPropertyName("code")]
        public string Code { get; set; } = string.Empty;

        [JsonProperty("durationMinutes")]
        [JsonPropertyName("durationMinutes")]
        public double DurationMinutes { get; set; }

        [JsonProperty("wildCardSlot")]
        [JsonPropertyName("wildCardSlot")]
        public bool WildCardSlot { get; set; }

        [JsonProperty("source")]
        [JsonPropertyName("source")]
        public string Source { get; set; } = string.Empty;

        [JsonProperty("consumerVisibility")]
        [JsonPropertyName("consumerVisibility")]
        public string ConsumerVisibility { get; set; } = string.Empty;

        [JsonProperty("visitMethod")]
        [JsonPropertyName("visitMethod")]
        public string VisitMethod { get; set; } = string.Empty;

        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonProperty("patientRelationship")]
        [JsonPropertyName("patientRelationship")]
        public string PatientRelationship { get; set; } = string.Empty;
    }
}
