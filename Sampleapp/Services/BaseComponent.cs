using System.Text.Json;
using Microsoft.AspNetCore.Components;
using SampleApp.Models.ProviderModels;
using SampleApp.Models.MainStateContainers;


namespace SampleApp.Services
{
public class BaseComponent : ComponentBase
{
    #region Permanent Series Data
    public Models.MainStateContainers.VisitReasonSeries _visitReasonSeries { get; set; } = new();
    public Models.MainStateContainers.InsuranceSeries _InsuranceSeries { get; set; } = new();
    #endregion

    #region Temporary Series Data
    public Models.MainStateContainers.VisitReasonSeries _wipVisitReasonSeries { get; set; } = new();
    private Models.MainStateContainers.InsuranceSeries _wipInsuranceSeries { get; set; } = new();
    public bool _inEdit = false;

    #endregion

    #region dependency injections
    [Inject]
    protected NavigationManager _navigationManager { get; set; } = default!;
    #endregion

    #region initial Data from all http calls
    public static Models.ProviderData _ProviderInformation{ get; set; } = new();
    //TODO: add portal user me, relationships, portal Application, insurance get coverages as public fields here
    public static Models.MainStateContainers.PatientInformationSeries _patientInformationSeries { get; set; } = new();
    #endregion

}
}

