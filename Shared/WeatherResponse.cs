namespace BlazorApp.Shared
{
    public class ServerFunc1Response
    {
        public ServerInfo ServerInfo { get; set; }
    }
    public class ServerFunc2Response
    {
        public SampleRecord[] Forecasts { get; set; }
    }
}
