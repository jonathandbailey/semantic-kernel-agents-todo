namespace Todo.Application.Settings
{
    public class OpenTelemetrySettings
    {
        public string ApplicationName { get; set; } = string.Empty;
        public List<string> TraceProviderSourceNames { get; set; } = [];
    }
}
