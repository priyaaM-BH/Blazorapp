
namespace SampleApp.Models.MainStateContainers
{
    public class VisitReasonSeries
    {
        public VisitReasonSeries()
        {
            this.VisitReasonForm = new VisitReasonForm();
        }
        public string? ProviderID { get; set; }
        public VisitReasonForm? VisitReasonForm { get; set; }
        public string? SelectedTime { get; set; }
        public string? TelehealthCommunictaionEmail { get; set; }
        public bool IsEditing { get; set; }
    }
}