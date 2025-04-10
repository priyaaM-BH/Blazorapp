namespace SampleApp.Models;

public class ModuleEntryPoints
{
    public string moduleName { get; set; } = string.Empty;
    /// <summary>
    /// For a series with just one entry point, this will have just one entry like 'review/top'.
    /// But for a series with multiple entry points (navigated to from the Edit buttons), this list could be something like:
    ///     appointment/visit-reason
    ///     appointment/location-and-time
    ///     appointment/work-related
    /// </summary>
    public List<string> entryPointPageDirectives { get; set; } = [];
}
