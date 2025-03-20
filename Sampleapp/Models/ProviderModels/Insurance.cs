using Newtonsoft.Json;
using System.Text.Json.Serialization;
using JsonIgnoreAttribute = System.Text.Json.Serialization.JsonIgnoreAttribute;

namespace SampleApp.Models.ProviderModels
{
    public class Insurance
    {
        [JsonProperty("carrier")]
        [JsonPropertyName("carrier")]
        public string Carrier { get; set; } = string.Empty;

        [JsonProperty("plan")]
        [JsonPropertyName("plan")]
        public string Plan { get; set; } = string.Empty;

        [JsonProperty("groupNumber")]
        [JsonPropertyName("groupNumber")]
        public string GroupNumber { get; set; } = string.Empty;

        [JsonProperty("memberId")]
        [JsonPropertyName("memberId")]
        public string MemberId { get; set; } = string.Empty;

        [JsonProperty("zipCode")]
        [JsonPropertyName("zipCode")]
        public string ZipCode { get; set; } = string.Empty;

        [JsonProperty("patientId")]
        [JsonPropertyName("patientId")]
        public int? PatientId { get; set; }

        [JsonIgnore]
        public bool PatientIsInsuranceSubscriber { get; set; }
        [JsonProperty("insuranceSubscriber")]
        [JsonPropertyName("insuranceSubscriber")]
        public InsuranceSubscriber? InsuranceSubscriber { get; set; }
    }
}
