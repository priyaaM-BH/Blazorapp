using Microsoft.AspNetCore.Components;
using SampleApp.Models.MainStateContainers;

namespace SampleApp.Services
{
public class BaseComponent : ComponentBase
{
    [Inject]
    protected NavigationManager _navigationManager { get; set; } = default!;
    public static VisitReasonSeries _modelState { get; set; } = new();

    public static InsuranceSeries _InsuranceSeries { get; set; } = new();

}
}

