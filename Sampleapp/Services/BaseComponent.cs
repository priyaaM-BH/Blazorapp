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
   

    #endregion

    #region Page Directives
    /// <summary>
    /// This is set by the controller's On Initialize method which also initializes the ModulesAndPageDirectives list
    /// </summary>
    public static List<ModuleEntryPoints> ModuleEntryPointsList = [];
    //These are the pages each module visited.  If appointment module gets invoked, the first page of the module
    //will create a new list with one entry being the page directive of the visit reason page.
    //
    //If then Sophia navigates to the next page, that page's oninitialize will add its page directive to the list.
    //
    //Any time Sophia hits the back button to go to a previous page, that page to remove the last entry (itself) in the list.
    public static List<ModuleEntryPoints> ModulePagesVisitedList { get; set; } = new List<ModuleEntryPoints>();
    public class ModulePagesVisited
    {
        public List<string> PagesVisited { get; set; } = new();
    }

    public int GetModuleOffset(string moduleName)
    {
        return ModuleEntryPointsList.FindIndex(n => n.moduleName.ToLower() == moduleName.ToLower());
    }

    public static void AddPageDirective(string moduleName, string pageDirective)
    {
        // Find the pagedirective that matches the moduleName
        bool containsSpecificEntry = ModulePagesVisitedList.Any(nav => nav.moduleName.Equals(moduleName, StringComparison.OrdinalIgnoreCase) &&
                                            nav.entryPointPageDirectives.Contains(pageDirective));
        // Find the index that matches the moduleName
        int moduleIndex = ModulePagesVisitedList.FindIndex(n => n.moduleName.Equals(moduleName, StringComparison.OrdinalIgnoreCase));
        if (moduleIndex != -1 && !containsSpecificEntry)
        {
            ModulePagesVisitedList[moduleIndex].entryPointPageDirectives.Add(pageDirective);
        }
        else if(moduleIndex == -1)
        {
            ModuleEntryPoints ModuleEntryPoints = new()
            {
                entryPointPageDirectives = [pageDirective],
                moduleName = moduleName,
            };
            ModulePagesVisitedList.Add(ModuleEntryPoints);
        }
    }

    public static void RemovePageDirective(string moduleName, string pageDirective)
    {
        // Find the ModuleEntryPoints that matches the moduleName
        var moduleEntry = ModulePagesVisitedList
            .FirstOrDefault(nav => nav.moduleName.Equals(moduleName, StringComparison.OrdinalIgnoreCase));

        if (moduleEntry != null)
        {
            // Check if the pageDirective exists in the entryPointPageDirectives list
            if (moduleEntry.entryPointPageDirectives.Contains(pageDirective))
            {
                // Remove the pageDirective
                moduleEntry.entryPointPageDirectives.Remove(pageDirective);
            }
            else
            {
                Console.WriteLine($"'{pageDirective}' not found in module '{moduleName}'.");
            }
        }
        else
        {
            Console.WriteLine($"Module '{moduleName}' not found.");
        }
    }
    #endregion

}
}

