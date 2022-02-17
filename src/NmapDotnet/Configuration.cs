namespace NmapDotnet
{
    public class Configuration
    {
        public string NmapExecutablePath { get; set; } = "/usr/bin/nmap";

        public string WorkingDirectoryPath { get; set; } = ".";

        public string Arguments { get; set; } = string.Empty;
    }
}
