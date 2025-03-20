using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace SampleApp.Models.ProviderModels
{
    public class TimeSlotsForDayRange
    {
        [JsonProperty("date")]
        [JsonPropertyName("date")]
        public DateTime Date { get; set; }

        [JsonProperty("nextAvailableSlotDate")]
        [JsonPropertyName("nextAvailableSlotDate")]
        public DateTime NextAvailableSlotDate { get; set; }

        [JsonProperty("timeSlotsForLocations")]
        [JsonPropertyName("timeSlotsForLocations")]
        public IEnumerable<TimeSlotsForLocation>? TimeSlotsForLocations { get; set; }
    }
}
