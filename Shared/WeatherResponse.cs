namespace BlazorApp.Shared
{
    public class ServerResponse
    {
        public SampleRecord[] Forecasts { get; set; }
        public ServerInfo ServerInfo { get; set; }
    }
}
