using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace SampleApp.Models.ProviderModels
{
    public class InsuranceSubscriber
    {
        [JsonProperty("subscriberName")]
        [JsonPropertyName("subscriberName")]
        public string SubscriberName { get; set; } = string.Empty;

        [JsonProperty("subscriberDOB")]
        [JsonPropertyName("subscriberDOB")]
        public string SubscriberDOB { get; set; } = string.Empty;

        [JsonProperty("subscriberRelation")]
        [JsonPropertyName("subscriberRelation")]
        public string SubscriberRelation { get; set; } = string.Empty;
    }
}
