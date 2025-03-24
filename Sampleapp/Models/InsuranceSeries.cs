namespace SampleApp.Models.s
{
    public class InsuranceSeries
    {
        public InsuranceSeries()
        {
            this.InsuranceDetailsForm = new InsuranceDetailsForm();
        }
        public InsuranceDetailsForm? InsuranceDetailsForm { get; set; }
        public string? InsuranceChoice { get; set; }
        public string? GFEEmail { get; set; }
    }
}