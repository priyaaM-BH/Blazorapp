namespace SampleApp.Models;

public class Provider
{
    public string providerId { get; set; } = string.Empty;
    public string lastName { get; set; } = string.Empty;
    public string firstName { get; set; } = string.Empty;
    public List<string> visitReasons { get; set; } = [];
    public bool seesNewPatients { get; set; }
}
