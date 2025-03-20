using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace SampleApp.Models.ProviderModels
{
    public class BoardCertification
    {
        [JsonProperty("boardName")]
        [JsonPropertyName("boardName")]
        public string BoardName { get; set; } = string.Empty;

        [JsonProperty("certificationType")]
        [JsonPropertyName("certificationType")]
        public string CertificationType { get; set; } = string.Empty;

        [JsonProperty("specialtyName")]
        [JsonPropertyName("specialtyName")]
        public string SpecialtyName { get; set; } = string.Empty;

        [JsonProperty("yearCertified")]
        [JsonPropertyName("yearCertified")]
        public string YearCertified { get; set; } = string.Empty;
    }
}
