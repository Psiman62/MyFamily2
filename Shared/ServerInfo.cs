namespace BlazorApp.Shared
{
    public class ServerInfo
    {
        public string FileVersion { get; set; }
        public string MachineName { get; set; }
        public string OSVersionId { get; set; }

        public ServerInfo(string fileVersion, string machineName, string oSVersionId)
        {
            FileVersion = fileVersion;
            MachineName = machineName;
            OSVersionId = oSVersionId;
        }
    }
}
