using System.Xml.Serialization;

namespace NmapDotnet.Entities
{
    /// <summary>
    /// Stats contains statistics for an nmap scan.
    /// </summary>
    public class Stats
    {
        [XmlElement("finished")]
        public Finished? Finished { get; set; }

        [XmlElement("hosts")]
        public HostStats? HostStats { get; set; }
    }

    /// <summary>
    /// Finished contains detailed statistics regarding a finished scan.
    /// </summary>
    public class Finished
    {
        [XmlAttribute("timestamp")]
        public string? Timestamp { get; set; }

        [XmlAttribute("timestr")]
        public string? TimeStr { get; set; }

        [XmlAttribute("elapsed")]
        public float Elapsed { get; set; }

        [XmlAttribute("summary")]
        public string? Summary { get; set; }

        [XmlAttribute("exit")]
        public string? Exit { get; set; }

        [XmlAttribute("errormsg")]
        public string? ErrorMsg { get; set; }
    }

    public class HostStats
    {
        [XmlAttribute("up")]
        public int Up { get; set; }

        [XmlAttribute("down")]
        public int Down { get; set; }

        [XmlAttribute("total")]
        public int Total { get; set; }
    }
}
