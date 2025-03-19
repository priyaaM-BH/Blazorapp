namespace SampleApp.Models
{
    public class BookingDetails
    {
        public BookingDetails()
        {
            this.VisitReasonForm = new VisitReasonForm();
        }
        public BookingFor? BookingFor { get; set; }
        public VisitReasonForm? VisitReasonForm { get; set; }
        public string? SelectedTime { get; set; }
        public string? TelehealthCommunictaionEmail { get; set; }

    }
}