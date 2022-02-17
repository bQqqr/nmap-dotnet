using System.Xml.Serialization;

namespace NmapDotnet.Entities.Hosts
{
    /// <summary>
    /// Times contains time statistics for an nmap scan.
    /// </summary>
    public class Times
    {
        [XmlAttribute("srtt")]
        public string? SRTT { get; set; }

        [XmlAttribute("rttvar")]
        public string? RTT { get; set; }

        [XmlAttribute("to")]
        public string? TO { get; set; }
    }
}
