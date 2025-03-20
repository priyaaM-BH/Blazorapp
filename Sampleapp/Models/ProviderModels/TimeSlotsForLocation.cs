using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace SampleApp.Models.ProviderModels
{
    public class TimeSlotsForLocation
    {
        [JsonProperty("locationId")]
        [JsonPropertyName("locationId")]
        public string LocationID { get; set; } = string.Empty;

        [JsonProperty("nextAvailableSlotDate")]
        [JsonPropertyName("nextAvailableSlotDate")]
        public DateTime? NextAvailableSlotDate { get; set; }

        [JsonProperty("timeSlotsForVisitReasons")]
        [JsonPropertyName("timeSlotsForVisitReasons")]
        public IEnumerable<TimeSlotsForVisitReason>? TimeSlotsForVisitReasons { get; set; }
    }
}
