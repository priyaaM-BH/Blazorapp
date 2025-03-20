using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace SampleApp.Models.ProviderModels
{
    public class TimeSlotsForVisitReason
    {
        [JsonProperty("visitReasonId")]
        [JsonPropertyName("visitReasonId")]
        public string VisitReasonId { get; set; } = string.Empty;

        [JsonProperty("nextAvailableSlotDate")]
        [JsonPropertyName("nextAvailableSlotDate")]
        public DateTime NextAvailableSlotDate { get; set; }

        [JsonProperty("timeSlots")]
        [JsonPropertyName("timeSlots")]
        public IEnumerable<TimeSlot>? TimeSlots { get; set; }
    }
}
