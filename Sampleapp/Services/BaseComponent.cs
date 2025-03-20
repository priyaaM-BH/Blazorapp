using Microsoft.AspNetCore.Components;
using SampleApp.Models;

namespace SampleApp.Services
{
public class BaseComponent : ComponentBase
{
    [Inject]
    protected NavigationManager _navigationManager { get; set; } = default!;
    public static ApplicationData _modelState { get; set; } = new();

}
}

