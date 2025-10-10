using System;

namespace BlazorApp.Shared
{
    public static class Constant
    {
        public static class ServerUrl
        {
            public const string ServerFunc1 = nameof(ServerFunc1);
            public const string ServerFunc2 = nameof(ServerFunc2);
        }
    }
    public class ServerInfo
    {
        public string FileVersion { get; set; }
        public string CommitDate { get; set; }
        public string OSTimestamp { get; set; }

        public ServerInfo(string fileVersion, DateTime commitDate, string oSTimestamp)
        {
            FileVersion = fileVersion;
            CommitDate = commitDate.ToString("O");
            OSTimestamp = oSTimestamp;
        }
    }
}
