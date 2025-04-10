
namespace SampleApp.Models.s
{
    public class AppointmentModule
    {
        public AppointmentModule()
        {
            this.VisitReasonForm = new VisitReasonForm();
        }
        public string? ProviderID { get; set; }
        public VisitReasonForm? VisitReasonForm { get; set; }
        public string? SelectedTime { get; set; }
        public string? TelehealthCommunictaionEmail { get; set; }
        public bool IsEditing { get; set; }
        public bool IsTelehealth { get; set; }
        public string? WorkRelated { get; set; }
    }
}