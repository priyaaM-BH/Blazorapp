using System.Text.Json;
using Microsoft.AspNetCore.Components;
using SampleApp.Models;
using SampleApp.Models.s;


namespace SampleApp.Services
{
public class BaseComponent : ComponentBase
{
    #region Permanent Series Data
    public static Models.s.AppointmentSeries _appointmentSeries { get; set; } = new();
    public static Models.s.InsuranceSeries _insuranceSeries { get; set; } = new();
    public static Models.s.PatientInformationSeries _patientInformationSeries { get; set; } = new();
    public static Models.PatientInformationSeries2 _patientInformationSeries2 { get; set; } = new();
    public static Models.Provider _ProviderInformation{ get; set; } = new();
    #endregion

    #region Temporary Series Data
    public static Models.s.AppointmentSeries _wipAppointmentSeries { get; set; } = new();
    public static InsuranceSeries _wipInsuranceSeries { get; set; } = new();
    public static PatientInformationSeries2 _wipPatientInformationSeries2 { get; set; } = new();
    public static PatientInformationSeries _wipPatientInformationSeries { get; set; } = new();
    public static bool _inEdit = false;
    public static bool _isTeleHealth { get; set; }
    #endregion

    #region dependency injections
    [Inject]
    protected NavigationManager _navigationManager { get; set; } = default!;
    #endregion

    #region initial Data from all http calls
    
    //TODO: add portal user me, relationships, portal Application, insurance get coverages as public fields here
    
    #endregion

}
}

