using System.Xml.Serialization;

using NmapDotnet.Entities.Hosts;
using NmapDotnet.Entities.Scripts;

namespace NmapDotnet.Entities
{
    /// <summary>
    /// NmapRun represents a nmap scan result.
    /// </summary>
    [XmlRoot("nmaprun")]
    public class NmapRun
    {
        [XmlAttribute("args")]
        public string? Args { get; set; }

        [XmlAttribute("profile_name")]
        public string? ProfileName { get; set; }

        [XmlAttribute("scanner")]
        public string? Scanner { get; set; }

        [XmlAttribute("startstr")]
        public string? StartStr { get; set; }

        [XmlAttribute("version")]
        public string? Version { get; set; }

        [XmlAttribute("xmloutputversion")]
        public string? XMLOutputVersion { get; set; }

        [XmlElement("debugging")]
        public Debugging? Debugging { get; set; }

        [XmlElement("runstats")]
        public Stats? Stats { get; set; }

        [XmlElement("scaninfo")]
        public ScanInfo? ScanInfo { get; set; }

        [XmlAttribute("start")]
        public string? Start { get; set; }

        [XmlElement("verbose")]
        public Verbose? Verbose { get; set; }

        [XmlElement("host")]
        public List<Host>? Hosts { get; set; }

        [XmlElement("postscript>script")]
        public List<Script>? PostScripts { get; set; }

        [XmlElement("prescript>script")]
        public List<Script>? PreScripts { get; set; }

        [XmlElement("target")]
        public List<Target>? Targets { get; set; }

        [XmlElement("taskbegin")]
        public List<Task>? TaskBegin { get; set; }

        [XmlElement("taskprogress")]
        public List<TaskProgress>? TaskProgress { get; set; }

        [XmlElement("taskend")]
        public List<Task>? TaskEnd { get; set; }
    }
}
