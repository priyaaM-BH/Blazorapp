// Ignore Spelling: App

namespace SampleApp.Models.MainStateContainers;

public class PatientInformationSeries
{
    //Everything related to patient data goes here
    public BookingFor BookingFor { get; set; }
    public string? portalUserId { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public DateOnly dateOfBirth { get; set; }
}