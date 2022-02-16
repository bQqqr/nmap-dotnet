using System.Xml.Serialization;

namespace NmapDotnet.Entities.Hosts
{
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
