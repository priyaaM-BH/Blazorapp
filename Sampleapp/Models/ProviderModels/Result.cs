using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace SampleApp.Models.ProviderModels
{
    public class Result
    {
        [JsonProperty("locations")]
        [JsonPropertyName("locations")]
        public IEnumerable<Location>? Locations { get; set; }

        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public string ID { get; set; } = string.Empty;

        [JsonProperty("acceptingNewPatients")]
        [JsonPropertyName("acceptingNewPatients")]
        public string AcceptingNewPatients { get; set; } = string.Empty;

        [JsonProperty("ageGroupsSeen")]
        [JsonPropertyName("ageGroupsSeen")]
        public string AgeGroupsSeen { get; set; } = string.Empty;

        [JsonProperty("approachToCare")]
        [JsonPropertyName("approachToCare")]
        public string ApproachToCare { get; set; } = string.Empty;

        [JsonProperty("boardCertifications")]
        [JsonPropertyName("boardCertifications")]
        public IEnumerable<BoardCertification>? BoardCertifications { get; set; }

        [JsonProperty("clinicLocationUrl")]
        [JsonPropertyName("clinicLocationUrl")]
        public string ClinicLocationUrl { get; set; } = string.Empty;

        [JsonProperty("credentialedSpecialties")]
        [JsonPropertyName("credentialedSpecialties")]
        public string CredentialedSpecialties { get; set; } = string.Empty;

        [JsonProperty("currentStatus")]
        [JsonPropertyName("currentStatus")]
        public string CurrentStatus { get; set; } = string.Empty;

        [JsonProperty("degrees")]
        [JsonPropertyName("degrees")]
        public string Degrees { get; set; } = string.Empty;

        [JsonProperty("kyruusId")]
        [JsonPropertyName("kyruusId")]
        public string KyruusId { get; set; } = string.Empty;

        [JsonProperty("gender")]
        [JsonPropertyName("gender")]
        public string Gender { get; set; } = string.Empty;

        [JsonProperty("gx")]
        [JsonPropertyName("gx")]
        public Gx? Gx { get; set; }

        [JsonProperty("imageUrl")]
        [JsonPropertyName("imageUrl")]
        public string ImageUrl { get; set; } = string.Empty;

        [JsonProperty("insuranceAccepted")]
        [JsonPropertyName("insuranceAccepted")]
        public string InsuranceAccepted { get; set; } = string.Empty;

        [JsonProperty("isLive")]
        [JsonPropertyName("isLive")]
        public string IsLive { get; set; } = string.Empty;

        [JsonProperty("isPrimaryCare")]
        [JsonPropertyName("isPrimaryCare")]
        public string IsPrimaryCare { get; set; } = string.Empty;

        [JsonProperty("isSpecialtyCare")]
        [JsonPropertyName("isSpecialtyCare")]
        public string IsSpecialtyCare { get; set; } = string.Empty;

        [JsonProperty("languages")]
        [JsonPropertyName("languages")]
        public string Languages { get; set; } = string.Empty;

        [JsonProperty("lastModified")]
        [JsonPropertyName("lastModified")]
        public string LastModified { get; set; } = string.Empty;

        [JsonProperty("lastUpdated")]
        [JsonPropertyName("lastUpdated")]
        public string LastUpdated { get; set; } = string.Empty;

        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public Name? Name { get; set; }

        [JsonProperty("networks")]
        [JsonPropertyName("networks")]
        public string Networks { get; set; } = string.Empty;

        [JsonProperty("optumEmploymentSubStatus")]
        [JsonPropertyName("optumEmploymentSubStatus")]
        public string OptumEmploymentSubStatus { get; set; } = string.Empty;

        [JsonProperty("npi")]
        [JsonPropertyName("npi")]
        public string NPI { get; set; } = string.Empty;

        [JsonProperty("onlineSchedulingEnabled")]
        [JsonPropertyName("onlineSchedulingEnabled")]
        public bool OnlineSchedulingEnabled { get; set; }

        [JsonProperty("preferredName")]
        [JsonPropertyName("preferredName")]
        public string PreferredName { get; set; } = string.Empty;

        [JsonProperty("providerType")]
        [JsonPropertyName("providerType")]
        public string ProviderType { get; set; } = string.Empty;

        [JsonProperty("publicOnly")]
        [JsonPropertyName("publicOnly")]
        public bool IsPublicOnly { get; set; }

        [JsonProperty("rank")]
        [JsonPropertyName("rank")]
        public int Rank { get; set; }

        [JsonProperty("researchPubs")]
        [JsonPropertyName("researchPubs")]
        public string ResearchPubs { get; set; } = string.Empty;

        [JsonProperty("ratingAndTestimonials")]
        [JsonPropertyName("ratingAndTestimonials")]
        public RatingAndTestimonials? RatingAndTestimonials { get; set; }

        [JsonProperty("schedIntervalSameDayMinuteDelay")]
        [JsonPropertyName("schedIntervalSameDayMinuteDelay")]
        public int SchedIntervalSameDayMinuteDelay { get; set; }

        [JsonProperty("scopeOfPractice")]
        [JsonPropertyName("scopeOfPractice")]
        public string ScopeOfPractice { get; set; } = string.Empty;

        [JsonProperty("specializingIn")]
        [JsonPropertyName("specializingIn")]
        public string SpecializingIn { get; set; } = string.Empty;

        [JsonProperty("specialties")]
        [JsonPropertyName("specialties")]
        public IEnumerable<Specialty>? Specialties { get; set; }

        [JsonProperty("telehealth")]
        [JsonPropertyName("telehealth")]
        public string Telehealth { get; set; } = string.Empty;

        [JsonProperty("timeSlotsForDayRange")]
        [JsonPropertyName("timeSlotsForDayRange")]
        public IEnumerable<TimeSlotsForDayRange>? TimeSlotsForDayRange { get; set; }

        [JsonProperty("training")]
        [JsonPropertyName("training")]
        public IEnumerable<Training>? Training { get; set; }

        [JsonProperty("videoUrl")]
        [JsonPropertyName("videoUrl")]
        public string VideoUrl { get; set; } = string.Empty;

        [JsonProperty("visitReasons")]
        [JsonPropertyName("visitReasons")]
        public IEnumerable<VisitReason>? VisitReasons { get; set; }
    }
}
