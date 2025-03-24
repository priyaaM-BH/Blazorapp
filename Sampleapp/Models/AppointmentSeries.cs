
namespace SampleApp.Models.s
{
    public class AppointmentSeries
    {
        public AppointmentSeries()
        {
            this.VisitReasonForm = new VisitReasonForm();
        }
        public string? ProviderID { get; set; }
        public VisitReasonForm? VisitReasonForm { get; set; }
        public string? SelectedTime { get; set; }
        public string? TelehealthCommunictaionEmail { get; set; }
        public bool IsEditing { get; set; }
        public string? WorkRelated { get; set; }
    }
}