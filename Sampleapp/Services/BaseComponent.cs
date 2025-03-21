using System.Text.Json;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SampleApp.Models;
using SampleApp.Models.MainStateContainers;

namespace SampleApp.Services
{
public class BaseComponent : ComponentBase
{
    #region Permanent Series Data
    public VisitReasonSeries _visitReasonSeries { get; set; } = new();
    public InsuranceSeries _InsuranceSeries { get; set; } = new();
    #endregion

    #region Temporary Series Data
    public VisitReasonSeries _wipVisitReasonSeries { get; set; } = new();

    private InsuranceSeries _wipInsuranceSeries { get; set; } = new();
    #endregion

    #region dependency injections
    [Inject]
    protected NavigationManager _navigationManager { get; set; } = default!;

    [Inject]
    protected IWebAssemblyHostEnvironment _WebHostEnvironment { get; set; }  = default!;
    #endregion

    #region initial Data from all http calls
    public static ProviderData _ProviderInformation{ get; set; } = new();
    //TODO: add portal user me, relationships, portal Application, insurance get coverages as public fields here
    public static PatientInformationSeries _patientInformationSeries { get; set; } = new();
    #endregion

}
}

