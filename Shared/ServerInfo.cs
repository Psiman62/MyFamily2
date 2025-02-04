namespace BlazorApp.Shared
{
    public class ServerInfo
    {
        public string FileVersion { get; set; }
        public string OSTimestamp { get; set; }

        public ServerInfo(string fileVersion, string oSTimestamp)
        {
            FileVersion = fileVersion;
            OSTimestamp = oSTimestamp;
        }
    }
}
