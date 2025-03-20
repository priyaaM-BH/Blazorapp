using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace SampleApp.Models.ProviderModels
{
    public class TimeSlot
    {
        [JsonProperty("startTime")]
        [JsonPropertyName("startTime")]
        public DateTime StartTime { get; set; }

        [JsonProperty("endTime")]
        [JsonPropertyName("endTime")]
        public DateTime EndTime { get; set; }

        [JsonProperty("slotId")]
        [JsonPropertyName("slotId")]
        public string SlotId { get; set; } = string.Empty;
    }
}
