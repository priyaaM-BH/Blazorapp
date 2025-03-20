using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace SampleApp.Models.ProviderModels
{
    public class NotificationAgreements
    {
        [JsonProperty("agreement")]
        [JsonPropertyName("agreement")]
        public int Agreement { get; set; }
    }
}
