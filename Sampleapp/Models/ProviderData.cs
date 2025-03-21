namespace SampleApp.Models;

public class ProviderData
{
    public string providerId { get; set; } = string.Empty;
    public List<string> visitReasons { get; set; } = [];
    public bool seesNewPatients { get; set; }
}
