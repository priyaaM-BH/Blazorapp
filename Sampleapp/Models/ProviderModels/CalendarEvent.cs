using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace SampleApp.Models.ProviderModels
{
    public class CalendarEvent
    {
        [JsonProperty("title")]
        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        [JsonProperty("location")]
        [JsonPropertyName("location")]
        public string Location { get; set; } = string.Empty;

        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        [JsonProperty("startDate")]
        [JsonPropertyName("startDate")]
        public string StartDate { get; set; } = string.Empty;

        [JsonProperty("endDate")]
        [JsonPropertyName("endDate")]
        public string EndDate { get; set; } = string.Empty;

        [JsonProperty("inPerson")]
        [JsonPropertyName("inPerson")]
        public bool InPerson { get; set; }

        [JsonProperty("timezone")]
        [JsonPropertyName("timezone")]
        public string TimeZone { get; set; } = string.Empty;
    }
}
