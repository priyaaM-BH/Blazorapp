using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace SampleApp.Models.ProviderModels
{
    public class Location
    {
        [JsonProperty("city")]
        [JsonPropertyName("city")]
        public string City { get; set; } = string.Empty;

        [JsonProperty("commercialEntityName")]
        [JsonPropertyName("commercialEntityName")]
        public string CommercialEntityName { get; set; } = string.Empty;

        [JsonProperty("latitude")]
        [JsonPropertyName("latitude")]
        public string Latitude { get; set; } = string.Empty;

        [JsonProperty("longitude")]
        [JsonPropertyName("longitude")]
        public string Longitude { get; set; } = string.Empty;

        [JsonProperty("distance")]
        [JsonPropertyName("distance")]
        public string Distance { get; set; } = string.Empty;

        [JsonProperty("email")]
        [JsonPropertyName("email")]
        public string Email { get; set; } = string.Empty;

        [JsonProperty("externalId")]
        [JsonPropertyName("externalId")]
        public string ExternalID { get; set; } = string.Empty;

        [JsonProperty("facilityFee")]
        [JsonPropertyName("facilityFee")]
        public string FacilityFee { get; set; } = string.Empty;

        [JsonProperty("fax")]
        [JsonPropertyName("fax")]
        public string Fax { get; set; } = string.Empty;

        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonProperty("officeHours")]
        [JsonPropertyName("officeHours")]
        public string OfficeHours { get; set; } = string.Empty;

        [JsonProperty("phone")]
        [JsonPropertyName("phone")]
        public string Phone { get; set; } = string.Empty;

        [JsonProperty("rank")]
        [JsonPropertyName("rank")]
        public string Rank { get; set; } = string.Empty;

        [JsonProperty("state")]
        [JsonPropertyName("state")]
        public string State { get; set; } = string.Empty;

        [JsonProperty("timeZone")]
        [JsonPropertyName("timeZone")]
        public string TimeZone { get; set; } = string.Empty;

        [JsonProperty("street1")]
        [JsonPropertyName("street1")]
        public string Street1 { get; set; } = string.Empty;

        [JsonProperty("street2")]
        [JsonPropertyName("street2")]
        public string Street2 { get; set; } = string.Empty;

        [JsonProperty("suite")]
        [JsonPropertyName("suite")]
        public string Suite { get; set; } = string.Empty;

        [JsonProperty("type")]
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        [JsonProperty("zip")]
        [JsonPropertyName("zip")]
        public string Zip { get; set; } = string.Empty;
    }
}
