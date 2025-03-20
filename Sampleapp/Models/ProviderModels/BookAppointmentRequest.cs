using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace SampleApp.Models.ProviderModels
{
    public class BookAppointmentRequest
    {
        [JsonProperty("slotId")]
        [JsonPropertyName("slotId")]
        public string SlotID { get; set; } = string.Empty;

        [JsonProperty("providerId")]
        [JsonPropertyName("providerId")]
        public string ProviderId { get; set; } = string.Empty;

        [JsonProperty("lastName")]
        [JsonPropertyName("lastName")]
        public string LastName { get; set; } = string.Empty;

        [JsonProperty("firstName")]
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; } = string.Empty;

        [JsonProperty("selfPay")]
        [JsonPropertyName("selfPay")]
        public bool IsSelfPay { get; set; }

        [JsonProperty("insurances")]
        [JsonPropertyName("insurances")]
        public List<Insurance>? Insurances { get; set; }

        [JsonProperty("notificationAgreementList")]
        [JsonPropertyName("notificationAgreementList")]
        public List<NotificationAgreements>? NotificationAgreementList { get; set; }

        [JsonProperty("visitReasonComment")]
        [JsonPropertyName("visitReasonComment")]
        public string VisitReasonComment { get; set; } = string.Empty;

        [JsonProperty("workComp")]
        [JsonPropertyName("workComp")]
        public WorkRelated WorkComp { get; set; } = WorkRelated.Unselected;

        [JsonProperty("workCompDetails")]
        [JsonPropertyName("workCompDetails")]
        public string WorkCompDetails { get; set; } = string.Empty;

        [JsonProperty("patientSourceId")]
        [JsonPropertyName("patientSourceId")]
        public string PatientSourceId { get; set; } = string.Empty;

        [JsonProperty("gfeDeliveryMethod")]
        [JsonPropertyName("gfeDeliveryMethod")]
        public string GFEDeliveryMethod { get; set; } = string.Empty;

        [JsonProperty("deliveryAddress")]
        [JsonPropertyName("deliveryAddress")]
        public string DeliveryAddress { get; set; } = string.Empty;

        [JsonProperty("virtualCareAttestation")]
        [JsonPropertyName("virtualCareAttestation")]
        public bool VirtualCareAttestation { get; set; }

        [JsonProperty("communicationMethod")]
        [JsonPropertyName("communicationMethod")]
        public string CommunicationMethod { get; set; } = string.Empty;

        [JsonProperty("communicationEmailAddress")]
        [JsonPropertyName("communicationEmailAddress")]
        public string CommunicationEmailAddress { get; set; } = string.Empty;

        [JsonProperty("communicationPhoneNumber")]
        [JsonPropertyName("communicationPhoneNumber")]
        public string CommunicationPhoneNumber { get; set; } = string.Empty;

        [JsonProperty("middleInitial")]
        [JsonPropertyName("middleInitial")]
        public string MiddleInitial { get; set; } = string.Empty;

        [JsonProperty("dateOfBirth")]
        [JsonPropertyName("dateOfBirth")]
        public string DateOfBirth { get; set; } = string.Empty;

        [JsonProperty("gender")]
        [JsonPropertyName("gender")]
        public string Gender { get; set; } = string.Empty;

        [JsonProperty("emailAddress")]
        [JsonPropertyName("emailAddress")]
        public string EmailAddress { get; set; } = string.Empty;

        [JsonProperty("phoneNumber")]
        [JsonPropertyName("phoneNumber")]
        public string PhoneNumber { get; set; } = string.Empty;

        [JsonProperty("addressLine1")]
        [JsonPropertyName("addressLine1")]
        public string AddressLine1 { get; set; } = string.Empty;

        [JsonProperty("addressLine2")]
        [JsonPropertyName("addressLine2")]
        public string AddressLine2 { get; set; } = string.Empty;

        [JsonProperty("city")]
        [JsonPropertyName("city")]
        public string City { get; set; } = string.Empty;

        [JsonProperty("state")]
        [JsonPropertyName("state")]
        public string State { get; set; } = string.Empty;

        [JsonProperty("zipCode")]
        [JsonPropertyName("zipCode")]
        public string ZipCode { get; set; } = string.Empty;
    }
}
