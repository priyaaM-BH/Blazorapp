using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace SampleApp.Models.ProviderModels
{
    public class RatingAndTestimonials
    {
        [JsonProperty("ratingAverage")]
        [JsonPropertyName("ratingAverage")]
        public double RatingAverage { get; set; }

        [JsonProperty("ratingCount")]
        [JsonPropertyName("ratingCount")]
        public int RatingCount { get; set; }

        [JsonProperty("testimonialCount")]
        [JsonPropertyName("testimonialCount")]
        public int TestimonialCount { get; set; }

        [JsonProperty("testimonials")]
        [JsonPropertyName("testimonials")]
        public IEnumerable<Testimonial>? Testimonials { get; set; }
    }
}
