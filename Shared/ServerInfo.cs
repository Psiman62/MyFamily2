namespace BlazorApp.Shared
{
    public class ServerInfo
    {
        public string FileVersion { get; set; }
        public string OSVersionId { get; set; }
        public string OSTimestamp { get; set; }
        public long TickCount64 { get; set; }

        public ServerInfo(string fileVersion, string oSVersionId, string oSTimestamp, long tickCount64)
        {
            FileVersion = fileVersion;
            OSVersionId = oSVersionId;
            OSTimestamp = oSTimestamp;
            TickCount64 = tickCount64;
        }
    }
}
