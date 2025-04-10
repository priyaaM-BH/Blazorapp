using System.Text.Json;
using Microsoft.AspNetCore.Components;
using SampleApp.Models;
using SampleApp.Models.s;


namespace SampleApp.Services
{
public class BaseComponent : ComponentBase
{
    #region Permanent Series Data
    public static Models.s.AppointmentModule _AppointmentModule { get; set; } = new();
    public static Models.s.InsuranceModule _InsuranceModule { get; set; } = new();
    public static Models.s.PatientSelectionmodule _PatientSelectionmodule { get; set; } = new();
    public static Models.PatientInformationmodule _PatientInformationmodule { get; set; } = new();
    public static Models.Provider _ProviderInformation{ get; set; } = new();
    #endregion

    #region Temporary Series Data
    public static Models.s.AppointmentModule _wipAppointmentModule { get; set; } = new();
    public static InsuranceModule _wipInsuranceModule { get; set; } = new();
    public static PatientInformationmodule _wipPatientInformationmodule { get; set; } = new();
    public static PatientSelectionmodule _wipPatientSelectionmodule { get; set; } = new();
    public static bool InEdit = false;
    public static bool IsTeleHealth { get; set; }
    #endregion

    #region dependency injections
    [Inject]
    protected NavigationManager NavigationManager { get; set; } = default!;
    #endregion

     #region Page Directives
    //These are the pages each module visited.  If appointment module gets invoked, the first page of the module
    //will create a new list with one entry being the page directive of the visit reason page.
    //
    //If then Sophia navigates to the next page, that page's oninitialize will add its page directive to the list.
    //
    //Any time Sophia hits the back button to go to a previous page, that page to remove the last entry (itself) in the list.
    public static List<string> PatientSelectionPageDirectives { get; set; } = [];
    public static List<string> AppointmentPageDirectives { get; set; } = [];
    public static List<string> PatientInformationPageDirectives { get; set; } = [];
    public static List<string> InsurancePageDirectives { get; set; } = [];

    #endregion

    #region initial Data from all http calls
    
    //TODO: add portal user me, relationships, portal Application, insurance get coverages as public fields here
    
    #endregion

}
}

