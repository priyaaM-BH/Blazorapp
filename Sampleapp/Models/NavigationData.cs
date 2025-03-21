namespace SampleApp.Models;

public class NavigationData
{
    public string seriesName { get; set; } = string.Empty;
    public string pageDirective { get; set; } = string.Empty;
    public List<string> pageSections { get; set; } = [];
}
