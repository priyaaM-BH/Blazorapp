namespace SampleApp.Models.s
{
    public class InsuranceSeries
    {
        public InsuranceSeries()
        {
            this.InsuranceDetailsForm = new InsuranceDetailsForm();
        }
        public InsuranceDetailsForm? InsuranceDetailsForm { get; set; }
        public string InsuranceChoice { get; set; } = string.Empty;
        public string GFEEmail { get; set; } = string.Empty;
    }
}