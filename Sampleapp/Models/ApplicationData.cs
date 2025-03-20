
namespace SampleApp.Models
{
    public class ApplicationData
    {
        public ApplicationData()
        {
            this.VisitReasonForm = new VisitReasonForm();
        }
        public string? ProviderID { get; set; }
        public BookingFor? BookingFor { get; set; }
        public VisitReasonForm? VisitReasonForm { get; set; }
        public string? SelectedTime { get; set; }
        public string? TelehealthCommunictaionEmail { get; set; }

    }
}